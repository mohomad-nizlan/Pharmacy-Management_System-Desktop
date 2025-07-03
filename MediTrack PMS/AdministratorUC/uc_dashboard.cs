using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTrack_PMS.AdministratorUC
{
    public partial class uc_dashboard : UserControl
    {
        function fn = new function();
        String query;

        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Single query to get counts for Administrator and Pharmacist roles only
                query = @"
                    SELECT 
                        SUM(CASE WHEN userRole = @adminRole THEN 1 ELSE 0 END) AS AdminCount,
                        SUM(CASE WHEN userRole = @pharmacistRole THEN 1 ELSE 0 END) AS PharmacistCount
                    FROM users";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@adminRole", "Administrator" },
                    { "@pharmacistRole", "Pharmacist" }
                };

                DataSet ds = fn.getData(query, parameters);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Set Administrator count
                    adminLabel.Text = ds.Tables[0].Rows[0]["AdminCount"].ToString();

                    // Set Pharmacist count (using pharanLabel to match existing Designer)
                    pharanLabel.Text = ds.Tables[0].Rows[0]["PharmacistCount"].ToString();
                }
                else
                {
                    adminLabel.Text = "0";
                    pharanLabel.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dashboard data: " + ex.Message,
                    "Database Error - MediTrack Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                adminLabel.Text = "0";
                pharanLabel.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            uc_dashboard_Load(this, null);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}