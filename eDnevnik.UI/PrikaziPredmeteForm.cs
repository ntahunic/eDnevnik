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
    public partial class PrikaziPredmeteForm : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public PrikaziPredmeteForm()
        {
            InitializeComponent();
        }

        private void PrikaziPredmeteForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetActionResponse("getPredmetiByNastavnik", Global.TrenutniKorisnik.KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                predmetiGridView.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result.ToList();

            }
        }
    }
}
