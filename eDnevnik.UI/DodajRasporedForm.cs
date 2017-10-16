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
    public partial class DodajRasporedForm : Form
    {
        private WebAPIHelper _razrediService = new WebAPIHelper("api/razredi");
        private WebAPIHelper _rasporedCasovaService = new WebAPIHelper("api/rasporedCasova");
        public DodajRasporedForm()
        {
            InitializeComponent();
        }

        private void DodajRasporedForm_Load(object sender, EventArgs e)
        {
            RazrediLoad();
            DataBind();
        }

        private void RazrediLoad()
        {
            HttpResponseMessage response = _razrediService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<RazredVM> razredi = response.Content.ReadAsAsync<List<RazredVM>>().Result;
                razredInput.DataSource = razredi;
                razredInput.ValueMember = "RazredId";
                razredInput.DisplayMember = "RazredOdjeljenje";
            }
        }

        private void DataBind()
        {
            HttpResponseMessage response = _rasporedCasovaService.GetActionResponse("getByRazred", razredInput.SelectedValue.ToString());
            RasporedCasovaVM rasporedCasova = response.Content.ReadAsAsync<RasporedCasovaVM>().Result;

            string[] ponedjeljak = rasporedCasova.Pon.Split(',');
            string[] utorak = rasporedCasova.Uto.Split(',');
            string[] srijeda = rasporedCasova.Sri.Split(',');
            string[] cetvrtak = rasporedCasova.Cet.Split(',');
            string[] petak = rasporedCasova.Pet.Split(',');

            if(rasporedCasovaGridView.Rows.Count < 7)
            {
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.Rows.Add();
                rasporedCasovaGridView.AllowUserToAddRows = false;
                rasporedCasovaGridView.AllowUserToDeleteRows = false;
            }

            for (int i = 0; i < 7; i++)
                rasporedCasovaGridView.Rows[i].Cells[0].Value = ponedjeljak[i];
            for (int i = 0; i < 7; i++)
                rasporedCasovaGridView.Rows[i].Cells[1].Value = utorak[i];
            for (int i = 0; i < 7; i++)
                rasporedCasovaGridView.Rows[i].Cells[2].Value = srijeda[i];
            for (int i = 0; i < 7; i++)
                rasporedCasovaGridView.Rows[i].Cells[3].Value = cetvrtak[i];
            for (int i = 0; i < 7; i++)
                rasporedCasovaGridView.Rows[i].Cells[4].Value = petak[i];


        }

        private void sacuvajRasporedButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = _rasporedCasovaService.GetActionResponse("getByRazred", razredInput.SelectedValue.ToString());
            RasporedCasovaVM rasporedCasova = response.Content.ReadAsAsync<RasporedCasovaVM>().Result;

            rasporedCasova.Pon = "";
            rasporedCasova.Uto = "";
            rasporedCasova.Sri = "";
            rasporedCasova.Cet = "";
            rasporedCasova.Pet = "";
           

            for (int i = 0; i < 7; i++)
                rasporedCasova.Pon += rasporedCasovaGridView.Rows[i].Cells[0].Value.ToString() + ",";
            for (int i = 0; i < 7; i++)
                rasporedCasova.Uto += rasporedCasovaGridView.Rows[i].Cells[1].Value.ToString() + ",";
            for (int i = 0; i < 7; i++)
                rasporedCasova.Sri += rasporedCasovaGridView.Rows[i].Cells[2].Value.ToString() + ",";
            for (int i = 0; i < 7; i++)
                rasporedCasova.Cet += rasporedCasovaGridView.Rows[i].Cells[3].Value.ToString() + ",";
            for (int i = 0; i < 7; i++)
                rasporedCasova.Pet += rasporedCasovaGridView.Rows[i].Cells[4].Value.ToString() + ",";

            response = _rasporedCasovaService.PutResponse(rasporedCasova.RasporedCasovaId, rasporedCasova);
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Raspored uspješno promijenjen.");
                DataBind();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DataBind();
        }

        private void rasporedCasovaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
