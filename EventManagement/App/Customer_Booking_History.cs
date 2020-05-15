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
    public partial class Customer_Booking_History : Form
    {
        public Customer_Booking_History()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Home ch = new Customer_Home();
            this.Hide();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Booking_History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
