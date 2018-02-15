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
            this.AutoValidate = AutoValidate.Disable;

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
            lozinkaPotvrdaInput.Text = ucenik.Password;
            lozinkaInput.Text = ucenik.Password;

            togglePasswordVisibility(false);
        }

        private void togglePasswordVisibility(bool visibile)
        {
            lozinkaInput.Visible = visibile;
            lozinkaPotvrdaInput.Visible = visibile;
            lozinkaInputLabel.Visible = visibile;
            lozinkaPotvrdaInputLabel.Visible = visibile;
        }

        private void dodajUcenikaButton_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;

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
                        Password = string.IsNullOrEmpty(ucenikIdText.Text) ? UIHelper.GetMd5Hash(lozinkaInput.Text) : lozinkaInput.Text,
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
                    togglePasswordVisibility(true);
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
            else
            {
                errorProvider1.SetError(imeInput, null);
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(prezimeInput, Messages.lname_req);
            }
            else
            {
                errorProvider1.SetError(prezimeInput, null);
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(korisnickoImeInput, Messages.username_len);
            }
            else
            {
                errorProvider1.SetError(korisnickoImeInput, null);
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
            else
            {
                errorProvider1.SetError(lozinkaInput, null);
            }
        }

        private void lozinkaPotvrdaInput_Validating(object sender, CancelEventArgs e)
        {
            if (lozinkaPotvrdaInput.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaPotvrdaInput, Messages.password_len);
            }
            else
            {
                errorProvider1.SetError(lozinkaPotvrdaInput, null);
            }
        }

        private void NoviUcenikForm_Load(object sender, EventArgs e)
        {

        }

        private void brojUDnevnikuInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void razredInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NoviUcenikForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = new DodajUcenikaForm();
            frm.Show();
        }
    }
}
