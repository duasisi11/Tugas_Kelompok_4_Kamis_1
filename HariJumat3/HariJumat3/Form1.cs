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
    public partial class Form1 : Form
    {
        int harga;
        public Form1()
        {
            InitializeComponent();
            harga = 0;
            minuman_textbox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check1 = nasgor.Checked;
            bool check2 = sotoayam.Checked;

            if (check1 == true && check2 == false)
            {
                harga = 20000;
            }
            else if (check1 == false && check2 == true)
            {
                harga = 15000;
            }
            else if (check1 == true && check2 == true)
            {
                harga = 35000;
            }

        }

        private void es_teh_CheckedChanged(object sender, EventArgs e)
        {
            if (es_teh.Checked)
            {
                harga = Int32.Parse(minuman_textbox.Text);
                harga = harga + 2000;
                minuman_textbox.Text = harga.ToString();
            }
            else
            {
                harga = Int32.Parse(minuman_textbox.Text);
                harga = harga - 2000;
                minuman_textbox.Text = harga.ToString();
            }
        }

        private void es_kopi_CheckedChanged(object sender, EventArgs e)
        {
            if (es_kopi.Checked)
            {
                harga = Int32.Parse(minuman_textbox.Text);
                harga = harga + 3000;
                minuman_textbox.Text = harga.ToString();
            }
            else
            {
                harga = Int32.Parse(minuman_textbox.Text);
                harga = harga - 3000;
                minuman_textbox.Text = harga.ToString();
            }
            
        }

        private void es_jeruk_CheckedChanged(object sender, EventArgs e)
        {
            if (es_jeruk.Checked)
            {
                harga = Int32.Parse(minuman_textbox.Text);
                harga = harga + 4000;
                minuman_textbox.Text = harga.ToString();
            }
            else
            {
                harga = harga - 4000;
                minuman_textbox.Text = harga.ToString();
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        
    }
}
