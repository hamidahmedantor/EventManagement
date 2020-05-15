using Entities;
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
    public partial class Customer_View_Venue : Form
    {
        Login user;
        public Customer_View_Venue()
        {
            InitializeComponent();
        }
        public Customer_View_Venue(Login user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Customer_View_Venue_Load(object sender, EventArgs e)
        {
            VenueServices v = new VenueServices();
            dataGridView1.DataSource = v.GetAllVenues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Home ch = new Customer_Home(user);
            this.Hide();
            ch.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Customer_View_Venue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
