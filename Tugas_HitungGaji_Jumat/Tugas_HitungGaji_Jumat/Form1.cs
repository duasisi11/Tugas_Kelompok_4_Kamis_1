using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_HitungGaji_Jumat
{
    public partial class Form1 : Form
    {
        double gaji_bersih;
        double gapok;
        double transport;
        double makan;
        double income_gaji;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_gapok.Text.Length == 0 && tb_transport.Length != 0 && tb_makan.Text.Length != 0)
            {
                tb_gapok.Text = "0";
            }
            else if(tb_transport.Text.Length == 0)
            {
                tb_transport.Text = "0";
            }
            else if(tb_makan.Text.Length == 0)
            {
                tb_makan.Text = "0";
            }

            gapok = double.Parse(tb_gapok.Text);
            transport = double.Parse(tb_transport.Text);
            makan = double.Parse(tb_makan.Text);

            income_gaji = gapok+transport+makan;
            tb_income.Text = income_gaji.ToString();
        }
    }
}
