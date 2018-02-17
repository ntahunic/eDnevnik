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
using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using System.Text.RegularExpressions;

namespace eDnevnik.UI
{
    public partial class DodajCasForm : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _casoviService = new WebAPIHelper("api/casovi");
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");

        public DodajCasForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void ucitajUcenikeButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = _uceniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> users = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
                casoviGridView.DataSource = users;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }


        private void dodajIzostanakButton_Click(object sender, EventArgs e)
        {
            int casId = (int)casoviGridView.CurrentRow.Cells["CasId"].Value;
            int brojSati = (int)casoviGridView.CurrentRow.Cells["BrojSati"].Value;
            string predmet = casoviGridView.CurrentRow.Cells["Predmet"].Value.ToString();
            string datum = casoviGridView.CurrentRow.Cells["Datum"].Value.ToString();

            Form frm = new DodajIzostanakForm(predmet, datum, casId, brojSati);
            frm.Show();
        }


        private void dodajCasButton_Click(object sender, EventArgs e)
        {
            brojSatiInput.Focus();
            if (Validate())
            {
                Cas cas = new Cas
                {
                    Datum = datumCasaInput.Value.ToShortDateString(),
                    NastavnikId = Global.TrenutniKorisnik.KorisnikId,
                    PredmetId = Convert.ToInt32(predmetiInput.SelectedValue),
                    BrojSati = Convert.ToInt32(brojSatiInput.Text)
                };

                HttpResponseMessage response = _casoviService.PostResponse(cas);
                cas.CasId = response.Content.ReadAsAsync<CasVM>().Result.CasId;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Čas uspješno dodan");
                    response = _casoviService.GetResponse();
                    casoviGridView.DataSource = response.Content.ReadAsAsync<List<CasVM>>().Result.OrderByDescending(x => x.CasId).ToList();

                    response = _uceniciService.GetResponse();
                    List<UcenikVM> uceniciList = response.Content.ReadAsAsync<List<UcenikVM>>().Result.ToList();

                    if (response.IsSuccessStatusCode)
                    {
                        UceniciWrapper uceniciCas = new UceniciWrapper
                        {
                            Cas = cas,
                            Ucenici = uceniciList
                        };
                        _prisustvoService.PostResponse(uceniciCas);
                    }
                    brojSatiInput.Clear();
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
        }



        private void DodajCasForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetActionResponse("getPredmetiByNastavnik", Global.TrenutniKorisnik.KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }

            response = _casoviService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                casoviGridView.DataSource = response.Content.ReadAsAsync<List<CasVM>>().Result.OrderByDescending(x => x.CasId).ToList();
            }
        }










        /// <summary>
        /// //////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void casoviGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brojSatiInput_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void brojSatiInput_Validating_1(object sender, CancelEventArgs e)
        {
            
        }

        private void brojSatiInput_Validating_2(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d$");

            if (!regex.IsMatch(brojSatiInput.Text) || String.IsNullOrEmpty(brojSatiInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(brojSatiInput, Messages.brojSati_len);
            }
            else
            {
                errorProvider1.SetError(brojSatiInput, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = null;
            foreach (DataGridViewRow row in uceniciGridView.Rows)
            {
                Prisustvo prisustvo = new Prisustvo();
                prisustvo.PrisustvoId = (int)row.Cells["PrisustvoId"].Value;
                prisustvo.Prisutan = Convert.ToBoolean(row.Cells["Prisutan"].Value);
                prisustvo.Opravdano = Convert.ToBoolean(row.Cells["IsOpravdano"].Value);
                prisustvo.BrojSati = Convert.ToInt32(brojSatiReadOnly.Text);
                prisustvo.CasId = Convert.ToInt32(casIdTest.Text);
                prisustvo.UcenikId = (int)row.Cells["UcenikId"].Value;

                response = _prisustvoService.PutResponse(prisustvo);
            }
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Izostanci uspješno dodani");

                int casId = (int)casoviGridView.CurrentRow.Cells["CasId"].Value;
                response = _prisustvoService.GetActionResponse("prisutniUcenici", casId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    List<UcenikVM> ucenici = new List<UcenikVM>();
                    ucenici = response.Content.ReadAsAsync<List<UcenikVM>>().Result;

                    ucenikInput.DataSource = ucenici;
                    ucenikInput.ValueMember = "UcenikId";
                    ucenikInput.DisplayMember = "ImePrezime";
                }
            }
        }

        private void casoviGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            casIdTest.Text = e.Row.Cells["CasId"].Value.ToString();
            brojSatiReadOnly.Text = e.Row.Cells["BrojSati"].Value.ToString();
            predmetReadOnly.Text = e.Row.Cells["Predmet"].Value.ToString();
            datumReadOnly.Text = e.Row.Cells["Datum"].Value.ToString();

            HttpResponseMessage response = _prisustvoService.GetResponse(casIdTest.Text);
            if (response.IsSuccessStatusCode)
            {
                uceniciGridView.DataSource = response.Content.ReadAsAsync<List<PrisustvoVM>>().Result;
            }

            int casId = (int)e.Row.Cells["CasId"].Value;
            response = _prisustvoService.GetActionResponse("prisutniUcenici", casId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> ucenici = new List<UcenikVM>();
                ucenici = response.Content.ReadAsAsync<List<UcenikVM>>().Result;

                ucenikInput.DataSource = ucenici;
                ucenikInput.ValueMember = "UcenikId";
                ucenikInput.DisplayMember = "ImePrezime";
            }

            response = _ocjeneService.GetActionResponse("GetOcjeneByCas", casId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<object> ocjene = response.Content.ReadAsAsync<List<object>>().Result;

                ocjeneNaCasuGridView.DataSource = ocjene;
            }
        }

        private void preuzmiUcenikeButton_Click(object sender, EventArgs e)
        {
            int casId = (int)uceniciGridView.CurrentRow.Cells["CasId"].Value;
            HttpResponseMessage response = _prisustvoService.GetActionResponse("prisutniUcenici", casId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> ucenici = new List<UcenikVM>();
                ucenici = response.Content.ReadAsAsync<List<UcenikVM>>().Result;

                ucenikInput.DataSource = ucenici;
                ucenikInput.ValueMember = "UcenikId";
                ucenikInput.DisplayMember = "ImePrezime";
            }
        }

        private void sacuvajOcjenuButton_Click(object sender, EventArgs e)
        {
            ucenikInput.Focus();
            if (!Validate())
                return;
            ocjenaInput.Focus();
            if (!Validate())
                return;

            int casId = (int)casoviGridView.CurrentRow.Cells["CasId"].Value;
            int ucenikId = (int)ucenikInput.SelectedValue;
            int ocjenaV = Convert.ToInt32(ocjenaInput.Text);

            Ocjena ocjena = new Ocjena
            {
                CasId = casId,
                UcenikId = ucenikId,
                OcjenaVrijednost = ocjenaV
            };

            HttpResponseMessage response = _ocjeneService.PostResponse(ocjena);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ocjena uspješno dodana");
                response = _ocjeneService.GetActionResponse("GetOcjeneByCas", casId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    List<object> ocjene = response.Content.ReadAsAsync<List<object>>().Result;

                    ocjeneNaCasuGridView.DataSource = ocjene;
                }
            }
        }

        private void ocjenaInput_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d$");

            if (!regex.IsMatch(ocjenaInput.Text) || String.IsNullOrEmpty(ocjenaInput.Text) || Convert.ToInt32(ocjenaInput.Text) < 1 || Convert.ToInt32(ocjenaInput.Text) > 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(ocjenaInput, Messages.brojSati_len);
            }
            else
            {
                errorProvider1.SetError(ocjenaInput, null);
            }
        }

        private void ucenikInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ucenikInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(ucenikInput, Messages.lname_req);
            }
            else
            {
                errorProvider1.SetError(ucenikInput, null);
            }
        }
    }
}
