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
    public partial class PrikaziObavijestiForm : Form
    {
        private WebAPIHelper _obavijestiService = new WebAPIHelper("api/obavijesti");

        public PrikaziObavijestiForm()
        {
            InitializeComponent();
        }

        private void PrikaziObavijestiForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = _obavijestiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                obavijestiGridView.DataSource = response.Content.ReadAsAsync<List<ObavijestVM>>().Result.OrderByDescending(x => x.Datum).ToList();
            }
        }

        private void obavijestUrediButton_Click(object sender, EventArgs e)
        {
            int obavijestId = (int)obavijestiGridView.CurrentRow.Cells[0].Value;

            HttpResponseMessage response = _obavijestiService.GetResponse(obavijestId.ToString());
            ObavijestVM obavijest = response.Content.ReadAsAsync<ObavijestVM>().Result;

            Form frm = new DodajObavijestForm(obavijest);
            frm.Show();
            Close();
        }

        private void obavijestiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
