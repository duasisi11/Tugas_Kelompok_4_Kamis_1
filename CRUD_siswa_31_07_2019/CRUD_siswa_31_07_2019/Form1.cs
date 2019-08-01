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

namespace CRUD_siswa_31_07_2019
{
    public partial class Form1 : Form
    {
        SqlDataReader dr;
        SqlConnection connect =  new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        static string GetConnectionStrings()
        {
            return "Data Source=WINDOWS10;Initial Catalog=siswa;Integrated Security=True";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                connect.ConnectionString = GetConnectionStrings();

                perintahTambah.Connection = connect;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.dtsiswa values(@no_induk, @nama, @asal_sekolah, @alamat, @no_tlp)";

                perintahTambah.Parameters.AddWithValue("@no_induk", Int32.Parse(Tnidk.Text));
                perintahTambah.Parameters.AddWithValue("@nama", Tnama.Text);
                perintahTambah.Parameters.AddWithValue("@asal_sekolah", Tasalsek.Text);
                perintahTambah.Parameters.AddWithValue("@alamat", Talamat.Text);
                perintahTambah.Parameters.AddWithValue("@no_tlp", Int32.Parse(Tnotlp.Text));

                connect.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                connect.Close();

                Tnidk.Text = "";
                Tnama.Text = "";
                Tasalsek.Text = "";
                Talamat.Text = "";
                Tnotlp.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            connect.ConnectionString = GetConnectionStrings();
            perintahCari.Connection = connect;

            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "select * from dbo.dtsiswa where no_induk=@no_induk";

            perintahCari.Parameters.Add("@no_induk", SqlDbType.Int);
            perintahCari.Parameters["@no_induk"].Value = Tnidk.Text.Trim();

            connect.Open();
            dr = perintahCari.ExecuteReader();

            if(dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");

                Tnidk.Text = dr[0].ToString();
                Tnama.Text = dr[1].ToString();
                Tasalsek.Text = dr[2].ToString();
                Talamat.Text = dr[3].ToString();
                Tnotlp.Text = dr[4].ToString();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                connect.ConnectionString = GetConnectionStrings();
                perintahUbah.Connection = connect;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "update dtsiswa set nama=@nama,asal_sekolah=@asal_sekolah,alamat=@alamat,no_tlp=@no_tlp where no_induk=@no_induk";
                
                perintahUbah.Parameters.AddWithValue("@nama", Tnama.Text);
                perintahUbah.Parameters.AddWithValue("@asal_sekolah", Tasalsek.Text);
                perintahUbah.Parameters.AddWithValue("@alamat", Talamat.Text);
                perintahUbah.Parameters.AddWithValue("@no_tlp", Convert.ToInt32(Tnotlp.Text));

                perintahUbah.Parameters.AddWithValue("@no_induk", Convert.ToInt32(Tnidk.Text.Trim()));

                connect.Open();
                int hasil = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                connect.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tnidk.Text = "";
            Tnama.Text = "";
            Tasalsek.Text = "";
            Talamat.Text = "";
            Tnotlp.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            connect.ConnectionString = GetConnectionStrings();
            perintahHapus.Connection = connect;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "delete dtsiswa where no_induk=@no_induk";

            perintahHapus.Parameters.AddWithValue("@no_induk", Int32.Parse(Tnidk.Text.Trim()));

            connect.Open();
            int result = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            connect.Close();

            Tnidk.Text = "";
            Tnama.Text = "";
            Tasalsek.Text = "";
            Talamat.Text = "";
            Tnotlp.Text = "";
        }
    }
}
