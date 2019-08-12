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

namespace CRUD_procedure_05_08_2019
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection koneksi()
        {
            return new SqlConnection("Data Source=WINDOWS10;Initial Catalog=kepegawaian;Integrated Security=True");
        }

        private void init()
        {
            tbKode.Text = "";
            tbNama.Text = "";
            tbTunjangan.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'kepegawaianDataSet1.jabatan' table. You can move, or remove it, as needed.
                this.jabatanTableAdapter.Fill(this.kepegawaianDataSet1.jabatan);
          
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            conn = koneksi();
            conn.Open();

            //Cek apa data sudah ada
            SqlCommand cmd = new SqlCommand("tampilanjabatan", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            conn = koneksi();
            conn.Open();

            //Cek apa data sudah ada
            SqlCommand cmd = new SqlCommand("insertDatajab", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Kode_Jabatan", SqlDbType.Char).Value = tbKode.Text.Trim();
            cmd.Parameters.AddWithValue("@Nama_Jabatan", SqlDbType.VarChar).Value = tbNama.Text.Trim();
            cmd.Parameters.AddWithValue("@Tunjangan_Jabatan", SqlDbType.Int).Value = tbTunjangan.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ditambah");
            conn.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn = koneksi();
            conn.Open();

            //Cek apa data sudah ada
            SqlCommand cmd = new SqlCommand("updatejabatan", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Kode_Jabatan", SqlDbType.Char).Value = tbKode.Text.Trim();
            cmd.Parameters.AddWithValue("@Nama_Jabatan", SqlDbType.VarChar).Value = tbNama.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diubah");
            conn.Close();
        }

       

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn = koneksi();
            conn.Open();

            //Cek apa data sudah ada
            SqlCommand cmd = new SqlCommand("deletejabatan", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Kode_Jabatan", SqlDbType.Char).Value = tbKode.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dihapus");
            conn.Close();
        }

        
    }
}
