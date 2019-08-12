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

namespace Concurrency_Data_02_08_2019
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection;
        string ConnectionString;
        SqlCommand InputData;

        public Form1()
        {
            InitializeComponent();
     
            ConnectionString = @"Server = .\;" +
             "Database = db_library; integrated security = true";
            SqlConnection = new SqlConnection(ConnectionString);
            //ConnectionString = "Data Source=WINDOWS10;Initial Catalog=db_library;Integrated Security=True";
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String durasi = tbDurasi.Text;
            String id_anggota = tbIDAngg.Text;
            String id_buku = tbIDBuku.Text;
            String kondisi = tbKondisi.Text;

            try
            {
                InputData = new SqlCommand("INSERT INTO tbl_peminjaman VALUES (getdate(),getdate()+"+durasi+",'"+kondisi+"',"+id_anggota+","+id_buku+")", SqlConnection);
                //InputData.CommandType = CommandType.Text;
                SqlConnection.Open();
                InputData.ExecuteNonQuery();
                SqlConnection.Close();
                MessageBox.Show("Insert Berhasil");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
