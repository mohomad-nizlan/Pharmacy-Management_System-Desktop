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
    public partial class uc_p_viewMedicine : UserControl
    {
        function fn = new function();
        string query;

        public uc_p_viewMedicine()
        {
            InitializeComponent();
        }

        private void uc_p_viewMedicine_Load(object sender, EventArgs e)
        {
            // Load all medicines with updated column headers
            query = "SELECT mid AS 'M-ID', mname AS 'M-Name', mnumber AS 'M-Number', " +
                    "mDate AS 'Manf_Date', eDate AS 'Expy_Date', quantity AS 'Quantity', perUnit AS 'per-Unit' " +
                    "FROM medic";
            setDataGridView(query);
            StyleDataGridView();
        }

        private void txtUsername_p_TextChanged(object sender, EventArgs e)
        {
            // Search by medicine name or ID with updated column headers
            string searchText = txtUsername_p.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // If search box is empty, show all medicines
                query = "SELECT mid AS 'M-ID', mname AS 'M-Name', mnumber AS 'M-Number', " +
                        "mDate AS 'Manf_Date', eDate AS 'Expy_Date', quantity AS 'Quantity', perUnit AS 'per-Unit' " +
                        "FROM medic";
            }
            else
            {
                // Search by mid or mname using LIKE for partial matches
                query = "SELECT mid AS 'M-ID', mname AS 'M-Name', mnumber AS 'M-Number', " +
                        "mDate AS 'Manf_Date', eDate AS 'Expy_Date', quantity AS 'Quantity', perUnit AS 'per-Unit' " +
                        "FROM medic WHERE mname LIKE '%" + searchText + "%' OR mid LIKE '%" + searchText + "%'";
            }
            setDataGridView(query);
        }

        private void setDataGridView(string query)
        {
            try
            {
                DataSet ds = fn.getData(query);
                gunaDataGridView1_p.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleDataGridView()
        {
            // Style the GunaDataGridView to match "All Medicines" formatting
            // Column headers: black background, white text, bold, 10pt font, middle-center aligned
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1_p.EnableHeadersVisualStyles = false;

            // Remove blue color in header
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            gunaDataGridView1_p.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Fix column header height
            gunaDataGridView1_p.ColumnHeadersHeight = 30;
            gunaDataGridView1_p.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows: white background, black text, bold, 9pt font, middle-center aligned
            gunaDataGridView1_p.DefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_p.DefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_p.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gunaDataGridView1_p.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ensure no alternating row colors
            gunaDataGridView1_p.RowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_p.RowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_p.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1_p.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_p.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_p.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row hover: sky blue background, black text
            gunaDataGridView1_p.RowsDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            gunaDataGridView1_p.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            // Disable editing
            gunaDataGridView1_p.ReadOnly = true;
            gunaDataGridView1_p.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Disable resizing
            gunaDataGridView1_p.AllowUserToResizeColumns = false;
            gunaDataGridView1_p.AllowUserToResizeRows = false;

            // Keep auto-sizing columns
            gunaDataGridView1_p.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        string medicineId;

        private void gunaDataGridView1_p_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    medicineId = gunaDataGridView1_p.Rows[e.RowIndex].Cells[0].Value.ToString(); // Medicine ID is in first column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_p_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(medicineId))
            {
                MessageBox.Show("Please select a medicine to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this medicine?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    query = "DELETE FROM medic WHERE mid = '" + medicineId + "'";
                    fn.setData(query, "Medicine Record Deleted.");
                    uc_p_viewMedicine_Load(this, null); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSync_p_Click(object sender, EventArgs e)
        {
            uc_p_viewMedicine_Load(this, null); // Refresh the grid
        }

        private void gunaDataGridView1_p_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle double-click or specific cell content click if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Placeholder for any picture box functionality
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Placeholder for label click functionality
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for any combo box functionality
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}