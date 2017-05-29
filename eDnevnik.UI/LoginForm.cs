using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eDnevnik.API.Models;
using eDnevnik.UI.Util;

namespace eDnevnik.UI
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper nastavniciService = new WebAPIHelper("api/nastavnici");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = nastavniciService.GetResponse(KorisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                Nastavnik n = response.Content.ReadAsAsync<Nastavnik>().Result;
                if (n.Korisnik.Prezime == LozinkaInput.Text)
                {
                    MessageBox.Show("Dobrodosli " + n.Korisnik.Ime);
                    DialogResult = DialogResult.OK;
                    //Close();
                }
                else
                {
                    MessageBox.Show("Podaci nisu validni");
                }
            }
            else
            {
                    MessageBox.Show("Podaci nisu validni");
            }
        }
    }
}
