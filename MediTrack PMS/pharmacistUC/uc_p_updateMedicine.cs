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
using System.Globalization;

namespace MediTrack_PMS.pharmacistUC
{
    public partial class uc_p_updateMedicine : UserControl
    {
        function fn = new function();
        String query;
        private bool isMedicineSearched = false; // Track if a medicine has been searched
        private string originalMname, originalMnumber, originalMdate, originalEdate, originalQuantity, originalPrice; // Store original values

        public uc_p_updateMedicine()
        {
            InitializeComponent();
        }

        private void label17_p_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txt_med_price_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btn_Search_u_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_med_id_u.Text))
            {
                MessageBox.Show("Please enter a Medicine ID to search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                return;
            }

            // Validate medicine ID format (e.g., "M101")
            if (!Regex.IsMatch(txt_med_id_u.Text, @"^M\d{3}$"))
            {
                MessageBox.Show("Medicine ID must be in the format 'M' followed by 3 digits (e.g., M101).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Make search case-insensitive using UPPER
                query = "select * from medic where UPPER(mid) = UPPER('" + txt_med_id_u.Text.Replace("'", "''") + "')";
                DataSet ds = fn.getData(query);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txt_med_name_u.Text = ds.Tables[0].Rows[0][2].ToString();
                    txt_med_num_u.Text = ds.Tables[0].Rows[0][3].ToString();

                    // Parse VARCHAR dates from database into DateTimePicker with specific format
                    string mDateStr = ds.Tables[0].Rows[0][4].ToString();
                    string eDateStr = ds.Tables[0].Rows[0][5].ToString();

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(mDateStr))
                        {
                            txt_man_date_u.Value = DateTime.ParseExact(mDateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            txt_man_date_u.Value = DateTime.Today; // Default to today if empty
                        }

                        if (!string.IsNullOrWhiteSpace(eDateStr))
                        {
                            txt_exp_date_u.Value = DateTime.ParseExact(eDateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            txt_exp_date_u.Value = DateTime.Today; // Default to today if empty
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid date format in database for Manufacture or Expiry Date. Expected format: yyyy-MM-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_man_date_u.Value = DateTime.Today;
                        txt_exp_date_u.Value = DateTime.Today;
                    }

                    txt_med_AvailableQuality_u.Text = ds.Tables[0].Rows[0][6].ToString();
                    txt_med_price_u.Text = ds.Tables[0].Rows[0][7].ToString();

                    // Store original values to check for changes later
                    originalMname = txt_med_name_u.Text;
                    originalMnumber = txt_med_num_u.Text;
                    originalMdate = txt_man_date_u.Value.ToString("yyyy-MM-dd");
                    originalEdate = txt_exp_date_u.Value.ToString("yyyy-MM-dd");
                    originalQuantity = txt_med_AvailableQuality_u.Text;
                    originalPrice = txt_med_price_u.Text;

                    isMedicineSearched = true; // Mark that a medicine has been searched

                    // Make txt_med_id_u read-only to prevent changes after search
                    txt_med_id_u.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No Medicine with ID: " + txt_med_id_u.Text + " exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    isMedicineSearched = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearAll();
                isMedicineSearched = false;
            }
        }

        private void clearAll()
        {
            txt_med_id_u.Clear();
            txt_med_name_u.Clear();
            txt_med_num_u.Clear();
            txt_man_date_u.ResetText();
            txt_man_date_u.Value = DateTime.Today; // Explicitly set to default (today)
            txt_exp_date_u.ResetText();
            txt_exp_date_u.Value = DateTime.Today; // Explicitly set to default (today)
            txt_med_AvailableQuality_u.Clear();
            txt_med_price_u.Clear();
            txt_med_addQuantity_u.Text = "0";
            isMedicineSearched = false; // Reset search flag

            // Reset original values
            originalMname = null;
            originalMnumber = null;
            originalMdate = null;
            originalEdate = null;
            originalQuantity = null;
            originalPrice = null;

            // Make txt_med_id_u editable again after clearing
            txt_med_id_u.ReadOnly = false;
        }

        private void btnReset_u_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_u_Click(object sender, EventArgs e)
        {
            // Check if a medicine has been searched
            if (!isMedicineSearched)
            {
                MessageBox.Show("Please search for a medicine first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate all required fields are filled
            if (string.IsNullOrWhiteSpace(txt_med_id_u.Text) ||
                string.IsNullOrWhiteSpace(txt_med_name_u.Text) ||
                string.IsNullOrWhiteSpace(txt_med_num_u.Text) ||
                string.IsNullOrWhiteSpace(txt_med_AvailableQuality_u.Text) ||
                string.IsNullOrWhiteSpace(txt_med_price_u.Text) ||
                string.IsNullOrWhiteSpace(txt_med_addQuantity_u.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate batch number format (e.g., "BATCH001")
            if (!Regex.IsMatch(txt_med_num_u.Text, @"^BATCH\d{3}$"))
            {
                MessageBox.Show("Batch number must be in the format 'BATCH' followed by 3 digits (e.g., BATCH001).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate numeric fields
            if (!Int64.TryParse(txt_med_AvailableQuality_u.Text, out Int64 quantity) || quantity < 0)
            {
                MessageBox.Show("Available quantity must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int64.TryParse(txt_med_addQuantity_u.Text, out Int64 addQuantity) || addQuantity < 0)
            {
                MessageBox.Show("Add quantity must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int64.TryParse(txt_med_price_u.Text, out Int64 unitprice) || unitprice <= 0)
            {
                MessageBox.Show("Unit price must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate dates
            DateTime mDate = txt_man_date_u.Value;
            DateTime eDate = txt_exp_date_u.Value;

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

            // Check if any data has changed
            bool hasChanges = txt_med_name_u.Text != originalMname ||
                              txt_med_num_u.Text != originalMnumber ||
                              txt_man_date_u.Value.ToString("yyyy-MM-dd") != originalMdate ||
                              txt_exp_date_u.Value.ToString("yyyy-MM-dd") != originalEdate ||
                              txt_med_AvailableQuality_u.Text != originalQuantity ||
                              txt_med_price_u.Text != originalPrice ||
                              addQuantity > 0; // Consider addQuantity as a change

            if (!hasChanges)
            {
                MessageBox.Show("No changes detected. Please modify the medicine details to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Sanitize text inputs to prevent SQL injection
                String mid = txt_med_id_u.Text.Replace("'", "''");
                String mname = txt_med_name_u.Text.Replace("'", "''");
                String mnumber = txt_med_num_u.Text.Replace("'", "''");

                // Format dates as strings for VARCHAR columns
                String mdate = txt_man_date_u.Value.ToString("yyyy-MM-dd");
                String edate = txt_exp_date_u.Value.ToString("yyyy-MM-dd");

                // Calculate total quantity
                totalQuantity = quantity + addQuantity;

                // Update the medicine in the database (mDate and eDate are VARCHAR, so use string format)
                query = "update medic set mname = '" + mname + "', mnumber = '" + mnumber + "', mDate = '" + mdate + "', eDate = '" + edate + "', quantity = " + totalQuantity + ", perUnit = " + unitprice + " where mid = '" + mid + "'";
                fn.setData(query, "Medicine Details Updated Successfully.");

                // Clear the form after a successful update
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating medicine: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_exp_date_u_ValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void uc_p_updateMedicine_Load(object sender, EventArgs e)
        {
        }

        private void txt_med_num_u_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_med_id_u_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_med_name_u_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_med_AvailableQuality_u_TextChanged(object sender, EventArgs e)
        {
        }
    }
}