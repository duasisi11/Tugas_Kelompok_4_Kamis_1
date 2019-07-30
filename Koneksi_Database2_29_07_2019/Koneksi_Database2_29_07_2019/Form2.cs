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

namespace Koneksi_Database2_29_07_2019
{
    public partial class Form2 : Form
    {
        SqlConnection koneksi;
        SqlDataReader dr;

        string kode_kelas, status_kelas, guru;
        public Form2()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=siswa;User ID=nuriskandar;Password=1122";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi = new SqlConnection(getKoneksi());
                
                SqlCommand perintah;
                perintah = new SqlCommand("select k.kode_kelas, k.status AS status_kelas, g.nama as guru from kelas k, guru g where k.kode_guru = g.kode_guru", koneksi);

                koneksi.Open();
                dr = perintah.ExecuteReader();
                while (dr.Read())
                {
                    kode_kelas = dr["kode_kelas"].ToString();
                    status_kelas = dr["status_kelas"].ToString();
                    guru = dr["guru"].ToString();

                    //menampilkan listBox
                    listBox1.Items.Add(kode_kelas + " " + status_kelas + " " + guru); 

                    //menampilkan listView
                    listView1.Columns.Clear();
                    listView1.Columns.Add("Kode Kelas", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Status Kelas", 100, HorizontalAlignment.Left);
                    listView1.Columns.Add("Guru", 100, HorizontalAlignment.Left);

                    listView1.GridLines = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.MultiSelect = false;

                    ListViewItem item1 = new ListViewItem(dr["kode_kelas"].ToString(), 0);
                    item1.SubItems.Add(dr["status_kelas"].ToString());
                    item1.SubItems.Add(dr["guru"].ToString());

                    listView1.Items.Add(item1);
                    
                }

                koneksi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
        }
    }
}
