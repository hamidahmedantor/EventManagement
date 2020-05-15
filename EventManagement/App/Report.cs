using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace App
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart1.Series["Series1"].XValueMember = "EventType";
            chart1.Series["Series1"].YValueMembers = "Total";
        }

        private object GetData()
        {
            DataTable dtchartdata = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Super"].ConnectionString))
            {
                SqlCommand cmd;

                using (cmd = new SqlCommand("usp_ChartData0", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtchartdata.Load(reader);
                }
            }

            return dtchartdata;
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin1stpage ap = new Admin1stpage();
            this.Hide();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
