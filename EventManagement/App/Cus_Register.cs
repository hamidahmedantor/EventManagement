using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace App
{
    public partial class Cus_Register : Form
    {
        public Cus_Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
            hp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cus_Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox8.Text == string.Empty || comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Requirement must be fillup");
            }
            else
            {
                RegistrationService registration = new RegistrationService();
                int usertype = 0;
                if (comboBox2.Text == "Admin")
                {
                    usertype = 1;
                }
                else { usertype = 2; }

                int result = registration.UserRegistration(textBox1.Text, textBox6.Text, textBox4.Text, textBox2.Text, textBox5.Text, textBox3.Text, textBox8.Text, usertype);
                if (result > 0)
                {
                        MessageBox.Show("You are registered");
                        Homepage hp = new Homepage();
                        this.Hide();
                        hp.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Cus_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\s]");
            //char ch = e.KeyChar;
            //if (Char.IsDigit(ch))
            //{
            //    e.Handled = true;
            //}
            
            //else if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
            //else
            //{
            //    e.Handled = false;
            //}
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
             
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                // These characters may pass
                e.Handled = true;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = false;
            }
        }

      

        
    }
}
