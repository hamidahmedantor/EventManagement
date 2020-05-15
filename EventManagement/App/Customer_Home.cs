using Entities;
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
    public partial class Customer_Home : Form
    {
        Login user;
        public Customer_Home()
        {
            InitializeComponent();
        }
        public Customer_Home(Login user)
        {
            this.user = user;
            InitializeComponent();
            
        }
        private void Customer_Home_Load(object sender, EventArgs e)
        {
            //label7.Text = user.Username;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonviewvenus_Click(object sender, EventArgs e)
        {
            Customer_Profile cp = new Customer_Profile(user);
            this.Hide();
            cp.Show();

           

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer_View_Venue cvm = new Customer_View_Venue(user);
            this.Hide();
            cvm.Show();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            Customer_Book_Event cbe = new Customer_Book_Event(user);
            this.Hide();
            cbe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_Book_Status cbs = new Customer_Book_Status(user);
            this.Hide();
            cbs.Show();
        }

        private void buttonbookinghistory_Click(object sender, EventArgs e)
        {
            Customer_Booking_History cbh = new Customer_Booking_History();
            this.Hide();
            cbh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
            hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_feedback af = new Customer_feedback(user);
            this.Hide();
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Customer_payment cp = new Customer_payment(user);
            this.Hide();
            cp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
            hp.Show();
        }

        private void Customer_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
