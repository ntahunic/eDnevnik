using eDnevnik.API.Models;
using eDnevnik.UI.Util;
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

    public partial class OcjeneIzPredmetaForm : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");

        public OcjeneIzPredmetaForm()
        {
            InitializeComponent();
        }

        private void OcjeneIzPredmetaForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }
        }

        private void generisiIzvjestajButton_Click(object sender, EventArgs e)
        {
            int predmetId = Convert.ToInt32(predmetiInput.SelectedValue);

            HttpResponseMessage response = _ocjeneService.GetActionResponse("GetOcjeneByPredmet", predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<OcjenaVM> ocjene = response.Content.ReadAsAsync<List<OcjenaVM>>().Result;

                Reports.ReportViewForm frm = new Reports.ReportViewForm();
                frm.ocjene = ocjene;
                frm.Show();
            }
        }
    }
}
