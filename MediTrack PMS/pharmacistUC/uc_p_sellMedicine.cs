using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using Microsoft.VisualBasic;

namespace MediTrack_PMS.pharmacistUC
{
    public partial class uc_p_sellMedicine : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        private string cashierName;

        public uc_p_sellMedicine()
        {
            InitializeComponent();
        }

        public void SetCashierName(string name)
        {
            this.cashierName = name;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void uc_p_sellMedicine_Load(object sender, EventArgs e)
        {
            ListBoxMedicines.Items.Clear();
            query = "SELECT mname FROM medic WHERE TRY_CONVERT(DATE, eDate, 23) >= GETDATE() AND quantity > 0 AND TRY_CONVERT(DATE, eDate, 23) IS NOT NULL";
            ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else
            {
                MessageBox.Show(
                    "No medicines available in stock.",
                    "Stock Information - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            totalPrice.Text = "RS. 0.00";
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1_S.EnableHeadersVisualStyles = false;

            gunaDataGridView1_S.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            gunaDataGridView1_S.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            gunaDataGridView1_S.ColumnHeadersHeight = 30;
            gunaDataGridView1_S.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            gunaDataGridView1_S.DefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_S.DefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_S.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            gunaDataGridView1_S.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gunaDataGridView1_S.RowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_S.RowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_S.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView1_S.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gunaDataGridView1_S.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            gunaDataGridView1_S.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gunaDataGridView1_S.RowsDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            gunaDataGridView1_S.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            gunaDataGridView1_S.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gunaDataGridView1_S.GridColor = Color.Black;

            gunaDataGridView1_S.ReadOnly = true;
            gunaDataGridView1_S.EditMode = DataGridViewEditMode.EditProgrammatically;

            gunaDataGridView1_S.AllowUserToResizeColumns = false;
            gunaDataGridView1_S.AllowUserToResizeRows = false;

            gunaDataGridView1_S.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (gunaDataGridView1_S.Columns.Count == 0)
            {
                gunaDataGridView1_S.Columns.Add("MedicineID", "Medicine ID");
                gunaDataGridView1_S.Columns.Add("MedicineName", "Medicine Name");
                gunaDataGridView1_S.Columns.Add("ExpiryDate", "Expiry Date");
                gunaDataGridView1_S.Columns.Add("PricePerUnit", "Price/Unit");
                gunaDataGridView1_S.Columns.Add("Units", "Units");
                gunaDataGridView1_S.Columns.Add("TotalPrice", "Total Price");
            }
        }

        private void btnSync_S_Click(object sender, EventArgs e)
        {
            uc_p_sellMedicine_Load(this, null);
            clearAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ListBoxMedicines.Items.Clear();

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                uc_p_sellMedicine_Load(this, null);
                return;
            }

            if (txtSearch.Text.Length > 50)
            {
                MessageBox.Show(
                    "Search text is too long. Please enter up to 50 characters.",
                    "Invalid Input - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtSearch.Text = txtSearch.Text.Substring(0, 50);
                return;
            }

            query = "SELECT mname FROM medic WHERE mname LIKE @mname + '%'";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@mname", txtSearch.Text }
            };
            ds = fn.getData(query, parameters);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else
            {
                MessageBox.Show(
                    "No medicines found matching your search.",
                    "Search Result - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void ListBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Units.Clear();

            if (ListBoxMedicines.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a medicine from the list.",
                    "Selection Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            string name = ListBoxMedicines.GetItemText(ListBoxMedicines.SelectedItem);
            txt_med_name.Text = name;
            query = "SELECT mid, eDate, perUnit FROM medic WHERE mname = @mname";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@mname", name }
            };
            ds = fn.getData(query, parameters);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txt_MedI_D.Text = ds.Tables[0].Rows[0][0].ToString();
                string expDateStr = ds.Tables[0].Rows[0][1].ToString();
                txt_PricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();

                if (DateTime.TryParse(expDateStr, out DateTime expDate))
                {
                    txt_Exp_date.Value = expDate;
                }
                else
                {
                    MessageBox.Show(
                        "Invalid expiry date format in database: " + expDateStr,
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show(
                    "Medicine details not found in database.",
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                clearAll();
            }
        }

        private void txt_Units_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(
                    "Please enter only numeric values for units.",
                    "Invalid Input - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void txt_Units_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Units.Text))
            {
                if (decimal.TryParse(txt_PricePerUnit.Text, out decimal unitPrice) &&
                    Int64.TryParse(txt_Units.Text, out Int64 noOfUnits) && noOfUnits >= 0)
                {
                    decimal totalAmount = unitPrice * noOfUnits;
                    txt_TotalPrice.Text = totalAmount.ToString("F2");
                }
                else
                {
                    txt_TotalPrice.Text = "0.00";
                }
            }
            else
            {
                txt_TotalPrice.Text = "0.00";
            }
        }

        private void txt_Exp_date_ValueChanged(object sender, EventArgs e)
        {
        }

        protected int n;
        protected decimal totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_MedI_D.Text))
            {
                if (txt_Exp_date.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show(
                        "This medicine is expired!\nExpiry Date: " + txt_Exp_date.Value.ToString("yyyy-MM-dd"),
                        "Expired Medicine - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    clearAll();
                    return;
                }

                query = "SELECT quantity FROM medic WHERE mid = @mid";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@mid", txt_MedI_D.Text }
                };
                ds = fn.getData(query, parameters);

                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Medicine not found in database.",
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (!Int64.TryParse(ds.Tables[0].Rows[0][0].ToString(), out quantity))
                {
                    MessageBox.Show(
                        "Invalid quantity data from database.",
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (!Int64.TryParse(txt_Units.Text, out Int64 units) || units <= 0)
                {
                    MessageBox.Show(
                        "Please enter a valid number of units (greater than 0).",
                        "Invalid Input - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (units > quantity)
                {
                    MessageBox.Show(
                        "Requested units exceed available stock.\nOnly " + quantity + " units left.",
                        "Stock Warning - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (units > 1000)
                {
                    MessageBox.Show(
                        "Requested units exceed maximum allowed (1000).",
                        "Invalid Input - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                newQuantity = quantity - units;

                if (newQuantity >= 0)
                {
                    int existingRowIndex = -1;
                    for (int i = 0; i < gunaDataGridView1_S.Rows.Count; i++)
                    {
                        if (gunaDataGridView1_S.Rows[i].Cells.Count > 0 && gunaDataGridView1_S.Rows[i].Cells[0].Value?.ToString() == txt_MedI_D.Text)
                        {
                            existingRowIndex = i;
                            break;
                        }
                    }

                    if (existingRowIndex >= 0)
                    {
                        if (!Int64.TryParse(gunaDataGridView1_S.Rows[existingRowIndex].Cells[4].Value?.ToString(), out Int64 currentUnits))
                        {
                            MessageBox.Show(
                                "Invalid units data in cart.",
                                "Cart Error - MediTrack Pharmacy",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }

                        if (!decimal.TryParse(gunaDataGridView1_S.Rows[existingRowIndex].Cells[5].Value?.ToString(), out decimal currentTotal))
                        {
                            MessageBox.Show(
                                "Invalid total price data in cart.",
                                "Cart Error - MediTrack Pharmacy",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }

                        Int64 updatedUnits = currentUnits + units;
                        decimal unitPrice = decimal.Parse(txt_PricePerUnit.Text);
                        decimal updatedTotal = unitPrice * updatedUnits;

                        gunaDataGridView1_S.Rows[existingRowIndex].Cells[4].Value = updatedUnits.ToString();
                        gunaDataGridView1_S.Rows[existingRowIndex].Cells[5].Value = updatedTotal.ToString("F2");

                        totalAmount = totalAmount - currentTotal + updatedTotal;
                        totalPrice.Text = "RS. " + totalAmount.ToString("F2");
                    }
                    else
                    {
                        n = gunaDataGridView1_S.Rows.Add();
                        gunaDataGridView1_S.Rows[n].Cells[0].Value = txt_MedI_D.Text;
                        gunaDataGridView1_S.Rows[n].Cells[1].Value = txt_med_name.Text;
                        gunaDataGridView1_S.Rows[n].Cells[2].Value = txt_Exp_date.Text;
                        gunaDataGridView1_S.Rows[n].Cells[3].Value = txt_PricePerUnit.Text;
                        gunaDataGridView1_S.Rows[n].Cells[4].Value = txt_Units.Text;
                        gunaDataGridView1_S.Rows[n].Cells[5].Value = txt_TotalPrice.Text;

                        if (decimal.TryParse(txt_TotalPrice.Text, out decimal itemTotal))
                        {
                            totalAmount += itemTotal;
                            totalPrice.Text = "RS. " + totalAmount.ToString("F2");
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid total price format.",
                                "Cart Error - MediTrack Pharmacy",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                    }

                    query = "UPDATE medic SET quantity = @newQuantity WHERE mid = @mid";
                    parameters = new Dictionary<string, object>
                    {
                        { "@newQuantity", newQuantity },
                        { "@mid", txt_MedI_D.Text }
                    };
                    fn.setData(query, parameters, "Medicine Added to Cart - MediTrack Pharmacy");

                    clearAll();
                }
                else
                {
                    MessageBox.Show(
                        "Medicine is out of stock.\nOnly " + quantity + " units left.",
                        "Stock Warning - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a medicine first.",
                    "Selection Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void gunaDataGridView1_S_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1_S.SelectedRows.Count > 0)
            {
                int selectedIndex = gunaDataGridView1_S.SelectedRows[0].Index;

                string valueId = gunaDataGridView1_S.Rows[selectedIndex].Cells[0].Value?.ToString();
                if (string.IsNullOrWhiteSpace(valueId))
                {
                    MessageBox.Show(
                        "Medicine ID in cart is empty.",
                        "Cart Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                string totalPriceText = gunaDataGridView1_S.Rows[selectedIndex].Cells[5].Value?.ToString();
                if (!decimal.TryParse(totalPriceText, out decimal valueAmount) || valueAmount < 0)
                {
                    MessageBox.Show(
                        "Invalid or negative total price in cart: " + (totalPriceText ?? "null"),
                        "Cart Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                string unitsText = gunaDataGridView1_S.Rows[selectedIndex].Cells[4].Value?.ToString();
                if (!Int64.TryParse(unitsText, out Int64 noOfUnit))
                {
                    MessageBox.Show(
                        "Invalid units in cart: " + (unitsText ?? "null"),
                        "Cart Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                try
                {
                    gunaDataGridView1_S.Rows.RemoveAt(selectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error removing item from cart: " + ex.Message,
                        "Cart Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                query = "SELECT quantity FROM medic WHERE mid = @mid";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@mid", valueId }
                };
                ds = fn.getData(query, parameters);

                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Medicine not found in database.",
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (!Int64.TryParse(ds.Tables[0].Rows[0][0].ToString(), out quantity))
                {
                    MessageBox.Show(
                        "Invalid quantity data from database.",
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                newQuantity = quantity + noOfUnit;

                query = "UPDATE medic SET quantity = @newQuantity WHERE mid = @mid";
                parameters = new Dictionary<string, object>
                {
                    { "@newQuantity", newQuantity },
                    { "@mid", valueId }
                };
                fn.setData(query, parameters, "Medicine Removed from Cart - MediTrack Pharmacy");
                MessageBox.Show(
                    "Medicine successfully removed from cart.",
                    "Success - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                totalAmount -= valueAmount;
                totalPrice.Text = "RS. " + totalAmount.ToString("F2");

                uc_p_sellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show(
                    "Please select an item to remove from the cart.",
                    "Selection Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btn_purchasePrint_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1_S.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Cart is empty. Please add items before printing the bill.",
                    "Cart Empty - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to print the bill and clear the cart?",
                "Confirm Print - MediTrack Pharmacy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result != DialogResult.Yes)
            {
                return;
            }

            string customerName = Interaction.InputBox(
                "Please enter the customer's name:",
                "Customer Name - MediTrack Pharmacy",
                "Guest"
            );
            if (string.IsNullOrEmpty(customerName))
            {
                customerName = "Guest";
            }

            try
            {
                DataGridView tempGrid = new DataGridView();
                tempGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                tempGrid.AllowUserToAddRows = false;
                tempGrid.AllowUserToDeleteRows = false;
                tempGrid.ReadOnly = true;

                tempGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                tempGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                tempGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                tempGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tempGrid.EnableHeadersVisualStyles = false;

                tempGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                tempGrid.DefaultCellStyle.BackColor = Color.White;
                tempGrid.DefaultCellStyle.ForeColor = Color.Black;
                tempGrid.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
                tempGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                tempGrid.RowsDefaultCellStyle.BackColor = Color.White;
                tempGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 228, 245);

                tempGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                tempGrid.GridColor = Color.Black;

                // Manually define columns with widths to fit within default margins (495 pixels for A4 with default margins)
                tempGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                tempGrid.Columns.Add("MedicineID", "Medicine ID");
                tempGrid.Columns[0].Width = 75;
                tempGrid.Columns.Add("MedicineName", "Medicine Name");
                tempGrid.Columns[1].Width = 135;
                tempGrid.Columns.Add("ExpiryDate", "Expiry Date");
                tempGrid.Columns[2].Width = 90;
                tempGrid.Columns.Add("PricePerUnit", "Price/Unit");
                tempGrid.Columns[3].Width = 65;
                tempGrid.Columns.Add("Units", "Units");
                tempGrid.Columns[4].Width = 45;
                tempGrid.Columns.Add("TotalPrice", "Total Price");
                tempGrid.Columns[5].Width = 85;

                // Copy rows from gunaDataGridView1_S to tempGrid
                foreach (DataGridViewRow row in gunaDataGridView1_S.Rows)
                {
                    if (row.IsNewRow) continue;
                    DataGridViewRow newRow = row.Clone() as DataGridViewRow;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }
                    tempGrid.Rows.Add(newRow);
                }

                // Add the "Total" row
                int totalRowIndex = tempGrid.Rows.Add();
                tempGrid.Rows[totalRowIndex].Cells[0].Value = "Total";
                tempGrid.Rows[totalRowIndex].Cells[5].Value = totalPrice.Text;
                tempGrid.Rows[totalRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(47, 79, 127);
                tempGrid.Rows[totalRowIndex].DefaultCellStyle.ForeColor = Color.White;
                tempGrid.Rows[totalRowIndex].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                // Set column header height (greater than data rows)
                tempGrid.ColumnHeadersHeight = 40;

                // Set row heights
                foreach (DataGridViewRow row in tempGrid.Rows)
                {
                    if (row.Index != totalRowIndex)
                    {
                        row.Height = 30; // Data rows
                    }
                    else
                        row.Height = 35; // "Total" row
                }

                DGVPrinter print = new DGVPrinter();

                print.Title = "MediTrack Pharmacy\nYour Health our Priority\n456 Thihariya, Nittambuwa\nPhone: (+94) 753627840 | Email: meditrack@gmail.com";
                print.TitleFont = new Font("Arial", 14, FontStyle.Bold);
                print.TitleAlignment = StringAlignment.Center;
                print.TitleSpacing = 30;

                string billNumber = "BILL-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                string paymentMethod = "Cash";
                print.SubTitle = $"Medicine Bill\nBill No: {billNumber}\nDate: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\nCashier: {cashierName}\nCustomer: {customerName}\nPayment Method: {paymentMethod}";
                print.SubTitleFont = new Font("Arial", 10, FontStyle.Regular);
                print.SubTitleAlignment = StringAlignment.Near;
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.SubTitleSpacing = 15;

                print.PorportionalColumns = false; // Use manually set widths
                print.HeaderCellAlignment = StringAlignment.Center;
                print.CellAlignment = StringAlignment.Center;

                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PageNumberAlignment = StringAlignment.Far;

                print.Footer = "Thank You for Choosing MediTrack Pharmacy!\nYour Health, Our Priority.\n\nNotes: Please consume as prescribed.";
                print.FooterFont = new Font("Arial", 10, FontStyle.Italic);
                print.FooterAlignment = StringAlignment.Center;
                print.FooterSpacing = 20;

                print.PrintDataGridView(tempGrid);

                totalAmount = 0;
                totalPrice.Text = "RS. 0.00";
                gunaDataGridView1_S.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error printing bill: " + ex.Message,
                    "Print Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void totalPrice_Click(object sender, EventArgs e)
        {
        }

        private void txt_med_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            txt_MedI_D.Clear();
            txt_PricePerUnit.Clear();
            txt_Units.Clear();
            txt_med_name.Clear();
            txt_Exp_date.Value = DateTime.Now;
            txt_TotalPrice.Text = "0.00";
        }
    }
}