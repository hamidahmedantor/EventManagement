using Services;
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
    public partial class Venue_management : Form
    {
        int id;
        public Venue_management()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void UpdateGridView()
        {
            VenueServices catService = new VenueServices();
            dataGridView1.DataSource = catService.GetAllVenues();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("All required must be fillup!");
            }
            else
            {
                VenueServices venService = new VenueServices();
                int result = venService.Insert(new Venue() { Name = textBox5.Text, Place = textBox4.Text, Cost = Convert.ToDouble(textBox3.Text), Contact = textBox2.Text });
                if (result > 0)
                {
                    MessageBox.Show("Venue added.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin1stpage al = new Admin1stpage();
            this.Hide();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Venue_management_Load(object sender, EventArgs e)
        {
            VenueServices venService = new VenueServices();
            dataGridView1.DataSource = venService.GetAllVenues();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VenueServices catService = new VenueServices();
                Venue venue = catService.GetById(id);
                venue.Id = id;
                venue.Name = textBox5.Text;
                venue.Place = textBox4.Text;
                venue.Cost = Convert.ToDouble(textBox3.Text);
                venue.Contact = textBox2.Text;
                int result = catService.update(venue);
                if (result > 0)
                {
                    MessageBox.Show("Venue updated.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VenueServices catService = new VenueServices();

            int result = catService.delete(id);
            if (result > 0)
            {
                MessageBox.Show("venue deleted.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Venue_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
