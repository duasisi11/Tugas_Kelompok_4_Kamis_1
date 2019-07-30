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

namespace Data_Instansi
{
    public partial class Form1 : Form
    {
        string nip_nrp, nama_anggota, pangkat_gol, jenis_kelamin, agama, status;
        string id_kesatuan, nama_kesatuan, alamat;

        string nama_jabatan, tmt_jabatan, tunjangan_jabatan, nama_diklat, thn_lulus;

        SqlConnection koneksi;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=data_instansi;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi = new SqlConnection(getKoneksi());
                SqlCommand perintah;
                perintah = new SqlCommand("select nip_nrp, nama_anggota, pangkat_gol, jenis_kelamin, agama, status from anggota", koneksi);

                koneksi.Open();
                dr = perintah.ExecuteReader();
                while (dr.Read())
                {
                    nip_nrp = dr["nip_nrp"].ToString();
                    nama_anggota = dr["nama_anggota"].ToString();
                    pangkat_gol = dr["pangkat_gol"].ToString();
                    jenis_kelamin = dr["jenis_kelamin"].ToString();
                    agama = dr["agama"].ToString();
                    status = dr["status"].ToString();

                    listView1.Columns.Clear();
                    listView1.Columns.Add("NIP/NRP", 80, HorizontalAlignment.Left);
                    listView1.Columns.Add("nama anggota", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("pangkat/gol", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("jenis kelamin", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("agama", 50, HorizontalAlignment.Left);
                    listView1.Columns.Add("status", 100, HorizontalAlignment.Left);


                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect = false;

                    ListViewItem item1 = new ListViewItem(dr["nip_nrp"].ToString(), 0);
                    item1.SubItems.Add(dr["nama_anggota"].ToString());
                    item1.SubItems.Add(dr["pangkat_gol"].ToString());
                    item1.SubItems.Add(dr["jenis_kelamin"].ToString());
                    item1.SubItems.Add(dr["agama"].ToString());
                    item1.SubItems.Add(dr["status"].ToString());


                    listView1.Items.Add(item1);
                }
                koneksi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                koneksi = new SqlConnection(getKoneksi());
                SqlCommand perintah;
                perintah = new SqlCommand("select * from kesatuan", koneksi);

                koneksi.Open();
                dr = perintah.ExecuteReader();
                while (dr.Read())
                {
                    id_kesatuan = dr["id_kesatuan"].ToString();
                    nama_kesatuan  = dr["nama_kesatuan"].ToString();
                    alamat = dr["alamat"].ToString();
                    

                    listView2.Columns.Clear();
                    listView2.Columns.Add("id kesatuan", 80, HorizontalAlignment.Left);
                    listView2.Columns.Add("nama kesatuan", 120, HorizontalAlignment.Left);
                    listView2.Columns.Add("alamat", 100, HorizontalAlignment.Left);

                    listView2.GridLines = true;
                    listView2.FullRowSelect = true;
                    listView2.View = View.Details;
                    listView2.MultiSelect = false;

                    ListViewItem item2 = new ListViewItem(dr["id_kesatuan"].ToString(), 0);
                    item2.SubItems.Add(dr["nama_kesatuan"].ToString());
                    item2.SubItems.Add(dr["alamat"].ToString());
                    


                    listView2.Items.Add(item2);
                }
                koneksi.Close();
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi = new SqlConnection(getKoneksi());
                SqlCommand perintah;
                perintah = new SqlCommand("select a.nip_nrp, a.nama_anggota, a.pangkat_gol, j.nama_jabatan, k.nama_kesatuan, d.nama_diklat, d.thn_lulus, k.nama_kesatuan from anggota a, jabatan j, kesatuan k, diklat d where a.id_jabatan = j.id_jabatan and a.id_kesatuan =  k.id_kesatuan and a.id_diklat = d.id_diklat", koneksi);

                koneksi.Open();
                dr = perintah.ExecuteReader();
                while (dr.Read())
                {
                    nip_nrp = dr["nip_nrp"].ToString();
                    nama_anggota = dr["nama_anggota"].ToString();
                    pangkat_gol = dr["pangkat_gol"].ToString();
                    nama_jabatan = dr["nama_jabatan"].ToString();
                    nama_kesatuan = dr["nama_kesatuan"].ToString();
                    nama_diklat = dr["nama_diklat"].ToString();
                    thn_lulus = dr["thn_lulus"].ToString();
                    nama_kesatuan = dr["nama_kesatuan"].ToString();
                    


                    listView3.Columns.Clear();
                    listView3.Columns.Add("id kesatuan", 80, HorizontalAlignment.Left);
                    listView3.Columns.Add("nama kesatuan", 120, HorizontalAlignment.Left);
                    listView3.Columns.Add("alamat", 100, HorizontalAlignment.Left);

                    listView3.GridLines = true;
                    listView3.FullRowSelect = true;
                    listView3.View = View.Details;
                    listView3.MultiSelect = false;

                    ListViewItem item3 = new ListViewItem(dr["nip_nrp"].ToString(), 0);
                    item3.SubItems.Add(dr["nama_anggota"].ToString());
                    item3.SubItems.Add(dr["pangkat_gol"].ToString());
                    item3.SubItems.Add(dr["nama_jabatan"].ToString());
                    item3.SubItems.Add(dr["nama_kesatuan"].ToString());
                    item3.SubItems.Add(dr["nama_diklat"].ToString());
                    item3.SubItems.Add(dr["thn_lulus"].ToString());
                    item3.SubItems.Add(dr["nama_kesatuan"].ToString());

                    listView3.Items.Add(item3);
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
