using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HariSenin3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Width = 200;
            comboBox1.Height = 25;
            comboBox1.DropDownHeight = 50;
            comboBox1.DropDownWidth = 100;
            comboBox1.Font = new Font("Georgia", 16);
            comboBox1.ForeColor = System.Drawing.Color.Yellow;
            comboBox1.BackColor = System.Drawing.Color.Blue;
            comboBox1.Items.Add("Wuling");
            comboBox1.Items.Add("Jaguar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = this.comboBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = this.comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            StringBuilder sb = new StringBuilder();
            foreach (string name in comboBox1.Items)
            {
                sb.Append(name);
                sb.Append("\n ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tambah = textBox2.Text;
            comboBox2.ForeColor = System.Drawing.Color.Red;
            comboBox2.BackColor = System.Drawing.Color.Yellow;
            comboBox2.Items.Add(tambah);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(textBox3.Text);
            if (index < 0)
            {
                MessageBox.Show("Item not found. ");
                textBox3.Text = String.Empty;
            }
            else
            {
                comboBox1.SelectedIndex = index;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String kurang = textBox4.Text;
            comboBox1.ForeColor = System.Drawing.Color.Red;
            comboBox1.BackColor = System.Drawing.Color.Yellow;
            comboBox1.Items.Remove(kurang);
            comboBox1.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
