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
    public partial class pegawai : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        DataTable dt;

        public pegawai()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return @"Server = .\;" + "Database = kepegawaian; integrated security = true";
            //return "Data Source=WINDOWS10;Initial Catalog=kepegawaian;Integrated Security=True";
        }

        private void pegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kepegawaianDataSet.pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.kepegawaianDataSet.pegawai);

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();

            conn.Open();
            cmd = new SqlCommand("tampilanPegawai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();

            conn.Open();
            cmd = new SqlCommand("insertPegawai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nip", SqlDbType.Char).Value = tbNIP.Text.Trim();
            cmd.Parameters.AddWithValue("nama", SqlDbType.VarChar).Value = tbNama.Text.Trim();
            cmd.Parameters.AddWithValue("alamat", SqlDbType.VarChar).Value = tbAlamat.Text.Trim();
            cmd.Parameters.AddWithValue("kota", SqlDbType.VarChar).Value = tbKota.Text.Trim();
            cmd.Parameters.AddWithValue("tempat_lhr", SqlDbType.VarChar).Value = tbTmpLhr.Text.Trim();
            cmd.Parameters.AddWithValue("tgl_lhr", SqlDbType.SmallDateTime).Value = dtpTglLhr.Value;
            cmd.Parameters.AddWithValue("pendidikan", SqlDbType.Char).Value = tbPend.Text.Trim();
            cmd.Parameters.AddWithValue("jns_kelamin", SqlDbType.Char).Value = tbjklmn.Text.Trim();
            cmd.Parameters.AddWithValue("agama", SqlDbType.Char).Value = tbAgama.Text.Trim();
            cmd.Parameters.AddWithValue("kode_gapok", SqlDbType.Char).Value = tbGapok.Text.Trim();
            cmd.Parameters.AddWithValue("status", SqlDbType.VarChar).Value = tbStatus.Text.Trim();
            cmd.Parameters.AddWithValue("jml_anak", SqlDbType.Int).Value = tbJmlAnak.Text.Trim();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Pegawai Berhasil Ditambah");
            conn.Close();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();
            conn.Open();

            cmd = new SqlCommand("updatePegawai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nip", SqlDbType.Char).Value = tbNIP.Text.Trim();
            cmd.Parameters.AddWithValue("nama", SqlDbType.VarChar).Value = tbNama.Text.Trim();
            cmd.Parameters.AddWithValue("alamat", SqlDbType.VarChar).Value = tbAlamat.Text.Trim();
            cmd.Parameters.AddWithValue("kota", SqlDbType.VarChar).Value = tbKota.Text.Trim();
            cmd.Parameters.AddWithValue("tempat_lhr", SqlDbType.VarChar).Value = tbTmpLhr.Text.Trim();
            cmd.Parameters.AddWithValue("tgl_lhr", SqlDbType.SmallDateTime).Value = dtpTglLhr.Value;
            cmd.Parameters.AddWithValue("pendidikan", SqlDbType.Char).Value = tbPend.Text.Trim();
            cmd.Parameters.AddWithValue("jns_kelamin", SqlDbType.Char).Value = tbjklmn.Text.Trim();
            cmd.Parameters.AddWithValue("agama", SqlDbType.Char).Value = tbAgama.Text.Trim();
            cmd.Parameters.AddWithValue("kode_gapok", SqlDbType.Char).Value = tbGapok.Text.Trim();
            cmd.Parameters.AddWithValue("status", SqlDbType.VarChar).Value = tbStatus.Text.Trim();
            cmd.Parameters.AddWithValue("jml_anak", SqlDbType.Int).Value = tbJmlAnak.Text.Trim();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Pegawai Berhasil Diubah.!");
            conn.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();
            conn.Open();

            SqlCommand cmd = new SqlCommand("deletePegawai", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nip", SqlDbType.Char).Value = tbNIP.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Pegawai Berhasil Dihapus.!!!");
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNIP.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            tbAlamat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            tbKota.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            tbTmpLhr.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            dtpTglLhr.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            tbPend.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            tbjklmn.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            tbAgama.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            tbGapok.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
            tbStatus.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString();
            tbJmlAnak.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString();
        }

        
    }
}
