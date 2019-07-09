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
    public partial class ValidasiForm : Form
    {
        public ValidasiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show(" Nama tidak boleh dikosongkan");
            }

            if(Convert.ToInt32(textBox2.Text) < 17){
                MessageBox.Show("Umur tidak boleh dibawah 17");
            }

            if(Convert.ToDateTime(textBox3.Text) > DateTime.Now)
            {
                MessageBox.Show("Tanggal salah tidak boleh melebih tanggal sekarang");
            }
        }
    }
}
