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
    public partial class Equipment_managment : Form
    {
        int id;
        public Equipment_managment()
        {
            InitializeComponent();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EquipmentService catService = new EquipmentService();
                Equipment eq = catService.GetById(id);
                eq.Id = id;
                eq.Name = textBox5.Text;
                eq.Cost = Convert.ToDouble(textBox4.Text);
                int result = catService.update(eq);
                if (result > 0)
                {
                    MessageBox.Show("Equipment updated.");
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

        private void Equipment_managment_Load(object sender, EventArgs e)
        {

            EquipmentService eService = new EquipmentService();
            dataGridView1.DataSource = eService.GetAllEquipment();
        }
        void UpdateGridView()
        {
            EquipmentService eService = new EquipmentService();
            dataGridView1.DataSource = eService.GetAllEquipment();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("All required must be fillup!");
            }
            else
            {
                EquipmentService ecuService = new EquipmentService();
                int result = ecuService.Insert(new Equipment() { Name = textBox5.Text, Cost = Convert.ToDouble(textBox4.Text) });
                if (result > 0)
                {
                    MessageBox.Show("Equipment added.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipmentService catService = new EquipmentService();

            int result = catService.delete(id);
            if (result > 0)
            {
                MessageBox.Show("Equipment deleted.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Equipment_managment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
