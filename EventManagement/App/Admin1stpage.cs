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
    public partial class Admin1stpage : Form
    {
        Login user;
        public Admin1stpage()
        {
            InitializeComponent();
        }
        public Admin1stpage(Login user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upcoming_Event nf = new Upcoming_Event();
            this.Hide();
            nf.Show();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            Venue_management vm = new Venue_management();
            this.Hide();
            vm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food_management fd = new Food_management();
            this.Hide();
            fd.Show();
        }

        private void buttonviewvenus_Click(object sender, EventArgs e)
        {
            Equipment_managment em = new Equipment_managment();
            this.Hide();
            em.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlogin al = new Adminlogin();
            this.Hide();
            al.Show();
        }

        private void buttonbookinghistory_Click(object sender, EventArgs e)
        {
            View_Booking_admin bk = new View_Booking_admin();
            this.Hide();
            bk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_feedback af = new Admin_feedback();
            this.Hide();
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Payment_History aph = new Admin_Payment_History();
            this.Hide();
            aph.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Hide();
            hp.Show();
        }

        private void Admin1stpage_Load(object sender, EventArgs e)
        {
           // label11.Text = user.Username;
        }

        private void Admin1stpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            this.Hide();
            r.Show();
        }
    }
}
