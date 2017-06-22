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
    public partial class DodajObavijestForm : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _obavijestiService = new WebAPIHelper("api/obavijesti");

        public DodajObavijestForm()
        {
            InitializeComponent();
            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }
        }
        public DodajObavijestForm(ObavijestVM obavijest)
        {
            InitializeComponent();

            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }

            obavijestId.Text = obavijest.ObavijestId.ToString();
            predmetiInput.SelectedValue = obavijest.PredmetId;
            datumObavijestiInput.Text = obavijest.Datum;
            naslovObavijestiInput.Text = obavijest.Naslov;
            sadrzajObavijestiInput.Text = obavijest.Sadrzaj;
        }
        private void DodajObavijestForm_Load(object sender, EventArgs e)
        {
                 
        }

        private void dodajObavijestButton_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = new Obavijest
            {
                ObavijestId = Convert.ToInt32(obavijestId.Text),
                Datum = datumObavijestiInput.Text,
                Naslov = naslovObavijestiInput.Text,
                Sadrzaj = sadrzajObavijestiInput.Text,
                NastavnikId = Global.TrenutniKorisnik.KorisnikId,
                PredmetId = Convert.ToInt32(predmetiInput.SelectedValue)
            };
            if (obavijestId.Text != null)
            {
                HttpResponseMessage response = _obavijestiService.PutResponse(obavijest.ObavijestId, obavijest);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Obavijest uspješno izmijenjena");
                }
            }
            else
            {
                HttpResponseMessage response = _obavijestiService.PostResponse(obavijest);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Obavijest uspješno dodana");

                }
            }

            Close();
            Form frm = new PrikaziObavijestiForm();
            frm.Show();
        }
    }
}
