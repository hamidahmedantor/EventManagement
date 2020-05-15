using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Upcoming_Event : Form
    {
        public Upcoming_Event()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin1stpage al = new Admin1stpage();
            this.Hide();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Upcoming_Event_Load(object sender, EventArgs e)
        {
            BookingService bservice = new BookingService();
            dataGridView1.DataSource = bservice.GetAllBookings();
        }

        private void Upcoming_Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
