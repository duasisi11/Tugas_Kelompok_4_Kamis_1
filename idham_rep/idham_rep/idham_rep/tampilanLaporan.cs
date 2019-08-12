using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace idham_rep
{
    public partial class tampilanLaporan : Form
    {
        public tampilanLaporan(ReportClass rpt)
        {
            InitializeComponent();
            InitializeReport(rpt);
        }
        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(75);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tampilanLaporan_Load(object sender, EventArgs e)
        {

        }
    }
}
