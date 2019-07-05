using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HariJumat3
{
    public partial class Kalkulator : Form
    {
        double total;
        double angka1,angka2;
        string tanda;

        delegate double Ops_hitung(double anka1, double angka2);
        public Kalkulator()
        {
            InitializeComponent();
            total = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            angka1 = double.Parse(textBox1.Text);
            angka2 = double.Parse(textBox2.Text);

            Ops_hitung hitung = tambah;

            total = hitung(angka1, angka2);
            textBox3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angka1 = double.Parse(textBox1.Text);
            angka2 = double.Parse(textBox2.Text);

            total = angka1 - angka2;

            textBox3.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angka1 = double.Parse(textBox1.Text);
            angka2 = double.Parse(textBox2.Text);

            total = angka1 * angka2;

            textBox3.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angka1 = double.Parse(textBox1.Text);
            angka2 = double.Parse(textBox2.Text);

            total = angka1 / angka2;

            textBox3.Text = total.ToString();
        }

        private double tambah(double angka1,double angka2){
            total = angka1 + angka2;

            return total;
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            angka1 = double.Parse(textBox4.Text);
            angka2 = double.Parse(textBox5.Text);
            

            if (tanda == "+")
            {
                Ops_hitung hitung = tambah;

                total = hitung(angka1, angka2);
                textBox6.Text = total.ToString();
            }
            else { 
                total = 0;
                textBox6.Text = total.ToString();
            } 
        }

        private void plus_Click(object sender, EventArgs e)
        {
            tanda = "plus";
        }

        
    }
}
