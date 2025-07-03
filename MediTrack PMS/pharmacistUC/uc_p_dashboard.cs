using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MediTrack_PMS.pharmacistUC
{
    public partial class uc_p_dashboard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 count;

        public uc_p_dashboard()
        {
            InitializeComponent();
        }

        private void uc_p_dashboard_Load(object sender, EventArgs e)
        {
            // ====== PARENT CONTROL SETTINGS ======
            this.BackColor = Color.White; // Ensure UserControl background is white
            if (panel1 != null) panel1.BackColor = Color.White; // If chart is inside a panel

            // ====== CHART STYLING ======
            // Main chart background
            chart1.BackColor = Color.White;
            // Border removed completely:
            chart1.BorderlineWidth = 0;

            // Chart area styling
            var chartArea = chart1.ChartAreas[0];
            chartArea.BackColor = Color.White;
            chartArea.BackSecondaryColor = Color.White;
            chartArea.BackGradientStyle = GradientStyle.None;
            chartArea.BackHatchStyle = ChartHatchStyle.None;
            chartArea.ShadowColor = Color.Transparent;

            // Axis styling
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            chartArea.AxisX.Title = "Category";
            chartArea.AxisX.TitleForeColor = Color.Black;
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            chartArea.AxisY.Title = "Count";
            chartArea.AxisY.TitleForeColor = Color.Black;
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            // Series styling
            chart1.Series["Valid Medicines"].ChartType = SeriesChartType.Column;
            chart1.Series["Expired Medicines"].ChartType = SeriesChartType.Column;
            chart1.Series["Valid Medicines"].Color = Color.FromArgb(70, 186, 111); // Soft green
            chart1.Series["Expired Medicines"].Color = Color.FromArgb(231, 76, 60); // Soft red

            // ====== LOAD DATA ======
            loadChart();
        }

        public void loadChart()
        {
            try
            {
                // Clear previous data
                chart1.Series["Valid Medicines"].Points.Clear();
                chart1.Series["Expired Medicines"].Points.Clear();

                // Get valid medicines count
                query = "SELECT COUNT(mname) FROM medic WHERE eDate >= GETDATE()";
                ds = fn.getData(query);
                count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity", count);

                // Get expired medicines count
                query = "SELECT COUNT(mname) FROM medic WHERE eDate <= GETDATE()";
                ds = fn.getData(query);
                count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity", count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message,
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            loadChart(); // Refresh data
        }

        // Empty event handlers (auto-generated)
        private void chart1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}