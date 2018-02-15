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
    public partial class DodajPredmetForm : Form
    {
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _akademskeGodineService = new WebAPIHelper("api/akademskeGodine");
        private WebAPIHelper _nastavniciService = new WebAPIHelper("api/nastavnici");
        private WebAPIHelper _razrediService = new WebAPIHelper("api/razredi");

        public DodajPredmetForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }



        private void DodajPredmetForm_Load(object sender, EventArgs e)
        {
        }
        
        private void sacuvajPredmetButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage response;

                Predmet predmet = new Predmet
                {
                    Naziv = nazivPredmetaInput.Text,
                    AkademskaGodinaId = Convert.ToInt32(akademskaGodinaInput.SelectedValue),
                    RazredId = Convert.ToInt32(razredInput.SelectedValue)
                };

                if (predmetIdText.Text == "")
                    response = _predmetiService.PostResponse(predmet);
                else
                {
                    predmet.PredmetId = Convert.ToInt32(predmetIdText.Text);
                    response = _predmetiService.PutResponse(predmet.PredmetId, predmet);
                }


                if (response.IsSuccessStatusCode)
                {
                    DataBind();
                    MessageBox.Show("Uspješno dodan/izmijenjen predmet.");
                }
            }
            
        }

        private void izmijeniPredmetButton_Click(object sender, EventArgs e)
        {

            int predmetId = (int)predmetiGridView.CurrentRow.Cells["PredmetId"].Value;
            DataBind(predmetId);

            HttpResponseMessage response = _predmetiService.GetResponse(predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                PredmetVM predmet = response.Content.ReadAsAsync<PredmetVM>().Result;

                predmetIdText.Text = predmet.PredmetId.ToString();
                nazivPredmetaInput.Text = predmet.Naziv;
                akademskaGodinaInput.SelectedValue = predmet.AkademskaGodinaId;
                //nastavniciGridView.DataSource = predmet.Nastavnici; //changed
                razredInput.SelectedValue = predmet.RazredId;
            }
        }

        private void predmetiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati predmet?", "Brisanje predmeta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int predmetId = (int)predmetiGridView.CurrentRow.Cells["PredmetId"].Value;

                    HttpResponseMessage response = _predmetiService.DeleteResponse(predmetId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Predmet obrisan");
                        DataBind();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void DodajPredmetForm_Load_1(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {

            HttpResponseMessage response = _predmetiService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                predmetiGridView.DataSource = response.Content.ReadAsAsync<List<PredmetVM>>().Result.ToList();
            }
            response = _akademskeGodineService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<AkademskaGodinaVM> akademskeGodine = response.Content.ReadAsAsync<List<AkademskaGodinaVM>>().Result;
                akademskeGodine.Insert(0, new AkademskaGodinaVM());
                akademskaGodinaInput.DataSource = akademskeGodine;
                akademskaGodinaInput.ValueMember = "AkademskaGodinaId";
                akademskaGodinaInput.DisplayMember = "Naziv";
            }
            response = _razrediService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<RazredVM> razredi = response.Content.ReadAsAsync<List<RazredVM>>().Result;
                razredi.Insert(0, new RazredVM());
                razredInput.DataSource = razredi;
                razredInput.ValueMember = "RazredId";
                razredInput.DisplayMember = "RazredOdjeljenje";
            }
        }

        private void nazivPredmetaInput_Validating(object sender, CancelEventArgs e)
        {
            if (nazivPredmetaInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(nazivPredmetaInput, "Naziv predmeta mora biti minimalno 3 slova");
            } 
            else
            {
                errorProvider1.SetError(nazivPredmetaInput, null);
            }
        }

        private void akademskaGodinaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(akademskaGodinaInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(akademskaGodinaInput, "Molimo odaberite");
            }
            else
            {
                errorProvider1.SetError(akademskaGodinaInput, null);
            }
        }

        private void razredInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(razredInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(razredInput, "Molimo odaberite");
            }
            else
            {
                errorProvider1.SetError(razredInput, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dodajNastavnikaNaPredmetButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int nastavnikId = Convert.ToInt32(nastavnikNaPredmetuiInput.SelectedValue.ToString());
                int predmetId = Convert.ToInt32(predmetIdText.Text);
                Predmet temp = new Predmet();

                HttpResponseMessage response = _predmetiService.PutActionResponse("putPredmetNewNastavnik", temp, predmetId + "/" + nastavnikId);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Uspješno dodan/izmijenjen nastavnik.");

                DataBind(predmetId);
            }
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
                    if (!nastavniciNaPredmetu.Any(n => n.NastavnikId == item.NastavnikId))
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
                    catch (Exception g)
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
