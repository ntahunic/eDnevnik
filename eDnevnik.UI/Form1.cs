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
    public partial class Form1 : Form
    {
        private WebAPIHelper _uceniciService = new WebAPIHelper("api/ucenici");
        public Form1()
        {
            InitializeComponent();
        }

        private void ucitajUcenikeButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = _uceniciService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<UcenikVM> users = response.Content.ReadAsAsync<List<UcenikVM>>().Result;
                uceniciGridView.DataSource = users;
            }
            else {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
