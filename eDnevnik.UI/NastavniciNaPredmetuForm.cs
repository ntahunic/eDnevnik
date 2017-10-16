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
    public partial class NastavniciNaPredmetuForm : Form
    {
        private WebAPIHelper _nastavniciService = new WebAPIHelper("api/nastavnici");
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public NastavniciNaPredmetuForm(int predmetId)
        {
            InitializeComponent();
            DataBind(predmetId);
        }

        private void NastavniciNaPredmetuForm_Load(object sender, EventArgs e)
        {
            //DataBind();
        }

        private void DataBind(int predmetId)
        {
            List<NastavnikVM> nastavniciNaPredmetu = null; 
            HttpResponseMessage response = _nastavniciService.GetActionResponse("getNastavniciByPredmet", predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                nastavniciNaPredmetu = response.Content.ReadAsAsync<List<NastavnikVM>>().Result.ToList();
                nastavniciNaPredmetuGridView.DataSource = nastavniciNaPredmetu;
            }
            response = _nastavniciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<NastavnikVM> nastavniciAll = response.Content.ReadAsAsync<List<NastavnikVM>>().Result.ToList();
                List<NastavnikVM> notInPredmetNastavnici = new List<NastavnikVM>();
                foreach (var item in nastavniciAll)
                {
                    if (!nastavniciNaPredmetu.Any(n=>n.NastavnikId == item.NastavnikId))
                        notInPredmetNastavnici.Add(item);
                }

                if (notInPredmetNastavnici.Count() != 0)
                    notInPredmetNastavnici.Insert(0, new NastavnikVM());
                nastavnikNaPredmetuiInput.DataSource = notInPredmetNastavnici;
                nastavnikNaPredmetuiInput.ValueMember = "NastavnikId";
                nastavnikNaPredmetuiInput.DisplayMember = "ImePrezime";
            }

            predmetIdText.Text = predmetId.ToString();
        }

        private void dodajNastavnikaNaPredmetButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int nastavnikId = Convert.ToInt32(nastavnikNaPredmetuiInput.SelectedValue.ToString());
                int predmetId = Convert.ToInt32(predmetIdText.Text);
                Predmet temp = new Predmet();

                HttpResponseMessage response = _predmetiService.PutActionResponse("putPredmetNewNastavnik", temp, predmetId + "/" + nastavnikId);

                if(response.IsSuccessStatusCode)
                    MessageBox.Show("Uspješno dodan/izmijenjen nastavnik.");

                DataBind(predmetId);
            }
        }

        private void nastavniciNaPredmetuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite ukloniti profesora sa predmeta?", "Ukloniti profesora sa predmeta?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int nastavnikId = (int)nastavniciNaPredmetuGridView.CurrentRow.Cells["NastavnikId"].Value;
                    int predmetId = Convert.ToInt32(predmetIdText.Text);

                    HttpResponseMessage response = null;
                    try
                    {
                        response = _predmetiService.DeleteActionResponse("deletePredmetNewNastavnik", predmetId + "/" + nastavnikId);

                    }
                    catch(Exception g)
                    {
                        MessageBox.Show(g.InnerException.ToString());
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Profesor uklonjen sa predmeta");
                        DataBind(predmetId);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
