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
            else {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void dodajIzostanakButton_Click(object sender, EventArgs e)
        {
            int casId = (int) casoviGridView.CurrentRow.Cells[0].Value;
            Form frm = new DodajIzostanakForm(predmetiInput.Text, datumCasaInput.Text, casId);
            
            frm.Show();
        }

        private void dodajCasButton_Click(object sender, EventArgs e)
        {
            Cas cas = new Cas();
            cas.Datum = datumCasaInput.Text;
            cas.NastavnikId = Global.TrenutniKorisnik.Nastavnik.NastavnikId;
            cas.PredmetId = Convert.ToInt32(predmetiInput.SelectedValue);
            cas.BrojSati = Convert.ToInt32(brojSatiInput.Text);

            HttpResponseMessage response = _casoviService.PostResponse(cas);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjesno dodavanje");
                response = _casoviService.GetResponse();
                casoviGridView.DataSource = response.Content.ReadAsAsync<List<CasVM>>().Result;
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
                casoviGridView.DataSource = response.Content.ReadAsAsync<List<CasVM>>().Result;
                //casoviGridView.Sort(casoviGridView.Columns["Datum"], ListSortDirection.Descending);

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
