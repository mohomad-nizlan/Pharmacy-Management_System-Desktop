namespace MediTrack_PMS
{
    partial class pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacist));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_validityCheck = new Guna.UI.WinForms.GunaButton();
            this.btn_sellMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateMedicine = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnAddMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard_p = new Guna.UI.WinForms.GunaButton();
            this.userNameLabel2 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uc_p_sellMedicine1 = new MediTrack_PMS.pharmacistUC.uc_p_sellMedicine();
            this.uc_p_medicineValidityCheck1 = new MediTrack_PMS.pharmacistUC.uc_p_medicineValidityCheck();
            this.uc_p_updateMedicine1 = new MediTrack_PMS.pharmacistUC.uc_p_updateMedicine();
            this.uc_p_viewMedicine1 = new MediTrack_PMS.pharmacistUC.uc_p_viewMedicine();
            this.uc_p_addMedicine1 = new MediTrack_PMS.pharmacistUC.uc_p_addMedicine();
            this.uc_p_dashboard1 = new MediTrack_PMS.pharmacistUC.uc_p_dashboard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.btn_validityCheck);
            this.panel2.Controls.Add(this.btn_sellMedicine);
            this.panel2.Controls.Add(this.btnUpdateMedicine);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnViewMedicine);
            this.panel2.Controls.Add(this.btnAddMedicine);
            this.panel2.Controls.Add(this.btnDashboard_p);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 768);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_validityCheck
            // 
            this.btn_validityCheck.AnimationHoverSpeed = 0.07F;
            this.btn_validityCheck.AnimationSpeed = 0.03F;
            this.btn_validityCheck.BaseColor = System.Drawing.Color.Black;
            this.btn_validityCheck.BorderColor = System.Drawing.Color.Black;
            this.btn_validityCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_validityCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_validityCheck.FocusedColor = System.Drawing.Color.Empty;
            this.btn_validityCheck.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validityCheck.ForeColor = System.Drawing.Color.White;
            this.btn_validityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btn_validityCheck.Image")));
            this.btn_validityCheck.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_validityCheck.Location = new System.Drawing.Point(12, 515);
            this.btn_validityCheck.Name = "btn_validityCheck";
            this.btn_validityCheck.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_validityCheck.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_validityCheck.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_validityCheck.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_validityCheck.OnHoverImage")));
            this.btn_validityCheck.OnPressedColor = System.Drawing.Color.Black;
            this.btn_validityCheck.Size = new System.Drawing.Size(247, 48);
            this.btn_validityCheck.TabIndex = 7;
            this.btn_validityCheck.Text = "     Validity Check";
            this.btn_validityCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_validityCheck.Click += new System.EventHandler(this.btn_validityCheck_Click);
            // 
            // btn_sellMedicine
            // 
            this.btn_sellMedicine.AnimationHoverSpeed = 0.07F;
            this.btn_sellMedicine.AnimationSpeed = 0.03F;
            this.btn_sellMedicine.BaseColor = System.Drawing.Color.Black;
            this.btn_sellMedicine.BorderColor = System.Drawing.Color.Black;
            this.btn_sellMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sellMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sellMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sellMedicine.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_sellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btn_sellMedicine.Image")));
            this.btn_sellMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_sellMedicine.Location = new System.Drawing.Point(12, 573);
            this.btn_sellMedicine.Name = "btn_sellMedicine";
            this.btn_sellMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_sellMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sellMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_sellMedicine.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_sellMedicine.OnHoverImage")));
            this.btn_sellMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sellMedicine.Size = new System.Drawing.Size(247, 48);
            this.btn_sellMedicine.TabIndex = 6;
            this.btn_sellMedicine.Text = "      Sell Medicine";
            this.btn_sellMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sellMedicine.Click += new System.EventHandler(this.btn_sellMedicine_Click);
            // 
            // btnUpdateMedicine
            // 
            this.btnUpdateMedicine.AnimationHoverSpeed = 0.07F;
            this.btnUpdateMedicine.AnimationSpeed = 0.03F;
            this.btnUpdateMedicine.BaseColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateMedicine.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMedicine.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMedicine.Image")));
            this.btnUpdateMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUpdateMedicine.Location = new System.Drawing.Point(12, 457);
            this.btnUpdateMedicine.Name = "btnUpdateMedicine";
            this.btnUpdateMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnUpdateMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateMedicine.OnHoverImage")));
            this.btnUpdateMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateMedicine.Size = new System.Drawing.Size(247, 48);
            this.btnUpdateMedicine.TabIndex = 2;
            this.btnUpdateMedicine.Text = "        Update Medicine";
            this.btnUpdateMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateMedicine.Click += new System.EventHandler(this.btnUpdateMedicine_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pharmacist";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Black;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(44, 678);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnHoverImage")));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(187, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "     Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.AnimationHoverSpeed = 0.07F;
            this.btnViewMedicine.AnimationSpeed = 0.03F;
            this.btnViewMedicine.BaseColor = System.Drawing.Color.Black;
            this.btnViewMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewMedicine.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewMedicine.Location = new System.Drawing.Point(12, 399);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnViewMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.OnHoverImage")));
            this.btnViewMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Size = new System.Drawing.Size(247, 48);
            this.btnViewMedicine.TabIndex = 1;
            this.btnViewMedicine.Text = "        View Medicine";
            this.btnViewMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewuser_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.AnimationHoverSpeed = 0.07F;
            this.btnAddMedicine.AnimationSpeed = 0.03F;
            this.btnAddMedicine.BaseColor = System.Drawing.Color.Black;
            this.btnAddMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMedicine.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 341);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnAddMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.OnHoverImage")));
            this.btnAddMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Size = new System.Drawing.Size(247, 48);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "     Add Medicine";
            this.btnAddMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashboard_p
            // 
            this.btnDashboard_p.AnimationHoverSpeed = 0.07F;
            this.btnDashboard_p.AnimationSpeed = 0.03F;
            this.btnDashboard_p.BaseColor = System.Drawing.Color.Black;
            this.btnDashboard_p.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard_p.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard_p.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard_p.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_p.ForeColor = System.Drawing.Color.White;
            this.btnDashboard_p.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard_p.Image")));
            this.btnDashboard_p.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboard_p.Location = new System.Drawing.Point(12, 283);
            this.btnDashboard_p.Name = "btnDashboard_p";
            this.btnDashboard_p.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnDashboard_p.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard_p.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashboard_p.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard_p.OnHoverImage")));
            this.btnDashboard_p.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard_p.Size = new System.Drawing.Size(247, 48);
            this.btnDashboard_p.TabIndex = 0;
            this.btnDashboard_p.Text = "Dashboard";
            this.btnDashboard_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard_p.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // userNameLabel2
            // 
            this.userNameLabel2.AutoSize = true;
            this.userNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userNameLabel2.Location = new System.Drawing.Point(275, 0);
            this.userNameLabel2.Name = "userNameLabel2";
            this.userNameLabel2.Size = new System.Drawing.Size(94, 36);
            this.userNameLabel2.TabIndex = 0;
            this.userNameLabel2.Text = "nizlan";
            this.userNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // gunaElipse5
            // 
            this.gunaElipse5.TargetControl = this.panel2;
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.TargetControl = this;
            // 
            // gunaElipse7
            // 
            this.gunaElipse7.TargetControl = this;
            // 
            // uc_p_sellMedicine1
            // 
            this.uc_p_sellMedicine1.BackColor = System.Drawing.Color.White;
            this.uc_p_sellMedicine1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uc_p_sellMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uc_p_sellMedicine1.Margin = new System.Windows.Forms.Padding(2);
            this.uc_p_sellMedicine1.Name = "uc_p_sellMedicine1";
            this.uc_p_sellMedicine1.Size = new System.Drawing.Size(1105, 768);
            this.uc_p_sellMedicine1.TabIndex = 7;
            this.uc_p_sellMedicine1.Load += new System.EventHandler(this.uc_p_sellMedicine1_Load_1);
            // 
            // uc_p_medicineValidityCheck1
            // 
            this.uc_p_medicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uc_p_medicineValidityCheck1.Location = new System.Drawing.Point(275, 0);
            this.uc_p_medicineValidityCheck1.Name = "uc_p_medicineValidityCheck1";
            this.uc_p_medicineValidityCheck1.Size = new System.Drawing.Size(1105, 768);
            this.uc_p_medicineValidityCheck1.TabIndex = 6;
            // 
            // uc_p_updateMedicine1
            // 
            this.uc_p_updateMedicine1.BackColor = System.Drawing.Color.White;
            this.uc_p_updateMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uc_p_updateMedicine1.Name = "uc_p_updateMedicine1";
            this.uc_p_updateMedicine1.Size = new System.Drawing.Size(1105, 768);
            this.uc_p_updateMedicine1.TabIndex = 5;
            // 
            // uc_p_viewMedicine1
            // 
            this.uc_p_viewMedicine1.BackColor = System.Drawing.Color.White;
            this.uc_p_viewMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uc_p_viewMedicine1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_p_viewMedicine1.Name = "uc_p_viewMedicine1";
            this.uc_p_viewMedicine1.Size = new System.Drawing.Size(1105, 768);
            this.uc_p_viewMedicine1.TabIndex = 4;
            // 
            // uc_p_addMedicine1
            // 
            this.uc_p_addMedicine1.BackColor = System.Drawing.Color.White;
            this.uc_p_addMedicine1.Location = new System.Drawing.Point(275, 0);
            this.uc_p_addMedicine1.Name = "uc_p_addMedicine1";
            this.uc_p_addMedicine1.Size = new System.Drawing.Size(1105, 768);
            this.uc_p_addMedicine1.TabIndex = 3;
            // 
            // uc_p_dashboard1
            // 
            this.uc_p_dashboard1.BackColor = System.Drawing.Color.White;
            this.uc_p_dashboard1.Location = new System.Drawing.Point(274, 0);
            this.uc_p_dashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_p_dashboard1.Name = "uc_p_dashboard1";
            this.uc_p_dashboard1.Size = new System.Drawing.Size(1118, 768);
            this.uc_p_dashboard1.TabIndex = 2;
            this.uc_p_dashboard1.Load += new System.EventHandler(this.uc_p_dashboard1_Load);
            // 
            // pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.uc_p_sellMedicine1);
            this.Controls.Add(this.uc_p_medicineValidityCheck1);
            this.Controls.Add(this.userNameLabel2);
            this.Controls.Add(this.uc_p_updateMedicine1);
            this.Controls.Add(this.uc_p_viewMedicine1);
            this.Controls.Add(this.uc_p_addMedicine1);
            this.Controls.Add(this.uc_p_dashboard1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pharmacist";
            this.Load += new System.EventHandler(this.pharmacist_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLabel2;
        private Guna.UI.WinForms.GunaButton btnUpdateMedicine;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton btnViewMedicine;
        private Guna.UI.WinForms.GunaButton btnAddMedicine;
        private Guna.UI.WinForms.GunaButton btnDashboard_p;
        private Guna.UI.WinForms.GunaButton btn_sellMedicine;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private pharmacistUC.uc_p_dashboard uc_p_dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private pharmacistUC.uc_p_addMedicine uc_p_addMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private pharmacistUC.uc_p_viewMedicine uc_p_viewMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private pharmacistUC.uc_p_updateMedicine uc_p_updateMedicine1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private pharmacistUC.uc_p_medicineValidityCheck uc_p_medicineValidityCheck1;
        private Guna.UI.WinForms.GunaButton btn_validityCheck;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private pharmacistUC.uc_p_sellMedicine uc_p_sellMedicine1;
    }
}