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
using System.Configuration

namespace SqlDataAdapter_DisconnectedEnvironment_31_07_2019
{
    public partial class Form1 : Form
    {
        SqlDataReader dr;
        SqlConnection koneksi = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        static string GetConnectionString()
        {
            string aturkoneksi = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnnectionString["BasisData"];

            if(settings != null)
                aturkoneksi = settings.ConnectionString;

            return aturkoneksi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi.ConnectionString = GetConnectionString();
        }
    }
}
