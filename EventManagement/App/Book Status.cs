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
    public partial class Customer_Book_Status : Form
    {
        Login user;
        public Customer_Book_Status()
        {
            InitializeComponent();
        }
        public Customer_Book_Status(Login user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Book_Status_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Home ch = new Customer_Home(user);
            this.Hide();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Id is required to show status!!");
            }
            else
            {
                try
                {
                    BookingService bs = new BookingService();
                    Booking b = bs.GetById(Convert.ToInt32(textBox1.Text));
                    label3.Text = textBox1.Text;
                    if (b.Status == 2)
                    {
                        label7.Text = "pending";
                    }
                    else if (b.Status == 1)
                    {
                        label7.Text = "Accepted";
                    }
                    else
                    {
                        label7.Text = "rejected";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect Inputt!!");
                }
            }
        }

        private void Customer_Book_Status_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
