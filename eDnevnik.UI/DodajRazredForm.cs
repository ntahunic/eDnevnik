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
    public partial class DodajRazredForm : Form
    {
        private WebAPIHelper _razrediService = new WebAPIHelper("api/razredi");
        private WebAPIHelper _akademskeGodineService = new WebAPIHelper("api/akademskeGodine");
        private WebAPIHelper _rasporedCasovaService = new WebAPIHelper("api/rasporedCasova");


        public DodajRazredForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        private void dodajRazredButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage response;

                Razred razred = new Razred
                {
                    Naziv = razredInput.Text,
                    AkademskaGodinaId = Convert.ToInt32(akademskaGodinaInput.SelectedValue),
                    Odjeljenje = odjeljenjeInput.Text
                };

                if (razredIdText.Text == "")
                {
                    response = _razrediService.PostResponse(razred);
                    RasporedCasova rasporedCasova = new RasporedCasova
                    {
                        RazredId = response.Content.ReadAsAsync<Razred>().Result.RazredId,
                        Pon = ",,,,,,",
                        Uto = ",,,,,,",
                        Sri = ",,,,,,",
                        Cet = ",,,,,,",
                        Pet = ",,,,,,"
                    };
                    _rasporedCasovaService.PostResponse(rasporedCasova);
                }
                else
                {
                    razred.RazredId = Convert.ToInt32(razredIdText.Text);
                    response = _razrediService.PutResponse(razred.RazredId, razred);
                }


                if (response.IsSuccessStatusCode)
                {
                    DataBind();
                    MessageBox.Show("Uspješno dodan/izmijenjen razred.");
                }
            }
            
        }

        private void izmijeniRazredButton_Click(object sender, EventArgs e)
        {
            int razredId = (int)razrediGridView.CurrentRow.Cells["RazredId"].Value;

            HttpResponseMessage response = _razrediService.GetResponse(razredId.ToString());
            if (response.IsSuccessStatusCode)
            {
                RazredVM razred = response.Content.ReadAsAsync<RazredVM>().Result;

                razredIdText.Text = razred.RazredId.ToString();
                razredInput.Text = razred.Naziv;
                odjeljenjeInput.Text = razred.Odjeljenje;
                akademskaGodinaInput.SelectedValue = razred.AkademskaGodinaId;
            }
        }

        private void DodajRazredForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            HttpResponseMessage response = _razrediService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                razrediGridView.DataSource = response.Content.ReadAsAsync<List<RazredVM>>().Result.ToList();
            }
            response = _akademskeGodineService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<AkademskaGodinaVM> akademskeGodine = response.Content.ReadAsAsync<List<AkademskaGodinaVM>>().Result;
                akademskeGodine.Insert(0, new AkademskaGodinaVM());
                akademskaGodinaInput.DataSource = akademskeGodine;
                akademskaGodinaInput.ValueMember = "AkademskaGodinaId";
                akademskaGodinaInput.DisplayMember = "Naziv";
            }
        }

        private void razredInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(razredInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(razredInput, "Molimo unesite razred");
            }
        }

        private void odjeljenjeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(odjeljenjeInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(odjeljenjeInput, "Molimo unesite odjeljenje");
            }
        }

        private void akademskaGodinaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(akademskaGodinaInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(akademskaGodinaInput, "Molimo unesite akademsku godinu");
            }
        }
    }
}
