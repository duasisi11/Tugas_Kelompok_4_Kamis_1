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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        DataView dv;

        SqlDataReader dr;
        String index;

        public Form3()
        {
            InitializeComponent();
        }

        private static string getConn()
        {
            return @"Server=.\;" + "Database=db_library; Integrated Security = true";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_libraryDataSet.tbl_anggota' table. You can move, or remove it, as needed.
            //this.tbl_anggotaTableAdapter.Fill(this.db_libraryDataSet.tbl_anggota);
            conn.ConnectionString = getConn();
            try
            {
                String sql = "select distinct nama from tbl_anggota";
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_nama.Items.Add(dr["nama"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_nama.DataBindings.Clear();
            tb_alamat.DataBindings.Clear();

            index = cb_nama.Text.Trim();
            this.cari(index);
        }

        public void cari(String i)
        {
            conn.ConnectionString = getConn();
            try
            {
                String sql = "select * from tbl_anggota where nama='" + i + "'";
                da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(ds, "tbl_anggota");
                dt = ds.Tables["tbl_anggota"];
                bm = BindingContext[dt];
                bm.Position = 0;

                dv = new DataView(dt);
                dataGridView1.DataSource = dv;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.DataSource = dt;

                //Console.WriteLine(dataGridView1.Rows.Count);
                //Console.WriteLine(bm.Count);

                dataGridView1.CurrentCell = dataGridView1.Rows[bm.Count - 1].Cells[0];

                //cb_nama.DataBindings.Add("Text", dt, "Nama");
                tb_alamat.DataBindings.Add("Text", dt, "Alamat");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }
    }
}
