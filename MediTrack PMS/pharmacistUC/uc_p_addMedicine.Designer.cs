namespace MediTrack_PMS.pharmacistUC
{
    partial class uc_p_addMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_p_addMedicine));
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.txt_man_date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_med_num = new Guna.UI.WinForms.GunaTextBox();
            this.txt_med_price = new Guna.UI.WinForms.GunaTextBox();
            this.txt_med_id = new Guna.UI.WinForms.GunaTextBox();
            this.txt_med_name = new Guna.UI.WinForms.GunaTextBox();
            this.label17_p = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_med_quality = new Guna.UI.WinForms.GunaTextBox();
            this.txt_exp_date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.Red;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.BorderSize = 2;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(828, 596);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 19;
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(658, 596);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 19;
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_man_date
            // 
            this.txt_man_date.BaseColor = System.Drawing.Color.LightCyan;
            this.txt_man_date.BorderColor = System.Drawing.Color.Black;
            this.txt_man_date.CustomFormat = null;
            this.txt_man_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_man_date.FocusedColor = System.Drawing.Color.White;
            this.txt_man_date.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_man_date.ForeColor = System.Drawing.Color.Black;
            this.txt_man_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_man_date.Location = new System.Drawing.Point(170, 593);
            this.txt_man_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_man_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_man_date.Name = "txt_man_date";
            this.txt_man_date.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_man_date.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_man_date.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_man_date.OnPressedColor = System.Drawing.Color.Black;
            this.txt_man_date.Size = new System.Drawing.Size(340, 36);
            this.txt_man_date.TabIndex = 39;
            this.txt_man_date.Text = "4/16/2025";
            this.txt_man_date.Value = new System.DateTime(2025, 4, 16, 20, 16, 58, 108);
            this.txt_man_date.ValueChanged += new System.EventHandler(this.txtDOB_ValueChanged);
            // 
            // txt_med_num
            // 
            this.txt_med_num.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_med_num.BorderColor = System.Drawing.Color.Black;
            this.txt_med_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_num.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_med_num.FocusedBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_med_num.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_med_num.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_num.ForeColor = System.Drawing.Color.Black;
            this.txt_med_num.Location = new System.Drawing.Point(170, 480);
            this.txt_med_num.Name = "txt_med_num";
            this.txt_med_num.PasswordChar = '\0';
            this.txt_med_num.SelectedText = "";
            this.txt_med_num.Size = new System.Drawing.Size(340, 36);
            this.txt_med_num.TabIndex = 38;
            // 
            // txt_med_price
            // 
            this.txt_med_price.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_med_price.BorderColor = System.Drawing.Color.Black;
            this.txt_med_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_price.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_med_price.FocusedBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_med_price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_med_price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_price.ForeColor = System.Drawing.Color.Black;
            this.txt_med_price.Location = new System.Drawing.Point(631, 480);
            this.txt_med_price.Name = "txt_med_price";
            this.txt_med_price.PasswordChar = '\0';
            this.txt_med_price.SelectedText = "";
            this.txt_med_price.Size = new System.Drawing.Size(340, 36);
            this.txt_med_price.TabIndex = 37;
            // 
            // txt_med_id
            // 
            this.txt_med_id.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_med_id.BorderColor = System.Drawing.Color.Black;
            this.txt_med_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_med_id.FocusedBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_med_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_med_id.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_id.ForeColor = System.Drawing.Color.Black;
            this.txt_med_id.Location = new System.Drawing.Point(170, 240);
            this.txt_med_id.Name = "txt_med_id";
            this.txt_med_id.PasswordChar = '\0';
            this.txt_med_id.SelectedText = "";
            this.txt_med_id.Size = new System.Drawing.Size(340, 36);
            this.txt_med_id.TabIndex = 35;
            // 
            // txt_med_name
            // 
            this.txt_med_name.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_med_name.BorderColor = System.Drawing.Color.Black;
            this.txt_med_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_med_name.FocusedBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_med_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_med_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_name.ForeColor = System.Drawing.Color.Black;
            this.txt_med_name.Location = new System.Drawing.Point(170, 360);
            this.txt_med_name.Name = "txt_med_name";
            this.txt_med_name.PasswordChar = '\0';
            this.txt_med_name.SelectedText = "";
            this.txt_med_name.Size = new System.Drawing.Size(340, 36);
            this.txt_med_name.TabIndex = 34;
            // 
            // label17_p
            // 
            this.label17_p.AutoSize = true;
            this.label17_p.BackColor = System.Drawing.Color.Transparent;
            this.label17_p.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17_p.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label17_p.Location = new System.Drawing.Point(17, 27);
            this.label17_p.Name = "label17_p";
            this.label17_p.Size = new System.Drawing.Size(262, 44);
            this.label17_p.TabIndex = 32;
            this.label17_p.Text = "Add Medicine";
            this.label17_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Price Per Unit";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Expire Date";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Manufacturing Date";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Medicine Number";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Medicine Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Medicine ID";
            // 
            // txt_med_quality
            // 
            this.txt_med_quality.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txt_med_quality.BorderColor = System.Drawing.Color.Black;
            this.txt_med_quality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_quality.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_med_quality.FocusedBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_med_quality.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_med_quality.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_quality.ForeColor = System.Drawing.Color.Black;
            this.txt_med_quality.Location = new System.Drawing.Point(631, 360);
            this.txt_med_quality.Name = "txt_med_quality";
            this.txt_med_quality.PasswordChar = '\0';
            this.txt_med_quality.SelectedText = "";
            this.txt_med_quality.Size = new System.Drawing.Size(340, 36);
            this.txt_med_quality.TabIndex = 44;
            this.txt_med_quality.TextChanged += new System.EventHandler(this.txt_med_quality_TextChanged);
            // 
            // txt_exp_date
            // 
            this.txt_exp_date.BaseColor = System.Drawing.Color.LightCyan;
            this.txt_exp_date.BorderColor = System.Drawing.Color.Black;
            this.txt_exp_date.CustomFormat = null;
            this.txt_exp_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_exp_date.FocusedColor = System.Drawing.Color.White;
            this.txt_exp_date.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exp_date.ForeColor = System.Drawing.Color.Black;
            this.txt_exp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_exp_date.Location = new System.Drawing.Point(631, 240);
            this.txt_exp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_exp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_exp_date.Name = "txt_exp_date";
            this.txt_exp_date.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_exp_date.OnHoverBorderColor = System.Drawing.Color.MidnightBlue;
            this.txt_exp_date.OnHoverForeColor = System.Drawing.Color.Black;
            this.txt_exp_date.OnPressedColor = System.Drawing.Color.Black;
            this.txt_exp_date.Size = new System.Drawing.Size(340, 36);
            this.txt_exp_date.TabIndex = 45;
            this.txt_exp_date.Text = "4/16/2025";
            this.txt_exp_date.Value = new System.DateTime(2025, 4, 16, 20, 16, 58, 108);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(568, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 523);
            this.panel1.TabIndex = 65;
            // 
            // uc_p_addMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_exp_date);
            this.Controls.Add(this.txt_med_quality);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_man_date);
            this.Controls.Add(this.txt_med_num);
            this.Controls.Add(this.txt_med_price);
            this.Controls.Add(this.txt_med_id);
            this.Controls.Add(this.txt_med_name);
            this.Controls.Add(this.label17_p);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_p_addMedicine";
            this.Size = new System.Drawing.Size(1105, 768);
            this.Load += new System.EventHandler(this.uc_p_addMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaDateTimePicker txt_man_date;
        private Guna.UI.WinForms.GunaTextBox txt_med_num;
        private Guna.UI.WinForms.GunaTextBox txt_med_price;
        private Guna.UI.WinForms.GunaTextBox txt_med_id;
        private Guna.UI.WinForms.GunaTextBox txt_med_name;
        private System.Windows.Forms.Label label17_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_med_quality;
        private Guna.UI.WinForms.GunaDateTimePicker txt_exp_date;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Panel panel1;
    }
}
