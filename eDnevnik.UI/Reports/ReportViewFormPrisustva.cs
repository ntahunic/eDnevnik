using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace eDnevnik.UI.Reports
{

    public partial class ReportViewFormPrisustva : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");

        public List<PrisustvoVM> prisustva { get; set; }

        public ReportViewFormPrisustva()
        {
            InitializeComponent();
        }

        private void ReportViewFormPrisustva_Load(object sender, EventArgs e)
        {
            Reports.ReportViewForm frm = new Reports.ReportViewForm();

            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<PredmetVM> p = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.DataSource = p;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }

        }

        private void generisiIzvjestajButton_Click(object sender, EventArgs e)
        {
            string predmetId = predmetiInput.SelectedValue.ToString();

            HttpResponseMessage response = _prisustvoService.GetActionResponse("GetPrisustvoByPredmetAndDatum", predmetId);
            if (response.IsSuccessStatusCode)
            {
                List<PrisustvoVM> prisustvo = response.Content.ReadAsAsync<List<PrisustvoVM>>().Result;

                Reports.ReportViewFormPrisustva frm = new Reports.ReportViewFormPrisustva();
                this.prisustva = prisustvo;
            }


            ReportDataSource rds = new ReportDataSource("PrisustvoVM", prisustva);
            if (this.reportViewer2.LocalReport.DataSources.Count != 0)
                this.reportViewer2.LocalReport.DataSources.RemoveAt(0);

            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
