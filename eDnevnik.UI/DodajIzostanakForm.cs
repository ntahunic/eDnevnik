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
    public partial class DodajIzostanakForm : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");

        public DodajIzostanakForm()
        {
            InitializeComponent();
        }
        public DodajIzostanakForm(string predmet, string datum, int casId, int brojSati)
        {
            InitializeComponent();
            predmetReadOnly.Text = predmet;
            datumReadOnly.Text = datum;
            casIdTest.Text = casId.ToString();
            brojSatiReadOnly.Text = brojSati.ToString();
        }

        private void DodajIzostanakForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _prisustvoService.GetResponse(casIdTest.Text);


            if (response.IsSuccessStatusCode)
            {
                uceniciGridView.DataSource = response.Content.ReadAsAsync<List<PrisustvoVM>>().Result;

                //DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                //dgvCmb.ValueType = typeof(bool);
                //dgvCmb.Name = "Odsutan";
                //dgvCmb.HeaderText = "Odsutan";
                //uceniciGridView.Columns.Add(dgvCmb);
            }
        }

        private void dodajIzostanakButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = null;
            foreach (DataGridViewRow row in uceniciGridView.Rows)
            {
                Prisustvo prisustvo = new Prisustvo();
                prisustvo.PrisustvoId = (int)row.Cells["PrisustvoId"].Value;
                prisustvo.Prisutan = Convert.ToBoolean(row.Cells["Prisutan"].Value);
                prisustvo.Opravdano = Convert.ToBoolean(row.Cells["IsOpravdano"].Value);
                prisustvo.BrojSati = Convert.ToInt32(brojSatiReadOnly.Text);
                prisustvo.CasId = Convert.ToInt32(casIdTest.Text);
                prisustvo.UcenikId = (int)row.Cells["UcenikId"].Value;

                response = _prisustvoService.PutResponse(prisustvo);
            }
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Izostanci uspješno dodani");
                Close();
            }
           
        }

        private void uceniciGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
