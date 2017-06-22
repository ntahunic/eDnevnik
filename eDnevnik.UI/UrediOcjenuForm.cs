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
    public partial class UrediOcjenuForm : Form
    {
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public UrediOcjenuForm()
        {
            InitializeComponent();
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            int predmetId = (int) predmetiComboBox.SelectedValue;

            HttpResponseMessage response = _ocjeneService.GetActionResponse("GetOcjeneByPredmet", predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                ocjeneGridView.DataSource = response.Content.ReadAsAsync<List<OcjenaVM>>().Result.OrderByDescending(x => x.OcjenaId).ToList();
            }
        }

        private void UrediOcjenuForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetActionResponse("getPredmetiByNastavnik", Global.TrenutniKorisnik.KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                predmetiComboBox.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result; ;
                predmetiComboBox.ValueMember = "PredmetId";
                predmetiComboBox.DisplayMember = "Naziv";
            }
        }

        private void urediOcjenuButton_Click(object sender, EventArgs e)
        {
            int ocjenaId = (int)ocjeneGridView.CurrentRow.Cells[0].Value;

            HttpResponseMessage response = _ocjeneService.GetResponse(ocjenaId.ToString());
            OcjenaVM ocjena = response.Content.ReadAsAsync<OcjenaVM>().Result;

            Form frm = new IzmijeniOcjenuForm(ocjena);
            frm.Show();
            Close();
        }
    }
}
