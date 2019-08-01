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

namespace MateriBrowseAndGet_01_08_2019
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
            da = new SqlDataAdapter("select * from tbl_buku", conn);

            da.Fill(ds, "tbl_buku");
            dt = ds.Tables["tbl_buku"];
            bm = BindingContext[dt];
            bm.Position = 0;
            txtJudul.DataBindings.Add("Text", dt, "Judul");
            txtPenerbit.DataBindings.Add("Text", dt, "Penerbit");

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
