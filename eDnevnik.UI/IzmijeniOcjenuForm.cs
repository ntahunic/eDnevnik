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
    public partial class IzmijeniOcjenuForm : Form
    {
        private WebAPIHelper _casoviService = new WebAPIHelper("api/casovi");
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");
        public IzmijeniOcjenuForm(OcjenaVM ocjena)
        {
            InitializeComponent();

            HttpResponseMessage response = _prisustvoService.GetActionResponse("prisutniUcenici", ocjena.CasId.ToString());
            if (response.IsSuccessStatusCode)
            {
                ucenikInput.DataSource = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
                ucenikInput.ValueMember = "UcenikId";
                ucenikInput.DisplayMember = "ImePrezime";
            }


            ocjenaIdText.Text = ocjena.OcjenaId.ToString();
            ocjenaInput.Text = ocjena.OcjenaVrijednost.ToString();
            ucenikInput.SelectedValue = ocjena.UcenikId;
            casIdText.Text = ocjena.CasId.ToString();
        }

        private void sacuvajOcjenuButton_Click(object sender, EventArgs e)
        {
            int ocjenaId = Convert.ToInt32(ocjenaIdText.Text);
            int casId =  Convert.ToInt32(casIdText.Text);
            int ucenikId = (int)ucenikInput.SelectedValue;
            int ocjenaV = Convert.ToInt32(ocjenaInput.Text);

            Ocjena ocjena = new Ocjena
            {
                OcjenaId = ocjenaId,
                CasId = casId,
                UcenikId = ucenikId,
                OcjenaVrijednost = ocjenaV
            };

            HttpResponseMessage response = _ocjeneService.PutResponse(ocjena.OcjenaId, ocjena);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ocjena uspješno izmijenjena");
                Close();
            }
        }
    }
}
