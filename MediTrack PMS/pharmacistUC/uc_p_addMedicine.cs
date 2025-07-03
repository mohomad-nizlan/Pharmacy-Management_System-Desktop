using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MediTrack_PMS.pharmacistUC
{
    public partial class uc_p_addMedicine : UserControl
    {
        function fn = new function();
        string query;

        public uc_p_addMedicine()
        {
            InitializeComponent();
        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate all fields are filled
            if (string.IsNullOrWhiteSpace(txt_med_id.Text) ||
                string.IsNullOrWhiteSpace(txt_med_name.Text) ||
                string.IsNullOrWhiteSpace(txt_med_num.Text) ||
                string.IsNullOrWhiteSpace(txt_med_quality.Text) ||
                string.IsNullOrWhiteSpace(txt_med_price.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate medicine ID format (e.g., "M101")
            if (!Regex.IsMatch(txt_med_id.Text, @"^M\d{3}$"))
            {
                MessageBox.Show("Medicine ID must be in the format 'M' followed by 3 digits (e.g., M101).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if medicine ID already exists
            query = "select count(*) from medic where mid = '" + txt_med_id.Text.Replace("'", "''") + "'";
            DataSet ds = fn.getData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("A medicine with ID " + txt_med_id.Text + " already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate numeric fields
            if (!Int64.TryParse(txt_med_quality.Text, out Int64 quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int64.TryParse(txt_med_price.Text, out Int64 perunit) || perunit <= 0)
            {
                MessageBox.Show("Price per unit must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate dates
            DateTime mDate = txt_man_date.Value;
            DateTime eDate = txt_exp_date.Value;

            // Check if manufacture date is not in the future
            if (mDate > DateTime.Today)
            {
                MessageBox.Show("Manufacture date cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if expiry date is after manufacture date
            if (eDate <= mDate)
            {
                MessageBox.Show("Expiry date must be after the manufacture date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sanitize text inputs to prevent SQL injection
            String mid = txt_med_id.Text.Replace("'", "''");
            String mname = txt_med_name.Text.Replace("'", "''");
            String mnumber = txt_med_num.Text.Replace("'", "''");

            // Format dates as strings for VARCHAR columns
            String mdate = mDate.ToString("yyyy-MM-dd");
            String edate = eDate.ToString("yyyy-MM-dd");

            // Insert the new medicine into the database
            query = "insert into medic (mid, mname, mnumber, mDate, eDate, quantity, perUnit) values ('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "', " + quantity + ", " + perunit + ")";
            fn.setData(query, "Medicine Added to Database Successfully.");

            // Clear the form after successful addition
            clearAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txt_med_id.Clear();
            txt_med_name.Clear();
            txt_med_quality.Clear();
            txt_med_num.Clear();
            txt_med_price.Clear();
            txt_man_date.ResetText();
            txt_man_date.Value = DateTime.Today; // Set to default (today)
            txt_exp_date.ResetText();
            txt_exp_date.Value = DateTime.Today; // Set to default (today)
        }

        private void txt_med_quality_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void uc_p_addMedicine_Load(object sender, EventArgs e)
        {
        }
    }
}