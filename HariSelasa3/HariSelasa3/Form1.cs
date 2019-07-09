using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//tambahin
using System.Drawing.Printing;

namespace HariSelasa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ColorDialog cd = new ColorDialog();

        private void btnBackground_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            textBox1.BackColor = cd.Color;
        }

        private void btnTeks_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            this.BackColor = cd.Color;
        }

        FontDialog fd = new FontDialog();
        private void btnFont_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textBox1.Font = fd.Font;

            /*fd.ShowDialog();
            btnOpen.Font = fd.Font;*/
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.ShowDialog();
        }

        PrintDialog pd = new PrintDialog();
        internal PrintDocument pdoc = new PrintDocument();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            pd.Document = pdoc;
            DialogResult result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {
                pdoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pdoc_PrintPage);
               
                pdoc.Print();
            }
        }

        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 150, 125);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textUsername.Text, "Message (Pesan)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                e.Cancel = true;
                textUsername.Focus();
                errorProvider1.SetError(textUsername, "Please enter your Username !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textUsername, null);
            }
        }


    }
}
