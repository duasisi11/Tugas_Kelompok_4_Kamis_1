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

namespace MenampilkanData_06_08_2019
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds = new DataSet();
        //DataSet ds;
        BindingManagerBase bm;
        DataView dv;

        SqlDataReader dr;
        String index;
        
        public Form1()
        {
            InitializeComponent();
        }

        private static string getConn()
        {
            return @"Server= .\;" + "Database=db_library; Integrated Security = true";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_libraryDataSet.tbl_buku' table. You can move, or remove it, as needed.
            //this.tbl_bukuTableAdapter.Fill(this.db_libraryDataSet.tbl_buku);
            conn.ConnectionString = getConn();
            try
            {
                String sql = "SELECT DISTINCT judul from tbl_buku";
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbJudul.Items.Add(dr["judul"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void cbJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbISBN.DataBindings.Clear();
            tbPenulis.DataBindings.Clear();
            tbKategori.DataBindings.Clear();

            index = cbJudul.Text.Trim();
            this.cari(index);
        }

        public void cari(String i)
        {
            conn.ConnectionString = getConn();
            try
            {
                //ds = new DataSet();
                String sql = "Select * from tbl_buku where judul='" + i + "'";
                da = new SqlDataAdapter(sql, conn); //agar data dapat diolah

                conn.Open();

                da.Fill(ds, "tbl_buku");
                dt = ds.Tables["tbl_buku"];
                bm = BindingContext[dt];
                bm.Position = 0;

                dv = new DataView(dt); //data yang akan ditampilkan
                dataGridView1.DataSource = dv;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                //Console.WriteLine(dt.Rows.Count); //ditampilkan di output

                dataGridView1.DataSource = dt;
                Console.WriteLine(dataGridView1.Rows.Count); //ditampilkan di output
                Console.WriteLine(bm.Count); //ditampilkan di output

                //dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0];
                dataGridView1.CurrentCell = dataGridView1.Rows[bm.Count - 1].Cells[0];

               tbISBN.DataBindings.Add("Text", dt, "ISBN");
               tbPenulis.DataBindings.Add("Text", dt, "Pengarang");
               tbKategori.DataBindings.Add("Text", dt, "id_kategori").ToString(); 

               /* Console.WriteLine(tbISBN.DataBindings.Count); //ditampilkan di output
                if (tbISBN.DataBindings.Count > 0)
                {
                    tbISBN.DataBindings.Clear();
                    tbPenulis.DataBindings.Clear();
                    tbKategori.DataBindings.Clear();
                }
                else
                {
                   tbISBN.DataBindings.Add("Text", dt, "ISBN");
                   tbPenulis.DataBindings.Add("Text", dt, "Pengarang");
                   tbKategori.DataBindings.Add("Text", dt, "id_kategori").ToString();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 Reports = new Form2();
            Reports.Show();
            this.Hide();
        }
    }
}
