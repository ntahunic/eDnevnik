using eDnevnik.API.Models;
using eDnevnik.UI.Reports;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dodajČasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajCasForm();
            frm.Show();
        }

        private void mojiPredmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PrikaziPredmeteForm();
            frm.Show();
        }

        private void dodajObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajObavijestForm();
            frm.Show();
        }

        private void pregledObavijestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PrikaziObavijestiForm();
            frm.Show();
        }

        private void dodajOcjenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajOcjenuForm();
            frm.Show();
        }

        private void izmijeniOcjenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UrediOcjenuForm();
            frm.Show();
        }

        private void nastavničkiKadarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajNastavnikaForm();
            frm.Show();
        }

        private void predmetiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new DodajPredmetForm();
            frm.Show();
        }

        private void razrediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajRazredForm();
            frm.Show();
        }

        private void učeniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajUcenikaForm();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Global.TrenutniKorisnik.Uloga.Where(x=>x.Naziv=="admin").Any())
            {
                administracijaToolStripMenuItem.Visible = false;
            }
        }

        private void ocjeneIzPredmetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ReportViewForm();
            frm.Show();
        }

        private void dodajČasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new DodajCasForm();
            frm.Show();
        }

        private void dodajOcjenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new DodajOcjenuForm();
            frm.Show();
        }

        private void izmijeniOcjenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new UrediOcjenuForm();
            frm.Show();
        }

        private void evidencijaRasporedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajRasporedForm();
            frm.Show();
        }

        private void dodavanjeMaterijalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DodajMaterijalPredmet();
            frm.Show();
        }

        private void izostanciUcenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ReportViewFormPrisustva();
            frm.Show();
        }

        private void uceniciIzRazredaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ReportViewFormUcenici();
            frm.Show();
        }
    }
}
