using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // For handling image streams

namespace MediTrack_PMS.AdministratorUC
{
    public partial class uc_viewUser : UserControl
    {
        function fn = new function();
        String query;
        string currentUser = "";
        private Timer debounceTimer; // For debouncing search
        private string userName; // Store selected username for deletion
        private string highlightedUserName; // Store the username of the currently highlighted row
        private int lastHoveredRowIndex = -1; // Track the last hovered row for styling

        public uc_viewUser()
        {
            InitializeComponent();

            // Initialize debounce timer for search
            debounceTimer = new Timer
            {
                Interval = 300 // 300ms delay
            };
            debounceTimer.Tick += (s, e) =>
            {
                debounceTimer.Stop();
                SearchUsers();
            };

            // Set PictureBox SizeMode to stretch the image (same as uc_profile)
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void uc_viewUser_Load(object sender, EventArgs e)
        {
            // Load all users with updated column headers
            query = "SELECT id AS 'User ID', userRole AS 'Role', name AS 'Full Name', dob AS 'Date of Birth', " +
                    "mobile AS 'Phone Number', email AS 'Email', username AS 'Username', pass AS 'Password' " +
                    "FROM users";
            setDataGridView(query);
            StyleDataGridView();
            pictureBox1.Image = null; // Clear PictureBox on load
            highlightedUserName = null; // Reset highlighted username
            lastHoveredRowIndex = -1; // Reset last hovered row
            userName = null; // Reset selected username
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
             // Start or restart the debounce timer
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void SearchUsers()
        {
            string searchText = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // If search box is empty, show all users
                query = "SELECT id AS 'User ID', userRole AS 'Role', name AS 'Full Name', dob AS 'Date of Birth', " +
                        "mobile AS 'Phone Number', email AS 'Email', username AS 'Username', pass AS 'Password' " +
                        "FROM users";
                setDataGridView(query);
            }
            else
            {
                // Search by username using LIKE for partial matches
                query = "SELECT id AS 'User ID', userRole AS 'Role', name AS 'Full Name', dob AS 'Date of Birth', " +
                        "mobile AS 'Phone Number', email AS 'Email', username AS 'Username', pass AS 'Password' " +
                        "FROM users WHERE username LIKE @searchText";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@searchText", searchText + "%" }
                };
                setDataGridView(query, parameters);

                // If exactly one user is found, highlight the row and load their profile picture
                if (gunaDataGridView1.Rows.Count == 1)
                {
                    string foundUserName = gunaDataGridView1.Rows[0].Cells[6].Value?.ToString(); // Username is in column index 6
                    highlightedUserName = foundUserName; // Update highlighted username
                    userName = foundUserName; // Update selected username for deletion
                    LoadProfilePicture(highlightedUserName);
                    gunaDataGridView1.Rows[0].Selected = true; // Select the row to highlight it
                }
            }
        }

        private void setDataGridView(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                DataSet ds = parameters == null ? fn.getData(query) : fn.getData(query, parameters);
                gunaDataGridView1.DataSource = ds.Tables[0];
                pictureBox1.Image = null; // Clear PictureBox when data is refreshed
                pictureBox1.Refresh(); // Force PictureBox refresh
                highlightedUserName = null; // Reset highlighted username
                lastHoveredRowIndex = -1; // Reset last hovered row
                userName = null; // Reset selected username
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading users: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void StyleDataGridView()
        {
            // Style the GunaDataGridView to match uc_p_viewMedicine formatting
            // Column headers: black background, white text, bold, 10pt font, middle-center aligned
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1.EnableHeadersVisualStyles = false;

            // Remove blue color in header
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Fix column header height
            gunaDataGridView1.ColumnHeadersHeight = 30;
            gunaDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows: white background, black text, bold, 9pt font, middle-center aligned
            gunaDataGridView1.DefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gunaDataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ensure no alternating row colors
            gunaDataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row selection: sky blue background, black text
            gunaDataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            gunaDataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            // Add black borders to all cells, headers, and grid lines
            gunaDataGridView1.GridColor = Color.Black; // Set grid line color to black
            gunaDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Solid borders around cells
            gunaDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Solid borders around column headers
            gunaDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Solid borders around row headers (if visible)

            // Disable editing
            gunaDataGridView1.ReadOnly = true;
            gunaDataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Disable resizing
            gunaDataGridView1.AllowUserToResizeColumns = false;
            gunaDataGridView1.AllowUserToResizeRows = false;

            // Keep auto-sizing columns
            gunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadProfilePicture(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                pictureBox1.Image = null;
                pictureBox1.Refresh(); // Force PictureBox refresh
                return;
            }

            try
            {
                query = "SELECT profilePic FROM users WHERE username = @username";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@username", username }
                };
                DataSet ds = fn.getData(query, parameters);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["profilePic"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])ds.Tables[0].Rows[0]["profilePic"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null; // No image in database
                    }
                }
                else
                {
                    pictureBox1.Image = null; // User not found
                }
                pictureBox1.Refresh(); // Force PictureBox refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading profile picture: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                pictureBox1.Image = null;
                pictureBox1.Refresh(); // Force PictureBox refresh
            }
        }

        private void gunaDataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (gunaDataGridView1.CurrentCell != null)
                {
                    int rowIndex = gunaDataGridView1.CurrentCell.RowIndex;
                    if (rowIndex >= 0)
                    {
                        highlightedUserName = gunaDataGridView1.Rows[rowIndex].Cells[6].Value?.ToString(); // Username is in column index 6
                        userName = highlightedUserName; // Update selected username for deletion
                        LoadProfilePicture(highlightedUserName); // Load the profile picture
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error on current cell change: " + ex.Message,
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                highlightedUserName = null;
                userName = null;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    highlightedUserName = gunaDataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString(); // Username is in column index 6
                    userName = highlightedUserName; // Update selected username for deletion
                    LoadProfilePicture(highlightedUserName); // Load the profile picture
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting user: " + ex.Message,
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                highlightedUserName = null;
                userName = null;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }

        private void gunaDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Highlight the row on hover
                    if (lastHoveredRowIndex >= 0 && lastHoveredRowIndex < gunaDataGridView1.Rows.Count)
                    {
                        // Only reset the previous row's color if it's not selected
                        if (gunaDataGridView1.CurrentCell == null || gunaDataGridView1.CurrentCell.RowIndex != lastHoveredRowIndex)
                        {
                            gunaDataGridView1.Rows[lastHoveredRowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    gunaDataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                    lastHoveredRowIndex = e.RowIndex;

                    // Load the profile picture
                    highlightedUserName = gunaDataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString(); // Username is in column index 6
                    userName = highlightedUserName; // Update selected username for deletion
                    LoadProfilePicture(highlightedUserName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error on hover: " + ex.Message,
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                highlightedUserName = null;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }

        private void gunaDataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Only reset the hover style if the row is not selected
                    if (gunaDataGridView1.CurrentCell == null || gunaDataGridView1.CurrentCell.RowIndex != e.RowIndex)
                    {
                        gunaDataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                    lastHoveredRowIndex = -1; // Reset last hovered row
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error on mouse leave: " + ex.Message,
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show(
                    "Please select a user to delete.",
                    "Warning - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (currentUser == userName)
            {
                MessageBox.Show(
                    "You cannot delete your own profile.",
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Delete Confirmation - MediTrack Pharmacy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    query = "DELETE FROM users WHERE username = @username";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@username", userName }
                    };
                    fn.setData(query, parameters, "User Record Deleted - MediTrack Pharmacy");
                    uc_viewUser_Load(this, null); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting user: " + ex.Message,
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            uc_viewUser_Load(this, null); // Refresh the grid
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}