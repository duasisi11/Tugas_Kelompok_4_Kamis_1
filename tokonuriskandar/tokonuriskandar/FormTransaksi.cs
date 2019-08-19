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

namespace tokonuriskandar
{
    public partial class FormTransaksi : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlDataReader dr;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        static string GetConnectionStrings()
        {
            return @"Server=.\;" + "Database = tokonuriskandar; Integrated Security = true";
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
    }
}
