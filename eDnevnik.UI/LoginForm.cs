﻿using System;
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
            HttpResponseMessage response = nastavniciService.GetActionResponse("getByUsername", KorisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                NastavnikVM n = response.Content.ReadAsAsync<NastavnikVM>().Result;
                if (UIHelper.VerifyMd5Hash(LozinkaInput.Text, n.Password))
                {
                    DialogResult = DialogResult.OK;
                    Global.TrenutniKorisnik = new Korisnik
                    {
                        Ime = n.Ime,
                        Prezime = n.Prezime,
                        KorisnikId = n.NastavnikId,
                        Password = n.Password,
                        Username = n.Username,
                        Uloga = n.Uloge.Select(u => new Uloga
                        {
                            UlogaId = u.UlogaId,
                            Naziv = u.Naziv
                        }).ToList()
                    };                   

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
