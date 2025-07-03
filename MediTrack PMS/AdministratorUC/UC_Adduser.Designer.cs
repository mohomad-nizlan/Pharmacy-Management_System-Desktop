namespace MediTrack_PMS.AdministratorUC
{
    partial class UC_Adduser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Adduser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserrole = new Guna.UI.WinForms.GunaComboBox();
            this.txtFullname = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhonenumber = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmailaddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnReset2 = new Guna.UI.WinForms.GunaButton();
            this.btnSubmit2 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadPic = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(534, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 523);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label17.Location = new System.Drawing.Point(17, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 44);
            this.label17.TabIndex = 9;
            this.label17.Text = "Add User";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserrole
            // 
            this.txtUserrole.BackColor = System.Drawing.Color.Transparent;
            this.txtUserrole.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserrole.BorderColor = System.Drawing.Color.Black;
            this.txtUserrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtUserrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUserrole.FocusedColor = System.Drawing.Color.Black;
            this.txtUserrole.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserrole.ForeColor = System.Drawing.Color.Black;
            this.txtUserrole.FormattingEnabled = true;
            this.txtUserrole.ItemHeight = 31;
            this.txtUserrole.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.txtUserrole.Location = new System.Drawing.Point(136, 195);
            this.txtUserrole.Name = "txtUserrole";
            this.txtUserrole.OnHoverItemBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUserrole.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.txtUserrole.Size = new System.Drawing.Size(340, 37);
            this.txtUserrole.TabIndex = 11;
            this.txtUserrole.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // txtFullname
            // 
            this.txtFullname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullname.BorderColor = System.Drawing.Color.Black;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFullname.FocusedBorderColor = System.Drawing.Color.MediumBlue;
            this.txtFullname.FocusedForeColor = System.Drawing.Color.Black;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.Black;
            this.txtFullname.Location = new System.Drawing.Point(136, 311);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.SelectedText = "";
            this.txtFullname.Size = new System.Drawing.Size(340, 37);
            this.txtFullname.TabIndex = 12;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhonenumber.BorderColor = System.Drawing.Color.Black;
            this.txtPhonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhonenumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhonenumber.FocusedBorderColor = System.Drawing.Color.MediumBlue;
            this.txtPhonenumber.FocusedForeColor = System.Drawing.Color.Black;
            this.txtPhonenumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhonenumber.Location = new System.Drawing.Point(136, 536);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.PasswordChar = '\0';
            this.txtPhonenumber.SelectedText = "";
            this.txtPhonenumber.Size = new System.Drawing.Size(340, 37);
            this.txtPhonenumber.TabIndex = 14;
            // 
            // txtEmailaddress
            // 
            this.txtEmailaddress.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmailaddress.BorderColor = System.Drawing.Color.Black;
            this.txtEmailaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmailaddress.FocusedBorderColor = System.Drawing.Color.MediumBlue;
            this.txtEmailaddress.FocusedForeColor = System.Drawing.Color.Black;
            this.txtEmailaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailaddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailaddress.Location = new System.Drawing.Point(597, 195);
            this.txtEmailaddress.Name = "txtEmailaddress";
            this.txtEmailaddress.PasswordChar = '\0';
            this.txtEmailaddress.SelectedText = "";
            this.txtEmailaddress.Size = new System.Drawing.Size(340, 37);
            this.txtEmailaddress.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.MediumBlue;
            this.txtPassword.FocusedForeColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(597, 427);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(340, 37);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.MediumBlue;
            this.txtUsername.FocusedForeColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(597, 311);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 2;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(340, 37);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.BaseColor = System.Drawing.Color.LightCyan;
            this.txtDOB.BorderColor = System.Drawing.Color.Black;
            this.txtDOB.CustomFormat = null;
            this.txtDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDOB.FocusedColor = System.Drawing.Color.Black;
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Location = new System.Drawing.Point(136, 427);
            this.txtDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDOB.OnHoverBorderColor = System.Drawing.Color.MediumBlue;
            this.txtDOB.OnHoverForeColor = System.Drawing.Color.Black;
            this.txtDOB.OnPressedColor = System.Drawing.Color.Black;
            this.txtDOB.Size = new System.Drawing.Size(340, 37);
            this.txtDOB.TabIndex = 19;
            this.txtDOB.Text = "Wednesday, April 16, 2025";
            this.txtDOB.Value = new System.DateTime(2025, 4, 16, 20, 16, 58, 108);
            // 
            // btnReset2
            // 
            this.btnReset2.AnimationHoverSpeed = 0.07F;
            this.btnReset2.AnimationSpeed = 0.03F;
            this.btnReset2.BackColor = System.Drawing.Color.Transparent;
            this.btnReset2.BaseColor = System.Drawing.Color.Red;
            this.btnReset2.BorderColor = System.Drawing.Color.Black;
            this.btnReset2.BorderSize = 2;
            this.btnReset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset2.FocusedColor = System.Drawing.Color.Black;
            this.btnReset2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.ForeColor = System.Drawing.Color.Black;
            this.btnReset2.Image = ((System.Drawing.Image)(resources.GetObject("btnReset2.Image")));
            this.btnReset2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset2.Location = new System.Drawing.Point(796, 629);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btnReset2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset2.OnHoverImage = null;
            this.btnReset2.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset2.Radius = 19;
            this.btnReset2.Size = new System.Drawing.Size(112, 40);
            this.btnReset2.TabIndex = 21;
            this.btnReset2.Text = "Reset";
            this.btnReset2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.AnimationHoverSpeed = 0.07F;
            this.btnSubmit2.AnimationSpeed = 0.03F;
            this.btnSubmit2.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit2.BaseColor = System.Drawing.Color.Chartreuse;
            this.btnSubmit2.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit2.BorderSize = 2;
            this.btnSubmit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit2.FocusedColor = System.Drawing.Color.Black;
            this.btnSubmit2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit2.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit2.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit2.Image")));
            this.btnSubmit2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSubmit2.Location = new System.Drawing.Point(626, 629);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnSubmit2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit2.OnHoverImage = null;
            this.btnSubmit2.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit2.Radius = 19;
            this.btnSubmit2.Size = new System.Drawing.Size(112, 40);
            this.btnSubmit2.TabIndex = 20;
            this.btnSubmit2.Text = "Add";
            this.btnSubmit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(943, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(623, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "*Check User Role Once before Sign Up";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.AnimationHoverSpeed = 0.07F;
            this.btnUploadPic.AnimationSpeed = 0.03F;
            this.btnUploadPic.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadPic.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnUploadPic.BorderColor = System.Drawing.Color.Black;
            this.btnUploadPic.BorderSize = 2;
            this.btnUploadPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUploadPic.FocusedColor = System.Drawing.Color.Black;
            this.btnUploadPic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPic.ForeColor = System.Drawing.Color.Black;
            this.btnUploadPic.Image = null;
            this.btnUploadPic.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUploadPic.Location = new System.Drawing.Point(597, 521);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.OnHoverBaseColor = System.Drawing.Color.MidnightBlue;
            this.btnUploadPic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUploadPic.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUploadPic.OnHoverImage = null;
            this.btnUploadPic.OnPressedColor = System.Drawing.Color.Black;
            this.btnUploadPic.Size = new System.Drawing.Size(282, 50);
            this.btnUploadPic.TabIndex = 24;
            this.btnUploadPic.Text = "Select Profile Picture";
            this.btnUploadPic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(885, 521);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UC_Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmailaddress);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtUserrole);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Adduser";
            this.Size = new System.Drawing.Size(1105, 768);
            this.Load += new System.EventHandler(this.UC_Adduser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaComboBox txtUserrole;
        private Guna.UI.WinForms.GunaTextBox txtFullname;
        private Guna.UI.WinForms.GunaTextBox txtPhonenumber;
        private Guna.UI.WinForms.GunaTextBox txtEmailaddress;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaDateTimePicker txtDOB;
        private Guna.UI.WinForms.GunaButton btnReset2;
        private Guna.UI.WinForms.GunaButton btnSubmit2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnUploadPic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
