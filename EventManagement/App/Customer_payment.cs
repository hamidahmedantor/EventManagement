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
    public partial class Customer_payment : Form
    {
        Login user;
        public Customer_payment()
        {
            InitializeComponent();
        }
        public Customer_payment(Login user)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Booking id is required!!");
            }
            else
            {
                try
                {
                    BookingService b = new BookingService();
                    Booking book = b.GetById(Convert.ToInt32(textBox4.Text));
                    textBox2.Text = Convert.ToString(book.Cost);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid");
                }
            }

        }

        private void buttonviewvenus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("invalid");
                }
                else
                {
                    PaymentService pService = new PaymentService();
                    int result = pService.Insert(new Payment() { CardNo = Convert.ToInt32(textBox5.Text), CvvNo = Convert.ToInt32(textBox3.Text), NameOnCard = textBox1.Text, ExpDate = dateTimePicker1.Value.ToShortDateString().ToString(), Bid = Convert.ToInt32(textBox4.Text), Payments = Convert.ToDouble(textBox2.Text) });
                    if (result > 0)
                    {
                        MessageBox.Show("payment successfull.");
                        ////UpdateGridView();
                        BookingService bService = new BookingService();
                        //////CategoryService catService = new CategoryService();
                        ////Booking b = bService.GetById(Convert.ToInt32(textBox4.Text));
                        ////b.Id = Convert.ToInt32(textBox4.Text);
                        ////b.EventType = textBox2.Text;
                        ////b.Vanue = textBox3.Text;
                        ////b.Date = textBox6.Text;
                        ////b.NoOfGuest = Convert.ToInt32(textBox4.Text);
                        ////b.Status = Convert.ToInt32(textBox5.Text);
                        ////b.SelectedFood = textBox8.Text;
                        ////b.SelectedEquipment = textBox8.Text;
                        ////bService.Update(b);
                        bService.update1(Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox2.Text));
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is some error in peyment");
            }
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Customer_payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
