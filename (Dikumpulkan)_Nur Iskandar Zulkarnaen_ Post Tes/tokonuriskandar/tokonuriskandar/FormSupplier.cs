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
    public partial class FormSupplier : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlDataReader dr;

        public FormSupplier()
        {
            InitializeComponent();
        }

        static string GetConnectionStrings()
        {
            return @"Server=.\;" + "Database = tokonuriskandar; Integrated Security = true";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                connect.ConnectionString = GetConnectionStrings();

                perintahTambah.Connection = connect;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.supplier values(@kode_supplier, @nama_supplier, @telepon)";

                perintahTambah.Parameters.AddWithValue("@kode_supplier", tb_kd_supplier.Text);
                perintahTambah.Parameters.AddWithValue("@nama_supplier", tb_nama_supplier.Text);
                perintahTambah.Parameters.AddWithValue("@telepon", tb_telepon.Text);

                connect.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                connect.Close();

                tb_kd_supplier.Text = "";
                tb_nama_supplier.Text = "";
                tb_telepon.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                connect.ConnectionString = GetConnectionStrings();
                perintahUbah.Connection = connect;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "update dbo.supplier set nama_supplier=@nama_supplier, telepon=@telepon where kode_supplier=@kode_supplier";

                perintahUbah.Parameters.AddWithValue("@kode_supplier", tb_kd_supplier.Text);
                perintahUbah.Parameters.AddWithValue("@nama_supplier", tb_nama_supplier.Text);
                perintahUbah.Parameters.AddWithValue("@telepon", tb_telepon.Text);

                connect.Open();
                int hasil = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                connect.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            connect.ConnectionString = GetConnectionStrings();
            perintahHapus.Connection = connect;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "delete dbo.supplier where kode_supplier=@kode_supplier";

            perintahHapus.Parameters.AddWithValue("@kode_supplier", tb_kd_supplier.Text.Trim());

            connect.Open();
            int result = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            connect.Close();

            tb_kd_supplier.Text = "";
            tb_nama_supplier.Text = "";
            tb_telepon.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_kd_supplier.Text = "";
            tb_nama_supplier.Text = "";
            tb_telepon.Text = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            connect.ConnectionString = GetConnectionStrings();
            perintahCari.Connection = connect;

            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "select * from dbo.supplier where kode_supplier=@kode_supplier";

            perintahCari.Parameters.Add("@kode_supplier", SqlDbType.Char);
            perintahCari.Parameters["@kode_supplier"].Value = tb_kd_supplier.Text.Trim();

            connect.Open();
            dr = perintahCari.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");

                tb_kd_supplier.Text = dr[0].ToString();
                tb_nama_supplier.Text = dr[1].ToString();
                tb_telepon.Text = dr[2].ToString();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

            connect.Close();
        }

        private void formBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang fb = new FormBarang();
            fb.Show();
        }

        private void formPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPelanggan fp = new FormPelanggan();
            fp.Show();
        }

        private void formTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi ft = new FormTransaksi();
            ft.Show();
        }
    }
}
