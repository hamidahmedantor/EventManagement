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
    public partial class Admin_Payment_History : Form
    {
        public Admin_Payment_History()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin1stpage ap = new Admin1stpage();
            this.Hide();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Payment_History_Load(object sender, EventArgs e)
        {
            PaymentService pay = new PaymentService();
            dataGridView1.DataSource = pay.GetAllPayment();
        }

        private void Admin_Payment_History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
