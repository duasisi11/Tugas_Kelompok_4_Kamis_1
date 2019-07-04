using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 1; i <= 3; i++)
            {
                Form2 kuning = new Form2();
                kuning.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                Form3 biru = new Form3();
                biru.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            

        }
    }
}
