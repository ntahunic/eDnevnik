using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.UI
{
    public partial class DodajOcjenuForm : Form
    {
        private WebAPIHelper _casoviService = new WebAPIHelper("api/casovi");
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");

        public DodajOcjenuForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        
        private void DodajOcjenuForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _casoviService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                casoviGridView.DataSource = response.Content.ReadAsAsync<List<CasVM>>().Result.OrderByDescending(x => x.CasId).ToList();
            }            
        }

        private void preuzmiUcenikeButton_Click(object sender, EventArgs e)
        {
            int casId = (int)casoviGridView.CurrentRow.Cells[0].Value;
            HttpResponseMessage response = _prisustvoService.GetActionResponse("prisutniUcenici", casId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> ucenici = new List<UcenikVM>();
                ucenici = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
                ucenici.Insert(0, new UcenikVM());

                ucenikInput.DataSource = ucenici;
                ucenikInput.ValueMember = "UcenikId";
                ucenikInput.DisplayMember = "ImePrezime";
            }
        }

        private void sacuvajOcjenuButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int casId = (int)casoviGridView.CurrentRow.Cells[0].Value;
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
                    Close();
                }
            }
            


        }

        private void ucenikInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ucenikInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(ucenikInput, Messages.lname_req);
            }
        }

        private void ocjenaInput_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d$");

            if (!regex.IsMatch(ocjenaInput.Text) || String.IsNullOrEmpty(ocjenaInput.Text) || Convert.ToInt32(ocjenaInput.Text)<1 || Convert.ToInt32(ocjenaInput.Text) >5)
            {
                e.Cancel = true;
                errorProvider1.SetError(ocjenaInput, Messages.brojSati_len);
            }
        }
    }
}
