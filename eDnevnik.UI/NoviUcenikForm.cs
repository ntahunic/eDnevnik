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
    public partial class NoviUcenikForm : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _razrediService = new WebAPIHelper("api/razredi");

        public NoviUcenikForm()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = _razrediService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                razredInput.DataSource = response.Content.ReadAsAsync<List<RazredVM>>().Result;
                razredInput.ValueMember = "RazredId";
                razredInput.DisplayMember = "RazredOdjeljenje";
            }
        }

        public NoviUcenikForm(int ucenikId)
        {
            InitializeComponent();

            HttpResponseMessage response = _razrediService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                razredInput.DataSource = response.Content.ReadAsAsync<List<RazredVM>>().Result;
                razredInput.ValueMember = "RazredId";
                razredInput.DisplayMember = "RazredOdjeljenje";
            }

            response = _uceniciService.GetResponse(ucenikId.ToString());
            UcenikVM ucenik = response.Content.ReadAsAsync<UcenikVM>().Result;

            ucenikIdText.Text = ucenik.UcenikId.ToString();
            imeInput.Text = ucenik.Ime;
            prezimeInput.Text = ucenik.Prezime;
            razredInput.Text = ucenik.RazredId.ToString();
            korisnickoImeInput.Text = ucenik.Username;
            lozinkaInput.Text = ucenik.Password;
            lozinkaPotvrdaInput.Text = ucenik.Password;
        }

        private void dodajUcenikaButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage response;

                Ucenik ucenik = new Ucenik
                {
                    RazredId = Convert.ToInt32(razredInput.SelectedValue),
                    Korisnik = new Korisnik
                    {
                        Ime = imeInput.Text,
                        Prezime = prezimeInput.Text,
                        Username = korisnickoImeInput.Text,
                        Password = UIHelper.GetMd5Hash(lozinkaInput.Text)
                    }
                };

                if (ucenikIdText.Text == "")
                    response = _uceniciService.PostResponse(ucenik);
                else
                {
                    ucenik.UcenikId = Convert.ToInt32(ucenikIdText.Text);
                    ucenik.Korisnik.KorisnikId = Convert.ToInt32(ucenikIdText.Text);
                    response = _uceniciService.PutResponse(ucenik.UcenikId, ucenik);
                }


                if (response.IsSuccessStatusCode)
                {
                    Close();
                    MessageBox.Show("Uspješno dodan/izmijenjen učenik.");
                }
            }
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(imeInput, Messages.fname_req);
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(prezimeInput, Messages.lname_req);
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(korisnickoImeInput, Messages.username_len);
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (lozinkaInput.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaInput, Messages.password_len);
            }
            else if (lozinkaInput.Text != lozinkaPotvrdaInput.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaInput, Messages.password_match);
            }
        }

        private void lozinkaPotvrdaInput_Validating(object sender, CancelEventArgs e)
        {
            if (lozinkaPotvrdaInput.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaPotvrdaInput, Messages.password_len);
            }
        }

        private void NoviUcenikForm_Load(object sender, EventArgs e)
        {

        }
    }
}
