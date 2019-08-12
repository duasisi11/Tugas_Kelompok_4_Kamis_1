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

namespace idham_rep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSBaru.tbl_buku' table. You can move, or remove it, as needed.
            this.tbl_bukuTableAdapter.Fill(this.dSBaru.tbl_buku);
            // TODO: This line of code loads data into the 'dSBaru.tbl_kategori' table. You can move, or remove it, as needed.
            this.tbl_kategoriTableAdapter.Fill(this.dSBaru.tbl_kategori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;//untuk kursor pada report

            //int col = 0; //karena diambil dari kolom id                                   // nomor index field OrderID
            int row = dataGridView1.SelectedCells[0].RowIndex; // nomor index row yang dipilih 
            //int id = (int)dataGridView1[col, row].Value;      // order id yang terpilih

            DSBaru ds = new DSBaru();//nama dataset yang dibuat
            //DataTable dt = new DataTable();

            DSBaruTableAdapters.tbl_bukuTableAdapter b = new DSBaruTableAdapters.tbl_bukuTableAdapter();//dibuat sebanyak table yang dibuat
            DSBaruTableAdapters.tbl_kategoriTableAdapter k = new DSBaruTableAdapters.tbl_kategoriTableAdapter();//fungsi untuk mengambil data table

            b.FillBy(ds.tbl_buku);
            k.FillBy(ds.tbl_kategori);
            //k.setId_kategori(ds.tbl_kategori, (int)dataGridView1[9,row].Value);


            ReportClass rpt = new tes();//mengambil .rpt

            rpt.Database.Tables["tbl_buku"].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables["tbl_kategori"].SetDataSource(ds.Tables[1]);

            rpt.SetDataSource(ds);//menyimpan ds ke dalam report

            Form f1 = new tampilanLaporan(rpt);
            f1.ShowDialog();

            Cursor = Cursors.Default;
        }
    }
}
