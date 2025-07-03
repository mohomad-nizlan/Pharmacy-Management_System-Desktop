using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrack_PMS.pharmacistUC
{
    public partial class uc_p_medicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;

        public uc_p_medicineValidityCheck()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCheck.SelectedIndex == 0)
                {
                    query = "select * from medic where eDate >= getDate()";
                    setDataGridView(query, "Valid Medicines", Color.Green, Color.FromArgb(200, 255, 200), Color.Black, Color.White);
                    statePictureBox.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\valid.gif"; // Image for Valid Medicines
                }
                else if (txtCheck.SelectedIndex == 1)
                {
                    query = "select * from medic where eDate <= getDate()";
                    setDataGridView(query, "Expired Medicines", Color.Red, Color.FromArgb(255, 200, 200), Color.Black, Color.White);
                    statePictureBox.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\expired.gif"; // Image for Expired Medicines
                }
                else if (txtCheck.SelectedIndex == 2)
                {
                    query = "select * from medic";
                    setDataGridView(query, "", Color.Black, Color.White, Color.Black, Color.SkyBlue);
                    statePictureBox.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\all.gif"; // Image for All Medicines
                }
                statePictureBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Image Load Error - MediTrack Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statePictureBox.Image = null;
                statePictureBox.Refresh();
            }
        }

        private void setDataGridView(string query, String labelName, Color labelCol, Color rowBackColor, Color rowForeColor, Color hoverBackColor)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView1_V.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = labelCol;

            // Clear the PictureBox image before setting a new one (handled in txtCheck_SelectedIndexChanged)
            statePictureBox.Image = null;
            statePictureBox.ImageLocation = null;
            statePictureBox.Refresh();

            // Rename columns to match the requested format (8 columns as specified)
            if (gunaDataGridView1_V.Columns.Count >= 8)
            {
                gunaDataGridView1_V.Columns[0].HeaderText = "ID";
                gunaDataGridView1_V.Columns[1].HeaderText = "M-ID";
                gunaDataGridView1_V.Columns[2].HeaderText = "M-Name";
                gunaDataGridView1_V.Columns[3].HeaderText = "M-Number";
                gunaDataGridView1_V.Columns[4].HeaderText = "Manf_Date";
                gunaDataGridView1_V.Columns[5].HeaderText = "Expiry Date";
                gunaDataGridView1_V.Columns[6].HeaderText = "Quantity";
                gunaDataGridView1_V.Columns[7].HeaderText = "per-Unit";
            }

            // Update row styling dynamically
            gunaDataGridView1_V.DefaultCellStyle.BackColor = rowBackColor;
            gunaDataGridView1_V.DefaultCellStyle.ForeColor = rowForeColor;
            gunaDataGridView1_V.RowsDefaultCellStyle.BackColor = rowBackColor; // Ensure all rows are the same color
            gunaDataGridView1_V.RowsDefaultCellStyle.ForeColor = rowForeColor;
            gunaDataGridView1_V.AlternatingRowsDefaultCellStyle.BackColor = rowBackColor; // Remove alternating colors
            gunaDataGridView1_V.AlternatingRowsDefaultCellStyle.ForeColor = rowForeColor;
            gunaDataGridView1_V.RowsDefaultCellStyle.SelectionBackColor = hoverBackColor; // Set hover color
            gunaDataGridView1_V.RowsDefaultCellStyle.SelectionForeColor = rowForeColor; // Keep text color on hover
        }

        private void uc_p_medicineValidityCheck_Load(object sender, EventArgs e)
        {
            // Initialize label
            setLabel.Text = "";

            // Style the DataGridView
            // Column headers: black background, white text, bold
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1_V.EnableHeadersVisualStyles = false;

            // Column header borders: black
            gunaDataGridView1_V.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Remove blue color in header
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            gunaDataGridView1_V.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Fix column header height
            gunaDataGridView1_V.ColumnHeadersHeight = 30;
            gunaDataGridView1_V.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows: bold, centered
            gunaDataGridView1_V.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gunaDataGridView1_V.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row cell borders: black
            gunaDataGridView1_V.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gunaDataGridView1_V.GridColor = Color.Black; // All borders (header and cells) are black

            // Disable editing
            gunaDataGridView1_V.ReadOnly = true;
            gunaDataGridView1_V.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Disable resizing
            gunaDataGridView1_V.AllowUserToResizeColumns = false;
            gunaDataGridView1_V.AllowUserToResizeRows = false;

            // Style dropdown items (specific text colors)
            txtCheck.Items.Clear();
            txtCheck.Items.Add("Valid Medicines");
            txtCheck.Items.Add("Expired Medicines");
            txtCheck.Items.Add("All Medicines");

            // Assign the DropDown event handler
            txtCheck.DropDown += txtCheck_DropDown;

            // Load grid with "Valid Medicines" data on startup
            txtCheck.SelectedIndex = 0;
            query = "select * from medic where eDate >= getDate()";
            setDataGridView(query, "Valid Medicines", Color.Green, Color.FromArgb(200, 255, 200), Color.Black, Color.White);

            // Set the statePictureBox image to match the "Valid Medicines" state
            try
            {
                statePictureBox.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\valid.gif";
                statePictureBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Image Load Error - MediTrack Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statePictureBox.Image = null;
                statePictureBox.Refresh();
            }
        }

        private void txtCheck_DropDown(object sender, EventArgs e)
        {
            // Custom drawing to color specific dropdown items
            txtCheck.DrawMode = DrawMode.OwnerDrawFixed;
            txtCheck.DrawItem += (s, args) =>
            {
                if (args.Index < 0) return;

                string itemText = txtCheck.Items[args.Index].ToString();
                Color itemColor = Color.Black;

                if (itemText == "Valid Medicines")
                    itemColor = Color.Green;
                else if (itemText == "Expired Medicines")
                    itemColor = Color.Red;

                using (Brush brush = new SolidBrush(itemColor))
                {
                    args.DrawBackground();
                    args.Graphics.DrawString(itemText, txtCheck.Font, brush, args.Bounds);
                    args.DrawFocusRectangle();
                }
            };
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void gunaDataGridView1_V_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}