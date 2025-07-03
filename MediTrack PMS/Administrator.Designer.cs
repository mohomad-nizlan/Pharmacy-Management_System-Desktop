namespace MediTrack_PMS
{
    partial class Administrator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnProfile = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewuser = new Guna.UI.WinForms.GunaButton();
            this.btnAdduser = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_profile1 = new MediTrack_PMS.AdministratorUC.uc_profile();
            this.uc_viewUser1 = new MediTrack_PMS.AdministratorUC.uc_viewUser();
            this.uC_Adduser1 = new MediTrack_PMS.AdministratorUC.UC_Adduser();
            this.uc_dashboard1 = new MediTrack_PMS.AdministratorUC.uc_dashboard();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnViewuser);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userNameLabel.Location = new System.Drawing.Point(90, 702);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(94, 36);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "nizlan";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AnimationHoverSpeed = 0.07F;
            this.btnProfile.AnimationSpeed = 0.03F;
            this.btnProfile.BaseColor = System.Drawing.Color.Black;
            this.btnProfile.BorderColor = System.Drawing.Color.White;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(40, 40);
            this.btnProfile.Location = new System.Drawing.Point(25, 533);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.OnHoverImage")));
            this.btnProfile.OnPressedColor = System.Drawing.Color.Black;
            this.btnProfile.Size = new System.Drawing.Size(225, 58);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Black;
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(25, 609);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnHoverImage")));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(225, 58);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewuser
            // 
            this.btnViewuser.AnimationHoverSpeed = 0.07F;
            this.btnViewuser.AnimationSpeed = 0.03F;
            this.btnViewuser.BaseColor = System.Drawing.Color.Black;
            this.btnViewuser.BorderColor = System.Drawing.Color.White;
            this.btnViewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewuser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewuser.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewuser.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewuser.ForeColor = System.Drawing.Color.White;
            this.btnViewuser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewuser.Image")));
            this.btnViewuser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViewuser.Location = new System.Drawing.Point(25, 457);
            this.btnViewuser.Name = "btnViewuser";
            this.btnViewuser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnViewuser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewuser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewuser.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnViewuser.OnHoverImage")));
            this.btnViewuser.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewuser.Size = new System.Drawing.Size(225, 58);
            this.btnViewuser.TabIndex = 1;
            this.btnViewuser.Text = "   View User";
            this.btnViewuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewuser.Click += new System.EventHandler(this.btnViewuser_Click_1);
            // 
            // btnAdduser
            // 
            this.btnAdduser.AnimationHoverSpeed = 0.07F;
            this.btnAdduser.AnimationSpeed = 0.03F;
            this.btnAdduser.BaseColor = System.Drawing.Color.Black;
            this.btnAdduser.BorderColor = System.Drawing.Color.White;
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdduser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdduser.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAdduser.Location = new System.Drawing.Point(25, 379);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnAdduser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdduser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdduser.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAdduser.OnHoverImage")));
            this.btnAdduser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdduser.Size = new System.Drawing.Size(225, 58);
            this.btnAdduser.TabIndex = 1;
            this.btnAdduser.Text = "  Add User";
            this.btnAdduser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.Black;
            this.btnDashboard.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(25, 303);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.OnHoverImage")));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(225, 58);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_profile1);
            this.panel2.Controls.Add(this.uc_viewUser1);
            this.panel2.Controls.Add(this.uC_Adduser1);
            this.panel2.Controls.Add(this.uc_dashboard1);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 768);
            this.panel2.TabIndex = 1;
            // 
            // uc_profile1
            // 
            this.uc_profile1.BackColor = System.Drawing.Color.White;
            this.uc_profile1.Location = new System.Drawing.Point(0, 0);
            this.uc_profile1.Name = "uc_profile1";
            this.uc_profile1.Size = new System.Drawing.Size(1105, 768);
            this.uc_profile1.TabIndex = 3;
            this.uc_profile1.Load += new System.EventHandler(this.uc_profile1_Load);
            // 
            // uc_viewUser1
            // 
            this.uc_viewUser1.BackColor = System.Drawing.Color.White;
            this.uc_viewUser1.Location = new System.Drawing.Point(0, 0);
            this.uc_viewUser1.Name = "uc_viewUser1";
            this.uc_viewUser1.Size = new System.Drawing.Size(1105, 768);
            this.uc_viewUser1.TabIndex = 2;
            // 
            // uC_Adduser1
            // 
            this.uC_Adduser1.BackColor = System.Drawing.Color.White;
            this.uC_Adduser1.Location = new System.Drawing.Point(0, 0);
            this.uC_Adduser1.Name = "uC_Adduser1";
            this.uC_Adduser1.Size = new System.Drawing.Size(1140, 768);
            this.uC_Adduser1.TabIndex = 1;
            this.uC_Adduser1.Load += new System.EventHandler(this.uC_Adduser1_Load);
            // 
            // uc_dashboard1
            // 
            this.uc_dashboard1.BackColor = System.Drawing.Color.White;
            this.uc_dashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_dashboard1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uc_dashboard1.Name = "uc_dashboard1";
            this.uc_dashboard1.Size = new System.Drawing.Size(1105, 768);
            this.uc_dashboard1.TabIndex = 0;
            this.uc_dashboard1.Load += new System.EventHandler(this.uc_dashboard1_Load);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnAdduser;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaButton btnProfile;
        private Guna.UI.WinForms.GunaButton btnViewuser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private AdministratorUC.uc_dashboard uc_dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private AdministratorUC.UC_Adduser uC_Adduser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private AdministratorUC.uc_viewUser uc_viewUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private AdministratorUC.uc_profile uc_profile1;
    }
}