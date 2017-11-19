using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace eDnevnik.UI.Reports
{
    public partial class ReportViewForm : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");

        public List<OcjenaVM> ocjene { get; set; }
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }
            Reports.ReportViewForm frm = new Reports.ReportViewForm();
        }

        private void generisiIzvjestajButton_Click(object sender, EventArgs e)
        {
            int predmetId = Convert.ToInt32(predmetiInput.SelectedValue);

            HttpResponseMessage response = _ocjeneService.GetActionResponse("GetOcjeneByPredmet", predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<OcjenaVM> ocjene = response.Content.ReadAsAsync<List<OcjenaVM>>().Result;
                this.ocjene = ocjene;
            }

            ReportDataSource rds = new ReportDataSource("OcjenaVM", ocjene);
            if (this.reportViewer1.LocalReport.DataSources.Count != 0)
                this.reportViewer1.LocalReport.DataSources.RemoveAt(0);

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
