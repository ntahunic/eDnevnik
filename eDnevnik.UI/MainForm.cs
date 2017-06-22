﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
