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

namespace tokonuriskandar
{
    public partial class FormBarang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;

        string kode_barang, kode_supplier, nama_barang, stok, harga_jual;

        public FormBarang()
        {
            InitializeComponent();
        }

        private static string GetConn()
        {
            return @"Server=.\;" + "Database = tokonuriskandar; Integrated Security = true";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = GetConn();
            try
            {
                String sql = "SELECT DISTINCT kode_supplier from supplier";
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_kd_supplier.Items.Add(dr["kode_supplier"].ToString());
                }
                conn.Close();

                //list view load begin
                this.listView1.Items.Clear();
                String sql2 = "select * from barang";
                cmd2 = new SqlCommand(sql2, conn);

                conn.Open();
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    kode_barang = dr2["kode_barang"].ToString();
                    kode_supplier = dr2["kode_supplier"].ToString();
                    nama_barang = dr2["nama_barang"].ToString();
                    stok = dr2["stok"].ToString();
                    harga_jual = dr2["harga_jual"].ToString();


                    listView1.Columns.Clear();
                    listView1.Columns.Add("Kode Barang", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Kode Supplier", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Nama Barang", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Stok", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Harga Jual", 100, HorizontalAlignment.Left);

                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect = false;

                    ListViewItem item = new ListViewItem(dr2["kode_barang"].ToString(), 0);
                    item.SubItems.Add(dr2["kode_supplier"].ToString());
                    item.SubItems.Add(dr2["nama_barang"].ToString());
                    item.SubItems.Add(dr2["stok"].ToString());
                    item.SubItems.Add(dr2["harga_jual"].ToString());

                    listView1.Items.Add(item);
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
                perintahTambah.CommandText = "insert dbo.barang values(@kode_barang, @kode_supplier, @nama_barang, @stok, @harga_jual)";

                perintahTambah.Parameters.AddWithValue("@kode_barang", tb_kd_barang.Text);
                perintahTambah.Parameters.AddWithValue("@kode_supplier", cb_kd_supplier.Text);
                perintahTambah.Parameters.AddWithValue("@nama_barang", tb_nama_barang.Text);
                perintahTambah.Parameters.AddWithValue("@stok", tb_stok.Text);
                perintahTambah.Parameters.AddWithValue("@harga_jual", tb_harga_jual.Text);

                conn.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                conn.Close();

                tb_kd_barang.Text = "";
                cb_kd_supplier.Text = "";
                tb_nama_barang.Text = "";
                tb_stok.Text = "";
                tb_harga_jual.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            try{
                this.listView1.Items.Clear();
                
                String sql2 = "select * from barang";
                cmd2 = new SqlCommand(sql2, conn);

                conn.Open();
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    kode_barang = dr2["kode_barang"].ToString();
                    kode_supplier = dr2["kode_supplier"].ToString();
                    nama_barang = dr2["nama_barang"].ToString();
                    stok = dr2["stok"].ToString();
                    harga_jual = dr2["harga_jual"].ToString();


                    listView1.Columns.Clear();
                    listView1.Columns.Add("Kode Barang", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Kode Supplier", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Nama Barang", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Stok", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("Harga Jual", 100, HorizontalAlignment.Left);

                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect = false;

                    ListViewItem item = new ListViewItem(dr2["kode_barang"].ToString(), 0);
                    item.SubItems.Add(dr2["kode_supplier"].ToString());
                    item.SubItems.Add(dr2["nama_barang"].ToString());
                    item.SubItems.Add(dr2["stok"].ToString());
                    item.SubItems.Add(dr2["harga_jual"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void formBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_kd_barang.Text = "";
            cb_kd_supplier.Text = "";
            tb_nama_barang.Text = "";
            tb_stok.Text = "";
            tb_harga_jual.Text = "";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                conn.ConnectionString = GetConn();
                perintahUbah.Connection = conn;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "update dbo.barang set kode_supplier=@kode_supplier, nama_barang=@nama_barang, stok=@stok, harga_jual=@harga_jual where kode_barang=@kode_barang";

                perintahUbah.Parameters.AddWithValue("@kode_supplier", tb_kd_barang.Text);
                perintahUbah.Parameters.AddWithValue("@kode_supplier", cb_kd_supplier.Text);
                perintahUbah.Parameters.AddWithValue("@nama_barang", tb_nama_barang.Text);
                perintahUbah.Parameters.AddWithValue("@stok", tb_stok.Text);
                perintahUbah.Parameters.AddWithValue("@harga_jual", tb_harga_jual.Text);

                conn.Open();
                int hasil = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                conn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            conn.ConnectionString = GetConn();
            perintahCari.Connection = conn;

            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "select * from dbo.barang where kode_barang=@kode_barang";

            perintahCari.Parameters.Add("@kode_barang", SqlDbType.Char);
            perintahCari.Parameters["@kode_barang"].Value = tb_kd_barang.Text.Trim();

            conn.Open();
            dr = perintahCari.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");

                tb_kd_barang.Text = dr[0].ToString();
                cb_kd_supplier.Text = dr[1].ToString();
                tb_nama_barang.Text = dr[2].ToString();
                tb_stok.Text = dr[3].ToString();
                tb_harga_jual.Text = dr[4].ToString();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

            conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            conn.ConnectionString = GetConn();
            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "delete dbo.barang where kode_barang=@kode_barang";

            perintahHapus.Parameters.AddWithValue("@kode_barang", tb_kd_barang.Text.Trim());

            conn.Open();
            int result = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            conn.Close();

            tb_kd_barang.Text = "";
            cb_kd_supplier.Text = "";
            tb_nama_barang.Text = "";
            tb_stok.Text = "";
            tb_harga_jual.Text = "";
        }


    }
}
