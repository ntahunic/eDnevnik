using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.UI
{
    public partial class ReportViewFormUcenici : Form
    {
        private WebAPIHelper _razrediService = new WebAPIHelper("api/razredi");
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");

        public List<UcenikVM> ucenici { get; set; }

        public ReportViewFormUcenici()
        {
            InitializeComponent();
        }

        private void ReportViewFormUcenici_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _razrediService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                razredInput.DataSource = response.Content.ReadAsAsync<List<RazredVM>>().Result;
                razredInput.ValueMember = "RazredId";
                razredInput.DisplayMember = "RazredOdjeljenje";
            }
        }

        private void generisiIzvjestajButton_Click(object sender, EventArgs e)
        {
            int razredId = Convert.ToInt32(razredInput.SelectedValue);

            HttpResponseMessage response = _uceniciService.GetActionResponse("GetUceniciByRazred", razredId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> ucenici = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
                this.ucenici = ucenici;
            }

            ReportDataSource rds = new ReportDataSource("UcenikVM", ucenici);
            if (this.reportViewer3.LocalReport.DataSources.Count != 0)
                this.reportViewer3.LocalReport.DataSources.RemoveAt(0);

            this.reportViewer3.LocalReport.DataSources.Add(rds);
            this.reportViewer3.RefreshReport();
        }
    }
}
