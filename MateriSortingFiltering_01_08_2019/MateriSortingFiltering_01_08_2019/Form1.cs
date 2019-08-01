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


namespace MateriSortingFiltering_01_08_2019
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataReader dr;
        String NamaTabel, NamaKolom, NamaKolomCari, JenisSort, Kriteria;

        public Form1()
        {
            InitializeComponent();
        }
        //fungsi koneksi
        private static string getKoneksi()
        {
            return "Data Source=WINDOWS10;Initial Catalog=db_library;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = getKoneksi();

            try
            {
                String sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_buku'";
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NamaTabel = dr[0].ToString();
                    cbCari.Items.Add(NamaTabel);
                    cbUrut.Items.Add(NamaTabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void btnSeleksi_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dr;

                conn.ConnectionString = getKoneksi();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();

                da.SelectCommand = new SqlCommand("select * from tbl_buku", conn);

                DataSet ds = new DataSet();
                da.Fill(ds, "tbl_buku");
                dt = ds.Tables["tbl_buku"];

                NamaKolom = cbCari.Text.Trim();
                Kriteria = tbKriteria.Text.Trim();

                DataView dvFilter = new DataView(dt);
                if (Kriteria != "")
                {
                    dvFilter.RowFilter = NamaKolom + " LIKE '%" + Kriteria + "%'";
                    dvFilter.RowStateFilter = DataViewRowState.CurrentRows;
                }

                dvFilter.RowFilter = NamaKolom + " LIKE '%" + Kriteria + "%'";
                dvFilter.RowStateFilter = DataViewRowState.CurrentRows;
                dataGridView1.DataSource = dvFilter;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            conn.Close();
        }

        private void btnUrutkan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                conn.ConnectionString = getKoneksi();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();

                Kriteria = tbKriteria.Text.Trim();
                NamaKolomCari = cbCari.Text.Trim();    
     
                if(Kriteria == "")
                {
                    da.SelectCommand = new SqlCommand("select * from tbl_buku", conn);
                }
                else
                {
                    da.SelectCommand = new 
                        SqlCommand("select * from tbl_buku where "+NamaKolomCari+" LIKE '%"+Kriteria+"%'", conn);

                }

                DataSet ds = new DataSet();
                da.Fill(ds, "tbL_buku");
                dt = ds.Tables["tbl_buku"];

                NamaKolom = cbUrut.Text.Trim();
                JenisSort = cbJenis.Text.Trim();

                DataView dvSort = new DataView(dt);
                dvSort.Sort = NamaKolom + " " + JenisSort;

                dataGridView1.DataSource = dvSort;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        
        

    }
}
