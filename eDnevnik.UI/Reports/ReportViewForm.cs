using eDnevnik.API.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.UI.Reports
{
    public partial class ReportViewForm : Form
    {
        public List<OcjenaVM> ocjene { get; set; }
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("OcjenaVM", ocjene);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
