using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entities;
using Services;

namespace App
{
    public partial class Customer_Profile : Form
    {
        Login user;
        User customer;
        public Customer_Profile()
        {
            InitializeComponent();
        }
        public Customer_Profile(Login user)
        {
            this.user = user;
            InitializeComponent();
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

        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            textBox3.Text = user.Username;
            textBox8.Text = user.Password;
            textBox9.Text = user.UserType.ToString();
            RegistrationService regService = new RegistrationService();
            customer = regService.GetUserInfo(user);
            if (customer == null)
                MessageBox.Show("Not found");
            else
            {
                textBox1.Text = customer.Id.ToString();
                textBox4.Text = customer.Name;
                textBox7.Text = customer.Gender;
                textBox2.Text = customer.Email;
                textBox5.Text = customer.Phone;
                textBox6.Text = customer.Address;

            }
            
            //14725
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Id is Reduired!!!!");
            }
            else
            {
                string source = @"Data Source=.;Initial Catalog=EMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                string sqlQuery = "select * from userinfo where id = " + int.Parse(textBox1.Text);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox4.Text = (dr["name"].ToString());
                    textBox7.Text = (dr["gender"].ToString());
                    textBox2.Text = (dr["email"].ToString());
                    textBox5.Text = (dr["phone"].ToString());
                    textBox6.Text = (dr["address"].ToString());
                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
