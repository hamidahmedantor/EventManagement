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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
           
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Username or Password can not be empty.");

                }

                else
                {
                    Login ln = new Login();
                    ln.Username = textBox1.Text;
                    ln.Password = textBox2.Text;
                    Login result = loginService.LoginValidation(ln);
                    if (result.UserType > 0)
                    {
                        if (result.UserType == 1)
                        {
                            Admin1stpage ap = new Admin1stpage(result);
                            this.Hide();
                            ap.Show();
                        }
                        else if (result.UserType == 2)
                        {

                            Customer_Home ch = new Customer_Home(result);
                            this.Hide();
                            ch.Show();

                        }
                        else
                        {
                            MessageBox.Show("User does not exist.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
