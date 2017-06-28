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
    public partial class DodajNastavnikaForm : Form
    {
        private WebAPIHelper _nastavniciService = new WebAPIHelper("api/nastavnici");
        private WebAPIHelper _obavijestiService = new WebAPIHelper("api/obavijesti");

        public DodajNastavnikaForm()
        {
            InitializeComponent();
        }

        private void DodajNastavnikaForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dodajNastavnikaButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;

            Nastavnik nastavnik = new Nastavnik
            {
                Titula = titulaInput.Text,
                Korisnik = new Korisnik
                {
                    Ime = imeInput.Text,
                    Prezime = prezimeInput.Text,
                    Username = korisnickoImeInput.Text,
                    Password = lozinkaInput.Text
                }
            };

            if (nastavnikIdText.Text == "")
                response = _nastavniciService.PostResponse(nastavnik);            
            else            
                response = _nastavniciService.PutResponse(nastavnik.NastavnikId, nastavnik);


            if (response.IsSuccessStatusCode)
            {
                DataBind();
                MessageBox.Show("Uspješno dodan/izmijenjen nastavnik.");
            }
        }

        private void DataBind()
        {
            HttpResponseMessage response = _nastavniciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                nastavniciGridView.DataSource = response.Content.ReadAsAsync<List<NastavnikVM>>().Result.ToList();
            }
        }

        private void nastavniciGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati korisnika?", "Brisanje korisnika", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int nastavnikId = (int)nastavniciGridView.CurrentRow.Cells["NastavnikId"].Value;
                    
                    HttpResponseMessage response = _nastavniciService.DeleteResponse(11);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Korisnik obrisan");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
        }

        private void izmijeniNastavnikaButton_Click(object sender, EventArgs e)
        {
            int nastavnikId = (int)nastavniciGridView.CurrentRow.Cells["NastavnikId"].Value;

            HttpResponseMessage response = _nastavniciService.GetResponse(nastavnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                NastavnikVM n = response.Content.ReadAsAsync<NastavnikVM>().Result;

                nastavnikIdText.Text = n.NastavnikId.ToString();
                imeInput.Text = n.Ime;
                prezimeInput.Text = n.Prezime;
                titulaInput.Text = n.Titula;
                korisnickoImeInput.Text = n.Username;
                lozinkaInput.Text = n.Password;
                lozinkaPotvrdaInput.Text = n.Password;
            }
        }
    }
}
