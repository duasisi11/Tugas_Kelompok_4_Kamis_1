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
    public partial class ValidateUsernamePassword : Form
    {
        int ctr;
        public ValidateUsernamePassword()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginname, password;
            loginname = textBox1.Text;
            password = textBox2.Text;

            /*ctr = ctr + 1;
            if ((loginname == "admin") && (password == "ccit"))
            {
                MessageBox.Show("Welcome to Admin");
            }else if(ctr < 3)
            {
                MessageBox.Show("Incorrect");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Aborting....");
                Close();
            }*/

            if (loginname.Length == 0)
            {
                MessageBox.Show("Username tidak boleh kosong.!");
            }else{
                ctr = ctr + 1;
            }

            if(password.Length == 0){
                MessageBox.Show("Password tidak boleh kosong.!");
            }else{
                ctr = ctr + 1;
            }

            if ((ctr == 2) && (loginname == "admin") && (password == "ccit"))
            {
                MessageBox.Show("Selamat datang Admin");
                ctr = 0;
            }
            else if(ctr < 3)
            {
                MessageBox.Show("Belum berhasil login");
                ctr = ctr + 1;
            }
             else
            {
                MessageBox.Show("Aborting.... (batalkan)");
                Close();
            }
        }
    }
}
