using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HariKamis3
{
    public partial class Komponen2Form : Form
    {
        public Komponen2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Aku Wibu";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Multiline = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue; //mengatur warna teks
            linkLabel1.ActiveLinkColor = Color.Gray; //mengatur warna Link Aktif
            linkLabel1.DisabledLinkColor = Color.Red; //Mengatur warna Link Non-Aktif
            linkLabel1.LinkVisited = true; //Mengatur Link seolah telah dikunjungi
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Terjadi Kesalahan";
            label4.AutoSize = true;
        }
    }
}
