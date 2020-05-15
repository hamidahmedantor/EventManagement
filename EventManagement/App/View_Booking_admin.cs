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
    public partial class View_Booking_admin : Form
    {
        int id;
        public View_Booking_admin()
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

        private void View_Booking_admin_Load(object sender, EventArgs e)
        {
            BookingService b = new BookingService();
            dataGridView1.DataSource = b.GetAllBooking();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        void UpdateGridView()
        {
            BookingService catService = new BookingService();
            dataGridView1.DataSource = catService.GetAllBooking();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingService bService = new BookingService();
            Booking b = bService.GetById(id);
            b.Id = id;
            b.EventType = textBox2.Text;
            b.Vanue = textBox3.Text;
            b.Date = textBox6.Text;
            b.NoOfGuest = Convert.ToInt32(textBox4.Text);
            b.Status = Convert.ToInt32(textBox5.Text);
            b.SelectedFood = textBox8.Text;
            b.SelectedEquipment = textBox8.Text;
            int result = bService.update(b);
            if (result > 0)
            {
                MessageBox.Show("Confirmed.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookingService bService = new BookingService();

            int result = bService.delete(id);
            if (result > 0)
            {
                MessageBox.Show("Denied.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void View_Booking_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
