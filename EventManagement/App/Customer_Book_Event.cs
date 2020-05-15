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
using System.Web;
using System.Net;
using System.Net.Mail;

namespace App
{
    public partial class Customer_Book_Event : Form
    {
        int m;
        Login user;
        public string food1 = "";
        public string equipment1 = "";
        public int p = 2;
        public double totalCost;
        public Customer_Book_Event()
        {
            InitializeComponent();
        }
        public Customer_Book_Event(Login user)
        {
            this.user=user;
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Book_Event_Load(object sender, EventArgs e)
        {
            VenueServices catService = new VenueServices();
            var list = catService.GetAllVenues();
            List<string> categoryNames = new List<string>();
            foreach (var item in list)
            {
                categoryNames.Add(item.Name);
            }
            comboBox2.DataSource = categoryNames;

            EquipmentServices eService = new EquipmentServices();
            var list1 = eService.GetAllFood();
            List<string> foodName = new List<string>();
            foreach (var item in list1)
            {
                foodName.Add(item.Name);
            }
            checkedListBox1.DataSource = foodName;

            EquipmentService eqService = new EquipmentService();
            var list2 = eqService.GetAllEquipment();
            List<string> eqName = new List<string>();
            foreach (var item in list2)
            {
                eqName.Add(item.Name);
            }
            checkedListBox2.DataSource = eqName;
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Mailsend(int id)
        {
            try
            {
                string smtp = "smtp.gmail.com";
                string user = "mahmud.jahid519@gmail.com";
                string pass = "01851462858";
                string from = "mahmud.jahid519@gmail.com";
                string to = textBox2.Text;
                string sub = "welcome";
                string body = "Your booking id is " + id;
                MailMessage mail = new MailMessage(from, to, sub, body);
                SmtpClient client = new SmtpClient(smtp);
                client.Port = 587;
                client.Credentials = new NetworkCredential(user, pass);
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email id");
            }

        }
        public void InsertInto(string a,string b,string c,int d,int p,string food,string equipment,double cost)
        {
            BookingService bService = new BookingService();
            int result = bService.Insert(new Booking() { EventType=a,Vanue=b,Date=c,NoOfGuest=d,Status=p,SelectedFood=food,SelectedEquipment=equipment,Cost=cost});
            if (result > 0)
            {
                BookingService bs = new BookingService();
                var x = bs.GetAllBooking();
                foreach (var s in x)
                {
                    m = s.Id;
                }
                
                if (Convert.ToInt32(textBox4.Text) > 0)
                {
                    Mailsend(m);
                    MessageBox.Show("request successsful!\n Remember your Booking Id is  " + m);
                    Customer_Home ch = new Customer_Home();
                    Customer_Book_Event cb = new Customer_Book_Event();
                    cb.Hide();
                    ch.Show();
                }
                else
                    MessageBox.Show("Number Of Guests can not be 0");
                
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty || textBox4.Text == string.Empty || comboBox1.Text == string.Empty || checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please Fillup All Requirements....");
                }
                else
                {
                    totalCost = 0;
                    int g = Convert.ToInt32(textBox4.Text);
                    VenueServices vs = new VenueServices();
                    var x = vs.GetByName(comboBox2.Text);
                    totalCost += (x.Cost);
                    EquipmentServices eq = new EquipmentServices();
                    foreach (string s in checkedListBox1.CheckedItems)
                    {
                        var y = eq.GetByName(s);
                        totalCost += ((y.Cost) * g);
                        food1 += s + " ";
                    }
                    EquipmentService es = new EquipmentService();
                    foreach (string s in checkedListBox2.CheckedItems)
                    {
                        var z = es.GetByName(s);
                        totalCost += (z.Cost);
                        equipment1 += s + " ";
                    }
                    textBox1.Text = totalCost.ToString();
                    InsertInto(comboBox1.Text, comboBox2.Text, dateTimePicker1.Value.ToShortDateString().ToString(), g, p, food1, equipment1, totalCost);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something is Wrong!!!");
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                comboBox1.Text = "";
                checkedListBox1.Items.Clear();
                textBox4.Text = "";
                textBox1.Text = "";
                checkedListBox2.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to clear");
            }
        }

        private void Customer_Book_Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
