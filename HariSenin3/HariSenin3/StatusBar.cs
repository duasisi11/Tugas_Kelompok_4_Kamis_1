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
    public partial class StatusBar : Form
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Caracter : " + richTextBox1.TextLength.ToString();
            toolStripStatusLabel2.Text = "Line : " + richTextBox1.Lines.Length.ToString();
        }
    }
}
