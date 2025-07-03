using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrack_PMS
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void licensing1_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show(
                    "Please enter a username.",
                    "Input Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show(
                    "Please enter a password.",
                    "Input Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textPassword.Focus();
                return;
            }

            // Authenticate user using parameterized query, only allowing Administrator and Pharmacist roles
            query = "SELECT userRole FROM users WHERE username = @username AND pass = @password AND userRole IN (@adminRole, @pharmacistRole)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", textUsername.Text },
                { "@password", textPassword.Text },
                { "@adminRole", "Administrator" },
                { "@pharmacistRole", "Pharmacist" }
            };
            DataSet ds = fn.getData(query, parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string role = ds.Tables[0].Rows[0][0].ToString();
                switch (role)
                {
                    case "Administrator":
                        Administrator admin = new Administrator(textUsername.Text);
                        admin.Show();
                        this.Hide();
                        break;

                    case "Pharmacist":
                        pharmacist pharm = new pharmacist();
                        pharm.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show(
                            $"Unexpected role '{role}'. Please contact the administrator.",
                            "Authentication Error - MediTrack Pharmacy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        break;
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password, or your role does not have access. Only Administrators and Pharmacists can log in.",
                    "Login Failed - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}