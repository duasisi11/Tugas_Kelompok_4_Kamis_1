using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

using CrystalDecisions.CrystalReports.Engine;

namespace tokonuriskandar
{
    public partial class FormTransaksi : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        static string GetConn()
        {
            return @"Server=.\;" + "Database = tokonuriskandar; Integrated Security = true";
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokonuriskandarDataSet.transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.tokonuriskandarDataSet.transaksi);

            conn = new SqlConnection();
            conn.ConnectionString = GetConn();

            try
            {
                String sql = "SELECT DISTINCT kode_barang from barang";
                String sql2 = "SELECT DISTINCT kode_pelanggan from pelanggan";
                cmd = new SqlCommand(sql, conn);

                cmd2 = new SqlCommand(sql2, conn);


                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_kd_barang.Items.Add(dr["kode_barang"].ToString());             
                }
                conn.Close();

                conn.Open();
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    cb_kd_pelanggan.Items.Add(dr2["kode_pelanggan"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                conn.ConnectionString = GetConn();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.transaksi values(@tanggal, @kode_barang, @kode_pelanggan, @jumlah)";

                perintahTambah.Parameters.AddWithValue("@tanggal", dtp_tanggal.Value);
                perintahTambah.Parameters.AddWithValue("@kode_barang", cb_kd_barang.Text);
                perintahTambah.Parameters.AddWithValue("@kode_pelanggan", cb_kd_pelanggan.Text);
                perintahTambah.Parameters.AddWithValue("@jumlah", tb_jumlah.Text);

                conn.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                conn.Close();

                dtp_tanggal.Value = DateTime.Now; 
                cb_kd_barang.Text = "";
                cb_kd_pelanggan.Text = "";
                tb_jumlah.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            this.transaksiTableAdapter.Fill(this.tokonuriskandarDataSet.transaksi);
        }

        private void btn_report_all_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor; //untuk kursor pada report

            int row = dataGridView1.SelectedCells[0].RowIndex; //nomor

            DS_transaksi ds = new DS_transaksi(); //nama dataset yang dibuat

            DS_transaksiTableAdapters.transaksiTableAdapter t = new DS_transaksiTableAdapters.transaksiTableAdapter();

            t.FillBy(ds.transaksi);

            ReportClass rpt = new CrystalReport1(); //mengambil .rpt

            rpt.Database.Tables["transaksi"].SetDataSource(ds.Tables[0]);

            rpt.SetDataSource(ds); //menyimpan ds ke dalam report

            Form f1 = new FormReport(rpt);
           
            f1.ShowDialog();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
    }
}
