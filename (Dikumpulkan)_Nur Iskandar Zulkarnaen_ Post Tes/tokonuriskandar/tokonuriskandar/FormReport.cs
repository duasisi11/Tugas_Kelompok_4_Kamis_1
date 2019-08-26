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

namespace tokonuriskandar
{
    public partial class FormReport : Form
    {
        private CrystalDecisions.CrystalReports.Engine.ReportClass rpt;

        public FormReport(ReportClass rpt)
        {
            InitializeComponent();
            InitializeReport(rpt);
        }

        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(75);

        }

        /*public FormReport(CrystalDecisions.CrystalReports.Engine.ReportClass rpt)
        {
            // TODO: Complete member initialization
            this.rpt = rpt;
        }*/
    }
}
