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

namespace eDnevnik.UI
{
    public partial class DodajCasForm : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _casoviService = new WebAPIHelper("api/casovi");
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");


        public DodajCasForm()
        {
            InitializeComponent();
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
            int casId = (int)casoviGridView.CurrentRow.Cells[0].Value;
            int brojSati = (int)casoviGridView.CurrentRow.Cells["BrojSati"].Value;
            string predmet = casoviGridView.CurrentRow.Cells["Predmet"].Value.ToString();
            string datum = casoviGridView.CurrentRow.Cells["Datum"].Value.ToString();

            Form frm = new DodajIzostanakForm(predmet, datum, casId, brojSati);
            frm.Show();
        }
        

        private void dodajCasButton_Click(object sender, EventArgs e)
        {
            Cas cas = new Cas
            {
                Datum = datumCasaInput.Text,
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
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }



        private void DodajCasForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetResponse();
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
    }
}
