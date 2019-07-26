using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Koneksi_Database1_26_07_2019
{
    public partial class Form1 : Form
    {
        SqlConnection koneksi;
        SqlDataReader dr;

        string nik, nama, tempat_lahir, tanggal_lahir, alamat;
        public Form1()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=DBKota;User ID=nuriskandar;Password=1122";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintah;
                koneksi = new SqlConnection(getKoneksi());

                perintah = new SqlCommand("select * from tbl_warga", koneksi);

                koneksi.Open();
                dr = perintah.ExecuteReader();

                while (dr.Read())
                {
                    nik = dr["nik"].ToString();
                    nama = dr["nama"].ToString();
                    tempat_lahir = dr["tempat_lahir"].ToString();
                    tanggal_lahir = dr["tanggal_lahir"].ToString();
                    alamat = dr["alamat"].ToString();

                    listBox1.Items.Add(nik + " " + nama + " " + tempat_lahir + " " + tanggal_lahir + " " + alamat);
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}
