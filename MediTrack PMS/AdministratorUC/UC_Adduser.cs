using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // For File.ReadAllBytes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrack_PMS.AdministratorUC
{
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        String query;
        private Timer debounceTimer; // For debouncing username check
        private byte[] profilePicBytes; // To store the profile picture as bytes

        public UC_Adduser()
        {
            InitializeComponent();

            // Initialize debounce timer for username check
            debounceTimer = new Timer
            {
                Interval = 300 // 300ms delay
            };
            debounceTimer.Tick += (s, e) =>
            {
                debounceTimer.Stop();
                CheckUsernameAvailability();
            };

            // Populate txtUserrole dropdown with allowed roles
            txtUserrole.Items.Clear();
            txtUserrole.Items.Add("Administrator");
            txtUserrole.Items.Add("Pharmacist");
            txtUserrole.Items.Add("Technician");
            txtUserrole.Items.Add("Customer");
        }

        private void UC_Adduser_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox2.Image = Image.FromFile(ofd.FileName); // Display in pictureBox2
                        profilePicBytes = File.ReadAllBytes(ofd.FileName); // Convert image to bytes
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error uploading image: " + ex.Message,
                            "Image Upload Error - MediTrack Pharmacy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        pictureBox2.Image = null; // Clear pictureBox2 on error
                        profilePicBytes = null;
                    }
                }
            }
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtUserrole.Text) ||
                string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtPhonenumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailaddress.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please fill all fields.",
                    "Input Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Role
            string role = txtUserrole.Text;
            if (role != "Administrator" && role != "Pharmacist" && role != "Technician" && role != "Customer")
            {
                MessageBox.Show(
                    "Please select a valid role (Administrator, Pharmacist, Technician, or Customer).",
                    "Invalid Role - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Warn if adding a role that can't log in
            if (role == "Technician" || role == "Customer")
            {
                DialogResult result = MessageBox.Show(
                    $"{role} users cannot log in to the system. Do you still want to add this user?",
                    "Role Access Warning - MediTrack Pharmacy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            // Validate Date of Birth
            if (!DateTime.TryParse(txtDOB.Text, out DateTime dob))
            {
                MessageBox.Show(
                    "Please enter a valid date of birth (e.g., yyyy-MM-dd).",
                    "Invalid Date - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate DOB is not in the future
            if (dob > DateTime.Today)
            {
                MessageBox.Show(
                    "Date of birth cannot be in the future.",
                    "Invalid Date - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Phone Number
            if (!Int64.TryParse(txtPhonenumber.Text, out Int64 number))
            {
                MessageBox.Show(
                    "Please enter a valid phone number (numeric only).",
                    "Invalid Phone Number - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txtPhonenumber.Text.Length != 10)
            {
                MessageBox.Show(
                    "Phone number must be exactly 10 digits.",
                    "Invalid Phone Number - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Password (basic check for minimum length)
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Weak Password - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Email (basic format check)
            if (!txtEmailaddress.Text.Contains("@") || !txtEmailaddress.Text.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address (e.g., user@example.com).",
                    "Invalid Email - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Use parameterized query to insert the user, including the profile picture
                query = @"
                    INSERT INTO users (userRole, name, dob, mobile, email, username, pass, profilePic)
                    VALUES (@userRole, @name, @dob, @mobile, @email, @username, @pass, @profilePic)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@userRole", role },
                    { "@name", txtFullname.Text },
                    { "@dob", dob.ToString("yyyy-MM-dd") },
                    { "@mobile", number },
                    { "@email", txtEmailaddress.Text },
                    { "@username", txtUsername.Text },
                    { "@pass", txtPassword.Text },
                    { "@profilePic", profilePicBytes ?? (object)DBNull.Value } // Handle null if no image
                };

                // Execute the query
                fn.setData(query, parameters, "User Registered Successfully - MediTrack Pharmacy");

                // Clear fields after successful submission
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding user: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtFullname.Clear();
            txtDOB.Value = DateTime.Today; // Reset txtDOB to today's date
            txtPhonenumber.Clear();
            txtEmailaddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserrole.SelectedIndex = -1;
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
            pictureBox1.Refresh();
            pictureBox2.Image = null; // Clear pictureBox2
            pictureBox2.Refresh(); // Refresh pictureBox2
            profilePicBytes = null; // Reset the profile picture bytes
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Start or restart the debounce timer
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void CheckUsernameAvailability()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    pictureBox1.Image = null;
                    pictureBox1.ImageLocation = null;
                    pictureBox1.Refresh();
                    return;
                }

                query = "SELECT * FROM users WHERE username = @username";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@username", txtUsername.Text }
                };
                DataSet ds = fn.getData(query, parameters);

                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        // Username is available - use hardcoded path
                        pictureBox1.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\yes.png";
                    }
                    else
                    {
                        // Username is taken
                        pictureBox1.ImageLocation = @"D:\winforms assets\Pharmacy Management System in C#\no.png";
                    }
                    pictureBox1.Refresh();
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.ImageLocation = null;
                    pictureBox1.Refresh();
                    MessageBox.Show(
                        "Error checking username availability: Invalid data returned.",
                        "Database Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
                pictureBox1.ImageLocation = null;
                pictureBox1.Refresh();
                MessageBox.Show(
                    "Error checking username availability: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}