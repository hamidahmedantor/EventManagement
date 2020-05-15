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
    public partial class Food_management : Form
    {
        int id;
        public Food_management()
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
            //FoodServices fService = new FoodServices();
            //dataGridView2.DataSource = fService.GetAllFood();
        }

        private void Food_management_Load(object sender, EventArgs e)
        {
            EquipmentServices fService = new EquipmentServices();
            dataGridView2.DataSource = fService.GetAllFood();
        }
        void UpdateGridView()
        {
            EquipmentServices fService = new EquipmentServices();
            dataGridView2.DataSource = fService.GetAllFood();
        }

        private void buttonbookingstatus_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("All required must be fillup!");
            }
            else
            {
                EquipmentServices foodService = new EquipmentServices();
                int result = foodService.Insert(new Food() { Name = textBox5.Text, Cost = Convert.ToDouble(textBox4.Text) });
                if (result > 0)
                {
                    MessageBox.Show("Food added.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EquipmentServices catService = new EquipmentServices();
                Food f = catService.GetById(id);
                f.Id = id;
                f.Name = textBox5.Text;
                f.Cost = Convert.ToDouble(textBox4.Text);
                int result = catService.update(f);
                if (result > 0)
                {
                    MessageBox.Show("Food updated.");
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipmentServices catService = new EquipmentServices();

            int result = catService.delete(id);
            if (result > 0)
            {
                MessageBox.Show("Food deleted.");
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

        private void Food_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
