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
            this.AutoValidate = AutoValidate.Disable;

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
            datumObavijestiInput.Text =  obavijest.Datum;
            naslovObavijestiInput.Text = obavijest.Naslov;
            sadrzajObavijestiInput.Text = obavijest.Sadrzaj;
        }
        private void DodajObavijestForm_Load(object sender, EventArgs e)
        {
                 
        }

        private void dodajObavijestButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Obavijest obavijest = new Obavijest
                {
                    Datum = datumObavijestiInput.Value.ToShortDateString(),
                    Naslov = naslovObavijestiInput.Text,
                    Sadrzaj = sadrzajObavijestiInput.Text,
                    NastavnikId = Global.TrenutniKorisnik.KorisnikId,
                    PredmetId = Convert.ToInt32(predmetiInput.SelectedValue)
                };
                if (obavijestId.Text != "")
                {
                    obavijest.ObavijestId = Convert.ToInt32(obavijestId.Text);
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

        private void naslovObavijestiInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(naslovObavijestiInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(naslovObavijestiInput, "Molimo unesite naslov");
            }
        }

        private void sadrzajObavijestiInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sadrzajObavijestiInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(sadrzajObavijestiInput, "Molimo unesite sadrzaj");
            }
        }
    }
}
