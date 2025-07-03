using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediTrack_PMS.pharmacistUC;
using Microsoft.VisualBasic;

namespace MediTrack_PMS
{
    public partial class pharmacist : Form
    {
        private string cashierName;

        public pharmacist()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uc_p_addMedicine1.Visible = true;
            uc_p_addMedicine1.BringToFront();
        }

        private void uc_p_dashboard1_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uc_p_dashboard1.Visible = true;
            uc_p_dashboard1.BringToFront();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {
            // Prompt for cashier name until a valid name is entered
            string inputName;
            do
            {
                inputName = Interaction.InputBox(
                    "Please enter the cashier's name (required):",
                    "Cashier Name Required - MediTrack Pharmacy",
                    "Unknown"
                );

                // If the user cancels or enters an empty/whitespace name, show a warning and prompt again
                if (string.IsNullOrWhiteSpace(inputName))
                {
                    MessageBox.Show(
                        "Cashier name cannot be empty. Please enter a valid name to proceed.",
                        "Input Required - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            } while (string.IsNullOrWhiteSpace(inputName)); // Keep prompting until a valid name is entered

            cashierName = inputName; // Store the valid name

            uc_p_dashboard1.Visible = false;
            uc_p_addMedicine1.Visible = false;
            uc_p_updateMedicine1.Visible = false;
            uc_p_medicineValidityCheck1.Visible = false;
            uc_p_sellMedicine1.Visible = false;
            btnDashboard_p.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnViewuser_Click(object sender, EventArgs e)
        {
            uc_p_viewMedicine1.Visible = true;
            uc_p_viewMedicine1.BringToFront();
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            uc_p_updateMedicine1.Visible = true;
            uc_p_updateMedicine1.BringToFront();
        }

        private void btn_sellMedicine_Click(object sender, EventArgs e)
        {
            uc_p_sellMedicine1.SetCashierName(cashierName);
            uc_p_sellMedicine1.Visible = true;
            uc_p_sellMedicine1.BringToFront();
        }

        private void btn_validityCheck_Click(object sender, EventArgs e)
        {
            uc_p_medicineValidityCheck1.Visible = true;
            uc_p_medicineValidityCheck1.BringToFront();
        }

        private void uc_p_sellMedicine1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void userNameLabel2_Click(object sender, EventArgs e)
        {
        }

        private void uc_p_medicineValidityCheck1_Load(object sender, EventArgs e)
        {
        }

        private void uc_p_updateMedicine1_Load(object sender, EventArgs e)
        {
        }

        private void uc_p_viewMedicine1_Load(object sender, EventArgs e)
        {
        }

        private void uc_p_addMedicine1_Load(object sender, EventArgs e)
        {
        }

        private void uc_p_sellMedicine1_Load_1(object sender, EventArgs e)
        {
        }
    }
}