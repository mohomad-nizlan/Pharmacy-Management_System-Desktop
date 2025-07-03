using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediTrack_PMS.AdministratorUC;

namespace MediTrack_PMS
{
    public partial class Administrator : Form
    {
        String user = "";
        public Administrator()
        {
            InitializeComponent();
        }

        public String ID
        {
            get { return user.ToString(); }
        }

        public Administrator(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uc_viewUser1.ID = ID;
            uc_profile1.ID = ID;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uc_dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uc_dashboard1.Visible = true;
            uc_dashboard1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uc_dashboard1.Visible = false;
            uC_Adduser1.Visible = false;
            uc_viewUser1.Visible = false;
            uc_profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_Adduser1.Visible = true;
            uC_Adduser1.BringToFront();
        }

        private void uC_Adduser1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewuser_Click(object sender, EventArgs e)
        {
          
        }

        private void btnViewuser_Click_1(object sender, EventArgs e)
        {
            uc_viewUser1.Visible = true;
            uc_viewUser1.BringToFront();
        }

        private void uc_profile1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uc_profile1.Visible = true;
            uc_profile1.BringToFront();

        }
    }
}
