using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;

namespace Report_Buku_09_08_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_library.tbl_buku' table. You can move, or remove it, as needed.
            this.tbl_bukuTableAdapter.Fill(this.dS_library.tbl_buku);
            // TODO: This line of code loads data into the 'dS_library.tbl_kategori' table. You can move, or remove it, as needed.
            this.tbl_kategoriTableAdapter.Fill(this.dS_library.tbl_kategori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor; //untuk kursor pada report

            //int col = 0; //karena diambil dari kolom id
            int row = dataGridView1.SelectedCells[0].RowIndex; //nomor
            //int id = (int)dataGridView1[col, row].Value;

            DS_library ds = new DS_library(); //nama dataset yang dibuat
            //DataTable dt = new DataTable();

            DS_libraryTableAdapters.tbl_bukuTableAdapter b = new DS_libraryTableAdapters.tbl_bukuTableAdapter();
            DS_libraryTableAdapters.tbl_kategoriTableAdapter k = new DS_libraryTableAdapters.tbl_kategoriTableAdapter();

            b.FillBy(ds.tbl_buku);
            k.FillBy(ds.tbl_kategori);

            ReportClass rpt = new CR_Library(); //mengambil .rpt

            rpt.Database.Tables["tbl_buku"].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables["tbl_kategori"].SetDataSource(ds.Tables[1]);

            rpt.SetDataSource(ds); //menyimpan ds ke dalam report

            Form f1 = new TampilanLaporan(rpt);
            //Form f1 = new TampilanLaporan();
            f1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help.ShowHelp(this, "file://c:\\Users\\LAB15\\Documents\\TmpHtml\\Untitled.chm");
        }
    }
}
