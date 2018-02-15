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
            this.AutoValidate = AutoValidate.Disable;
        }

        private void DodajNastavnikaForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            HttpResponseMessage response = _nastavniciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                nastavniciGridView.DataSource = response.Content.ReadAsAsync<List<NastavnikVM>>().Result.ToList();
            }
        }

        private void dodajNastavnikaButton_Click_1(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;

            if (this.ValidateChildren())
            {
                HttpResponseMessage response;

                Nastavnik nastavnik = new Nastavnik
                {
                    Titula = titulaInput.Text,
                    Telefon = telefonInput.Text,
                    Korisnik = new Korisnik
                    {
                        Ime = imeInput.Text,
                        Prezime = prezimeInput.Text,
                        Username = korisnickoImeInput.Text,
                        Password = string.IsNullOrEmpty(nastavnikIdText.Text) ? UIHelper.GetMd5Hash(lozinkaInput.Text) : lozinkaInput.Text,
                        Aktivan = true
                    }
                };

                if (nastavnikIdText.Text == "")
                    response = _nastavniciService.PostResponse(nastavnik);
                else
                {
                    nastavnik.Korisnik.KorisnikId = Convert.ToInt32(nastavnikIdText.Text);
                    nastavnik.NastavnikId = Convert.ToInt32(nastavnikIdText.Text);
                    response = _nastavniciService.PutActionResponse("putNastavnik", nastavnik.NastavnikId, nastavnik);
                }

                if (response.IsSuccessStatusCode)
                {
                    DataBind();
                    MessageBox.Show("Uspješno dodan/izmijenjen nastavnik.");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    ToggleVisibility(true);
                    DataBind();
                }
            }
            
        }

        private void izmijeniNastavnikaButton_Click_1(object sender, EventArgs e)
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
                telefonInput.Text = n.Telefon;
                lozinkaInput.Text = n.Password;
                lozinkaPotvrdaInput.Text = n.Password;
                ToggleVisibility(false);
            }
        }

        private void ToggleVisibility(bool visible)
        {
            lozinkaInput.Visible = visible;
            lozinkaPotvrdaInput.Visible = visible;
            lozinkaPotvrdaInputLabel.Visible = visible;
            lozinkaInputLabel.Visible = visible;
        }

        //private void nastavniciGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    nastavniciGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

        //    var senderGrid = (DataGridView)sender;

        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxCell && e.RowIndex >= 0)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati nastavnika?", "Brisanje nastavnika", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            int nastavnikId = (int)nastavniciGridView.CurrentRow.Cells["NastavnikId"].Value;

        //            HttpResponseMessage response = _nastavniciService.DeleteActionResponse("deleteNastavnik", nastavnikId.ToString());
        //            if (response.IsSuccessStatusCode)
        //            {
        //                MessageBox.Show("Nastavnik obrisan");
        //                DataBind();
        //            }
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {

        //        }
        //    }
        //}

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

        private void titulaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(titulaInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(titulaInput, "Titula je obavezna.");
            }
            else
            {
                errorProvider1.SetError(titulaInput, null);
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

        private void telefonInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nastavniciGridView_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == nastavniciGridView.Columns["Aktivan"]?.Index && e.RowIndex != -1)
            {
                int nastavnikId = (int)nastavniciGridView.CurrentRow.Cells["NastavnikId"].Value;

                HttpResponseMessage response = _nastavniciService.DeleteActionResponse("deleteNastavnik", nastavnikId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Izmjena aktivnosti uspjesna.");
                }
            }
        }

        private void nastavniciGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nastavniciGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (telefonInput.Text.Length < 17)
            {
                e.Cancel = true;
                errorProvider1.SetError(telefonInput, Messages.telefon_mask);
            }
            else
            {
                errorProvider1.SetError(telefonInput, null);
            }
        }
    }
}