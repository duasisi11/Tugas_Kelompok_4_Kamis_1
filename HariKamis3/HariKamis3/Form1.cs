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
    public partial class Form1 : Form
    {
        Form2 obj_form2;

        public Form1() //menginisialisasi variable atau constructor
        {
            InitializeComponent();
            obj_form2 = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            obj_form2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj_form2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj_form2.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj_form2.SetDesktopLocation(80, 100);
        }
      

      
    }
}
