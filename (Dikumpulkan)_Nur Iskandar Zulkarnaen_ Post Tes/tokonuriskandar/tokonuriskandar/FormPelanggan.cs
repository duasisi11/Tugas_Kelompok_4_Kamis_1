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
    public partial class FormPelanggan : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlDataReader dr;

        public FormPelanggan()
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
                perintahTambah.CommandText = "insert dbo.pelanggan values(@kode_pelanggan, @nama_pelanggan, @alamat, @telepon)";

                perintahTambah.Parameters.AddWithValue("@kode_pelanggan", tb_kd_pelanggan.Text);
                perintahTambah.Parameters.AddWithValue("@nama_pelanggan", tb_nama_pelanggan.Text);
                perintahTambah.Parameters.AddWithValue("@alamat", tb_alamat.Text);
                perintahTambah.Parameters.AddWithValue("@telepon", tb_telepon.Text);

                connect.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                connect.Close();

                tb_kd_pelanggan.Text = "";
                tb_nama_pelanggan.Text = "";
                tb_alamat.Text = "";
                tb_telepon.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            connect.ConnectionString = GetConnectionStrings();
            perintahCari.Connection = connect;

            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "select * from dbo.pelanggan where kode_pelanggan=@kode_pelanggan";

            perintahCari.Parameters.Add("@kode_pelanggan", SqlDbType.Char);
            perintahCari.Parameters["@kode_pelanggan"].Value = tb_kd_pelanggan.Text.Trim();

            connect.Open();
            dr = perintahCari.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");

                tb_kd_pelanggan.Text = dr[0].ToString();
                tb_nama_pelanggan.Text = dr[1].ToString();
                tb_alamat.Text = dr[2].ToString();
                tb_telepon.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

            connect.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                connect.ConnectionString = GetConnectionStrings();
                perintahUbah.Connection = connect;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "update dbo.pelanggan set nama_pelanggan=@nama_pelanggan, alamat=@alamat, telepon=@telepon where kode_pelanggan=@kode_pelanggan";

                perintahUbah.Parameters.AddWithValue("@kode_pelanggan", tb_kd_pelanggan.Text);
                perintahUbah.Parameters.AddWithValue("@nama_pelanggan", tb_nama_pelanggan.Text);
                perintahUbah.Parameters.AddWithValue("@alamat", tb_alamat.Text);
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
            perintahHapus.CommandText = "delete dbo.pelanggan where kode_pelanggan=@kode_pelanggan";

            perintahHapus.Parameters.AddWithValue("@kode_pelanggan", tb_kd_pelanggan.Text.Trim());

            connect.Open();
            int result = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            connect.Close();

            tb_kd_pelanggan.Text = "";
            tb_nama_pelanggan.Text = "";
            tb_alamat.Text = "";
            tb_telepon.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_kd_pelanggan.Text = "";
            tb_nama_pelanggan.Text = "";
            tb_alamat.Text = "";
            tb_telepon.Text = "";
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
