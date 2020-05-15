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
    public partial class Customer_feedback : Form
    {
        Login user;
        public Customer_feedback()
        {
            InitializeComponent();
        }
        public Customer_feedback(Login user)
        {
            this.user = user;
            InitializeComponent();
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

        /*private void button3_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Check Booking Id or Feedback");
            }
            else
            {
                FeedbackService feedService = new FeedbackService();
                int result = feedService.Insert(new Feedback() { Feedback_Details = textBox1.Text, Id = Convert.ToInt32(textBox2.Text) });

                if (result > 0)
                {
                    MessageBox.Show("Feedback added.");
                    Customer_Home ch = new Customer_Home();
                    this.Hide();
                    ch.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }
        */

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Check Booking Id or Feedback");
                }
                else
                {
                    BookingService bs = new BookingService();
                    Booking b = bs.GetById(Convert.ToInt32(textBox2.Text));
                    string type = b.EventType;

                    FeedbackService feedService = new FeedbackService();
                    int result = feedService.Insert(new Feedback() { Feedback_Details = textBox1.Text, Id = Convert.ToInt32(textBox2.Text), Event_Type = type });

                    if (result > 0)
                    {
                        MessageBox.Show("Feedback added.");
                        Customer_Home ch = new Customer_Home();
                        this.Hide();
                        ch.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Input");
            }
        }

        private void Customer_feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
