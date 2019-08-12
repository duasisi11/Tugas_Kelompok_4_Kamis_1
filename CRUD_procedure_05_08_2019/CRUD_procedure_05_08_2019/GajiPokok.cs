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
    public partial class GajiPokok : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        DataTable dt;
        SqlDataReader dr1;
        SqlDataReader dr2;

        public GajiPokok()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return @"Server = .\;" + "Database = kepegawaian; integrated security = true";
            //return "Data Source=WINDOWS10;Initial Catalog=kepegawaian;Integrated Security=True";
        }

        private void GajiPokok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kepegawaianDataSet.gaji_pokok' table. You can move, or remove it, as needed.
            this.gaji_pokokTableAdapter.Fill(this.kepegawaianDataSet.gaji_pokok);

            conn.ConnectionString = getKoneksi();

            conn.Open();
            String sql1 = "select Kode_Jabatan from schkaryawan.jabatan";
            cmd1 = new SqlCommand(sql1, conn);
            
            dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                String Kode_Jabatan = dr1[0].ToString();
                cbKdJab.Items.Add(Kode_Jabatan);
            }
            conn.Close();

            conn.Open();
            String sql2 = "select Kode_Golongan from schkaryawan.golongan";
            cmd2 = new SqlCommand(sql2, conn);

            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                String Kode_Golongan = dr2[0].ToString();
                cbKdGol.Items.Add(Kode_Golongan);
            }
            conn.Close();

            
            

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();

            conn.Open();
            cmd = new SqlCommand("tampilanGajiPokok", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKdGapok.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cbKdJab.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cbKdGol.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            tbGapok.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();

            conn.Open();
            cmd = new SqlCommand("insertGajiPokok", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Kode_Gapok", SqlDbType.Char).Value = tbKdGapok.Text.Trim();
            cmd.Parameters.AddWithValue("Kode_Jabatan", SqlDbType.Char).Value = cbKdJab.Text.Trim();
            cmd.Parameters.AddWithValue("Kode_Golongan", SqlDbType.Int).Value = cbKdGol.Text.Trim();
            cmd.Parameters.AddWithValue("gaji_pokok", SqlDbType.Money).Value = tbGapok.Text.Trim();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Gaji Pokok Berhasil Ditambah");
            conn.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();

            conn.Open();
            cmd = new SqlCommand("updateGajiPokok", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Kode_Gapok", SqlDbType.Char).Value = tbKdGapok.Text.Trim();
            cmd.Parameters.AddWithValue("Kode_Jabatan", SqlDbType.Char).Value = cbKdJab.Text.Trim();
            cmd.Parameters.AddWithValue("Kode_Golongan", SqlDbType.Int).Value = cbKdGol.Text.Trim();
            cmd.Parameters.AddWithValue("gaji_pokok", SqlDbType.Money).Value = tbGapok.Text.Trim();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Gaji Pokok Berhasil Diubah.!");
            conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();
            conn.Open();

            SqlCommand cmd = new SqlCommand("deleteGajiPokok", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Kode_Gapok", SqlDbType.Char).Value = tbKdGapok.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Gaji Pokok Berhasil Dihapus.!!!");
            conn.Close();
        }
    }
}
