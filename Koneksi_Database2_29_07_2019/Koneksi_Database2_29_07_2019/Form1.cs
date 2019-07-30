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

namespace Koneksi_Database2_29_07_2019
{
    public partial class Form1 : Form
    {
        SqlConnection koneksi;
        SqlDataReader dr;

        string kode_jabatan, nama_jabatan, tunjangan_jabatan;
        string nip, nama, gaji;

        public Form1()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=kepegawaian;User ID=nuriskandar;Password=1122";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintah;
                koneksi = new SqlConnection(getKoneksi());

                //perintah = new SqlCommand("select * from schkaryawan.jabatan", koneksi);
perintah = new SqlCommand("select p.NIP AS NIP, p.nama AS Nama, gp.gaji_pokok AS Gaji from schkaryawan.pegawai p, schkaryawan.gaji_pokok gp where p.Kode_Gapok= gp.Kode_Gapok", koneksi);
                
                koneksi.Open();
                dr = perintah.ExecuteReader();


                while (dr.Read())
                {
                    //listbox

                    nip = dr["nip"].ToString();
                    nama = dr["nama"].ToString();
                    gaji = dr["gaji"].ToString();

                    listBox1.Items.Add(nip + " " + nama + " " + gaji);

                    //Menampilkan list view
                    listView1.Columns.Clear();
                    listView1.Columns.Add("NIP", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("nama", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("gaji", 100, HorizontalAlignment.Left);

                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect = false;

                    ListViewItem item1 = new ListViewItem(dr["nip"].ToString(), 0);
                    item1.SubItems.Add(dr["nama"].ToString());
                    item1.SubItems.Add(dr["gaji"].ToString());

                    listView1.Items.Add(item1);
                }

                /*while(dr.Read())
                {
                    kode_jabatan = dr["kode_jabatan"].ToString();
                    nama_jabatan = dr["nama_jabatan"].ToString();
                    tunjangan_jabatan = dr["tunjangan_jabatan"].ToString();

                    listBox1.Items.Add(kode_jabatan + " " + nama_jabatan + " " + tunjangan_jabatan);

                    //Menampilkan list view
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Kode Jabatan", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Nama Jabatan", 150, HorizontalAlignment.Left);
                    listView1.Columns.Add("Tunjangan", 150, HorizontalAlignment.Left);

                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect =false;

                    ListViewItem item1 = new ListViewItem(dr["kode_jabatan"].ToString(), 0);
                    item1.SubItems.Add(dr["nama_jabatan"].ToString());
                    item1.SubItems.Add(dr["tunjangan_jabatan"].ToString());
                        
                    listView1.Items.Add(item1);

                }*/

                koneksi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
