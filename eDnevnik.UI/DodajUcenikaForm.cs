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
    public partial class DodajUcenikaForm : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");

        public DodajUcenikaForm()
        {
            InitializeComponent();
        }

        private void pretraziUcenikeButton_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            HttpResponseMessage response = _uceniciService.GetActionResponse("GetUcenikByStr", pretragaUcenikaInput.Text);
            if (response.IsSuccessStatusCode)
            {
                uceniciGridView.DataSource = response.Content.ReadAsAsync<List<UcenikVM>>().Result.ToList();
            }
        }

        private void noviUcenikButton_Click(object sender, EventArgs e)
        {
            Form frm = new NoviUcenikForm();
            frm.Show();
        }

        private void izmijeniUcenikaButton_Click(object sender, EventArgs e)
        {
            int ucenikId = (int)uceniciGridView.CurrentRow.Cells["UcenikId"].Value;
            Form frm = new NoviUcenikForm(ucenikId);
            frm.Show();
        }

        private void DodajUcenikaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
