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


        public DodajRazredForm()
        {
            InitializeComponent();
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

        private void dodajRazredButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;

            Razred razred = new Razred
            {               
                Naziv = razredInput.Text,
                AkademskaGodinaId = Convert.ToInt32(akademskaGodinaInput.SelectedValue),
                Odjeljenje = odjeljenjeInput.Text
            };

            if (razredIdText.Text == "")
                response = _razrediService.PostResponse(razred);
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
    }
}
