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

namespace Report_Buku_09_08_2019
{
    public partial class TampilanLaporan : Form
    {
        private CrystalDecisions.CrystalReports.Engine.ReportClass rpt;

        public TampilanLaporan(ReportClass rpt)
        {
            InitializeComponent();
            InitializeReport(rpt);
        }
        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(75);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*public TampilanLaporan()
        {
            InitializeComponent();
           
        }

        public TampilanLaporan(ReportClass rpt)
        {
            InitializeComponent();
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(75);
        }*/


        /*
        private void TampilanLaporan(ReportClass rpt)
        {
            InitializeComponent();
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(75);
        }
        
        public TampilanLaporan(CrystalDecisions.CrystalReports.Engine.ReportClass rpt)
        {
            // TODO: Complete member initialization
            //this.rpt = rpt;
        }
         */
    }
}
