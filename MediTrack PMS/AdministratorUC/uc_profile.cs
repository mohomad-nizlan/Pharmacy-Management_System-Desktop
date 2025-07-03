using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO; // For handling image streams
using System.Drawing.Imaging; // For ImageFormat

namespace MediTrack_PMS.AdministratorUC
{
    public partial class uc_profile : UserControl
    {
        function fn = new function();
        String query;

        public uc_profile()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Set SizeMode to stretch the image
        }

        public string ID
        {
            set { userNamev.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void LoadProfile()
        {
            if (string.IsNullOrWhiteSpace(userNamev.Text))
            {
                MessageBox.Show(
                    "Username is not set. Please log in again.",
                    "Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                query = "SELECT * FROM users WHERE username = @username";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@username", userNamev.Text }
                };
                DataSet ds = fn.getData(query, parameters);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtUserrolev.Text = ds.Tables[0].Rows[0][1].ToString(); // userRole
                    txtFullnamev.Text = ds.Tables[0].Rows[0][2].ToString(); // name
                    txtDOBv.Text = ds.Tables[0].Rows[0][3].ToString(); // dob
                    txtPhonenumberv.Text = ds.Tables[0].Rows[0][4].ToString(); // mobile
                    txtEmailv.Text = ds.Tables[0].Rows[0][5].ToString(); // email
                    txtPasswordv.Text = ds.Tables[0].Rows[0][7].ToString(); // pass

                    // Load profile picture
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
                    MessageBox.Show(
                        "User not found. Please log in again.",
                        "Error - MediTrack Pharmacy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading profile: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void uc_profile_Enter(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void uc_profile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnResetv_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnUpdatev_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(txtUserrolev.Text) ||
                string.IsNullOrWhiteSpace(txtFullnamev.Text) ||
                string.IsNullOrWhiteSpace(txtDOBv.Text) ||
                string.IsNullOrWhiteSpace(txtPhonenumberv.Text) ||
                string.IsNullOrWhiteSpace(txtEmailv.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordv.Text))
            {
                MessageBox.Show(
                    "Please fill all fields.",
                    "Input Required - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Date of Birth
            if (!DateTime.TryParse(txtDOBv.Text, out DateTime dob))
            {
                MessageBox.Show(
                    "Please enter a valid date of birth (e.g., yyyy-MM-dd).",
                    "Invalid Date - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Phone Number
            if (!Int64.TryParse(txtPhonenumberv.Text, out Int64 number))
            {
                MessageBox.Show(
                    "Please enter a valid phone number (numeric only).",
                    "Invalid Phone Number - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txtPhonenumberv.Text.Length != 10)
            {
                MessageBox.Show(
                    "Phone number must be exactly 10 digits.",
                    "Invalid Phone Number - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Email
            if (!txtEmailv.Text.Contains("@") || !txtEmailv.Text.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address (e.g., user@example.com).",
                    "Invalid Email - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Password
            if (txtPasswordv.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Weak Password - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Role
            string role = txtUserrolev.Text;
            if (role != "Administrator" && role != "Pharmacist" && role != "Technician" && role != "Customer")
            {
                MessageBox.Show(
                    "Please enter a valid role (Administrator, Pharmacist, Technician, or Customer).",
                    "Invalid Role - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Warn if changing to a role that can't log in
            if (role == "Technician" || role == "Customer")
            {
                DialogResult result = MessageBox.Show(
                    $"{role} users cannot log in to the system. Do you still want to update your role?",
                    "Role Access Warning - MediTrack Pharmacy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            try
            {
                // Convert the image to a byte array if an image is present
                byte[] imageData = null;
                if (pictureBox1.Image != null)
                {
                    try
                    {
                        // Create a deep copy of the image to avoid GDI+ issues
                        using (Bitmap tempImage = new Bitmap(pictureBox1.Image))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                tempImage.Save(ms, ImageFormat.Jpeg);
                                imageData = ms.ToArray();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error converting image to byte array: " + ex.Message,
                            "Image Error - MediTrack Pharmacy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }

                query = @"
                    UPDATE users 
                    SET userRole = @userRole, name = @name, dob = @dob, 
                        mobile = @mobile, email = @email, pass = @pass, 
                        profilePic = @profilePic 
                    WHERE username = @username";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@userRole", role },
                    { "@name", txtFullnamev.Text },
                    { "@dob", dob.ToString("yyyy-MM-dd") },
                    { "@mobile", number },
                    { "@email", txtEmailv.Text },
                    { "@pass", txtPasswordv.Text },
                    { "@profilePic", (object)imageData ?? DBNull.Value }, // Handle NULL if no image
                    { "@username", userNamev.Text }
                };

                fn.setData(query, parameters, "Profile Updated Successfully - MediTrack Pharmacy");
                LoadProfile(); // Refresh the profile
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating profile: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            try
            {
                if (image.Width <= maxWidth && image.Height <= maxHeight)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Jpeg);
                        return Image.FromStream(ms);
                    }
                }

                double ratio = Math.Min((double)maxWidth / image.Width, (double)maxHeight / image.Height);
                int newWidth = (int)(image.Width * ratio);
                int newHeight = (int)(image.Height * ratio);

                using (Bitmap resizedImage = new Bitmap(newWidth, newHeight))
                {
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.DrawImage(image, 0, 0, newWidth, newHeight);
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        resizedImage.Save(ms, ImageFormat.Jpeg);
                        return Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error resizing image: " + ex.Message);
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFile = openFileDialog.FileName;
                        using (Image originalImage = Image.FromFile(selectedFile))
                        {
                            Image resizedImage = ResizeImage(originalImage, 200, 200);
                            // Create a deep copy to avoid GDI+ issues
                            pictureBox1.Image = new Bitmap(resizedImage);
                            resizedImage.Dispose();
                        }

                        MessageBox.Show(
                            "Image loaded successfully.",
                            "Info - MediTrack Pharmacy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error loading image: " + ex.Message,
                            "Error - MediTrack Pharmacy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            MessageBox.Show(
                "Profile picture removed. Click Update to save changes.",
                "Info - MediTrack Pharmacy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void txtDOBv_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPhonenumberv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}