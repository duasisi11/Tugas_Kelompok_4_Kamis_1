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

namespace Tugas_01_08_2019
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        BindingManagerBase bm;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=db_library;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = getKoneksi();
            da = new SqlDataAdapter("select a.id_anggota, a.nama, a.alamat, p.id_peminjaman, p.tgl_pinjam, p.tgl_kembali, p.keterangan, dp.qty, b.judul, b.penerbit, k.nama_kategori, kbl.tgl AS 'Tanggal Kembali', kbl.denda from tbl_anggota a JOIN tbl_peminjaman p ON a.id_anggota = p.id_anggota JOIN tbl_pengembalian kbl ON a.id_anggota =  kbl.id_anggota JOIN tbl_det_peminjaman dp ON p.id_peminjaman=dp.id_peminjaman JOIN tbl_buku b ON dp.id_buku = b.id_buku JOIN tbl_kategori k ON b.id_kategori = k.id_kategori", conn);

            da.Fill(ds, "tbl_anggota, tbl_buku");
            dt = ds.Tables["tbl_anggota, tbl_buku"];

            bm = BindingContext[dt];
            bm.Position = 0;
            txtNama.DataBindings.Add("Text", dt, "Nama");
            txtAlamat.DataBindings.Add("Text", dt, "Alamat");
            txtJudul.DataBindings.Add("Text", dt, "Judul");

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bm.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
        }

      
    }
}
