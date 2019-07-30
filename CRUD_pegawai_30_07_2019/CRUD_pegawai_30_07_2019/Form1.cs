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

namespace CRUD_pegawai_30_07_2019
{
    public partial class Form1 : Form
    {
        SqlDataReader dr;
        SqlConnection koneksi = new SqlConnection();
        String Kode_Gapok;

        public Form1()
        {
            InitializeComponent();
        }

        static string GetConnectionStrings()
        {
            return "Data Source=WINDOWS10;Initial Catalog=kepegawaian;User ID=nuriskandar;Password=1122";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand perintah = new SqlCommand();
            koneksi.ConnectionString = GetConnectionStrings();

            Cpend.Text = "";
            Cjk.Text = "";
            Cagm.Text = "";
            Ckgp.Text = "";
            Dtgl.Value = DateTime.Now;

            String kueri = "SELECT * FROM schkaryawan.gaji_pokok";
            perintah = new SqlCommand(kueri, koneksi);

            koneksi.Open();
            dr = perintah.ExecuteReader();
            while (dr.Read())
            {
                Kode_Gapok = dr[0].ToString();
                Ckgp.Items.Add(Kode_Gapok);
            }
            koneksi.Close();
            Ckgp.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                koneksi.ConnectionString = GetConnectionStrings();
                perintahTambah.Connection = koneksi;
                perintahTambah.CommandType = CommandType.Text;

                perintahTambah.CommandText = "insert schkaryawan.pegawai values(@nip,@nama,@alamat,@kota,@tempat_lhr,@tgl_lhr,@pendidikan,@jns_kelamin,@agama,@kode_gapok,@status,@jml_anak)";
                
                perintahTambah.Parameters.AddWithValue("@nip", Tnip.Text);
                perintahTambah.Parameters.AddWithValue("@nama", Tnama.Text);
                perintahTambah.Parameters.AddWithValue("@alamat", Talamat.Text);
                perintahTambah.Parameters.AddWithValue("@kota", Tkota.Text);
                perintahTambah.Parameters.AddWithValue("@tempat_lhr", Ttempat.Text);
                perintahTambah.Parameters.AddWithValue("@tgl_lhr", Dtgl.Value.Date);
                perintahTambah.Parameters.AddWithValue("@pendidikan", Cpend.Text);
                perintahTambah.Parameters.AddWithValue("@jns_kelamin", Cjk.Text);
                perintahTambah.Parameters.AddWithValue("@agama", Cagm.Text);
                perintahTambah.Parameters.AddWithValue("@kode_gapok", Ckgp.Text);
                perintahTambah.Parameters.AddWithValue("@status", Cstatus.Text);
                perintahTambah.Parameters.AddWithValue("@jml_anak", Convert.ToInt32(Tjml.Text));

                koneksi.Open();

                int hasil = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");

                koneksi.Close();

                Tnip.Text = "";
                Tnama.Text = "";
                Talamat.Text = "";
                Tkota.Text = "";
                Ttempat.Text = "";
                Dtgl.Value = DateTime.Now;
                Cpend.Text = "";
                Cjk.Text = "";
                Cagm.Text = "";
                Ckgp.Text = "";
                Cstatus.Text = "";
                Tjml.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            koneksi.ConnectionString = GetConnectionStrings();
            perintahCari.Connection = koneksi;

            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "select * from schkaryawan.pegawai where nip = @nip";

            perintahCari.Parameters.Add("@nip", SqlDbType.Char);
            perintahCari.Parameters["@nip"].Value = Tnip.Text.Trim();

            koneksi.Open();
            dr = perintahCari.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");

                Tnip.Text = dr[0].ToString();
                Tnama.Text = dr[1].ToString();
                Talamat.Text = dr[2].ToString();
                Tkota.Text = dr[3].ToString();
                Ttempat.Text = dr[4].ToString();
                Dtgl.Value = Convert.ToDateTime(dr[5].ToString());
                Cpend.Text = dr[6].ToString();
                Cjk.Text = dr[7].ToString();
                Cagm.Text = dr[8].ToString();
                Ckgp.Text = dr[9].ToString();
                Cstatus.Text = dr[10].ToString();
                Tjml.Text = dr[11].ToString();
            }
            else{

                MessageBox.Show("Data Tidak Ditemukan");
            }

            koneksi.Close();
        }


    }
}
