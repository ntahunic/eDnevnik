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
    public partial class DodajMaterijalPredmet : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public DodajMaterijalPredmet()
        {
            InitializeComponent();
        }

        private void DodajMaterijalPredmet_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiInput.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result;
                predmetiInput.ValueMember = "PredmetId";
                predmetiInput.DisplayMember = "Naziv";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int predmetId = Convert.ToInt32(predmetiInput.SelectedValue);
            Form frm = new DodajMaterijalForm(predmetId);
            frm.Show();
        }
    }
}
