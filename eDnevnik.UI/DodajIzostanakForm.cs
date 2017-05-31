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
        private WebAPIHelper uceniciService = new WebAPIHelper("api/ucenici");

        public DodajIzostanakForm()
        {
            InitializeComponent();
        }
        public DodajIzostanakForm(string predmet, string datum, int casId)
        {
            InitializeComponent();
            predmetReadOnly.Text = predmet;
            datumReadOnly.Text = datum;
            casIdTest.Text = casId.ToString();

        }

        private void DodajIzostanakForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = uceniciService.GetResponse();
            

            if (response.IsSuccessStatusCode)
            {
                uceniciGridView.DataSource = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
            }
        }

        private void dodajIzostanakButton_Click(object sender, EventArgs e)
        {

        }
    }
}
