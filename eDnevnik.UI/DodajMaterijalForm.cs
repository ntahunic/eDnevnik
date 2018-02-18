using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.UI
{
    public partial class DodajMaterijalForm : Form
    {
        private WebAPIHelper _materijaliService = new WebAPIHelper("api/materijali");

        public DodajMaterijalForm(int predmetId)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            materijalPredmetId.Text = predmetId.ToString();
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void materijalNazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(materijalNazivInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(materijalNazivInput, Messages.materijalNaziv_req);
            }
            else
            {
                errorProvider1.SetError(materijalNazivInput, null);
            }
        }

        private void dodajMaterijalButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Materijal materijal = new Materijal
                {
                    Naziv = materijalNazivInput.Text,
                    Datum = datumObjaveInput.Value.ToShortDateString(),
                    NastavnikId = Global.TrenutniKorisnik.KorisnikId,
                    PredmetId = Convert.ToInt32(materijalPredmetId.Text),
                    Sadrzaj = sadrzajInput.Text,
                    Fajl = System.Text.Encoding.UTF8.GetBytes(fileUploadInput.Text)
            };

                HttpResponseMessage response = _materijaliService.PostResponse(materijal);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Materijal uspješno dodan");
                    Close();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom dodavanja materijala");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog1 = new OpenFileDialog();
            fileDialog1.Filter = "All Files (*.*)|*.*";
            fileDialog1.FilterIndex = 1;
            fileDialog1.Multiselect = false;

            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sFileName = fileDialog1.FileName;

                byte[] file = File.ReadAllBytes(sFileName);
                // From byte array to string
                string s = System.Text.Encoding.UTF8.GetString(file, 0, file.Length);

                fileUploadInput.Text = s;
            }
        }

        private void fileUploadInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(fileUploadInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(materijalNazivInput, Messages.materijalNaziv_req);
            }
            else
            {
                errorProvider1.SetError(materijalNazivInput, null);
            }
        }
    }
}
