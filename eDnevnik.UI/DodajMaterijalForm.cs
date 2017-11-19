using eDnevnik.API.Models;
using eDnevnik.UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.UI
{
    public partial class DodajMaterijalForm : Form
    {
        private WebAPIHelper _materijaliService = new WebAPIHelper("api/materijali");

        public DodajMaterijalForm(int predmetId)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            materijalPredmetId.Text = predmetId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            byte[] array;
                            using (myStream)
                            {
                                array = ReadFully(myStream);
                            }
                            Materijal materijal = new Materijal();
                            materijal.Datum = DateTime.Now.ToShortDateString();
                            materijal.Naziv = materijalNazivInput.Text;
                            materijal.Materijal1 = array;
                            materijal.NastavnikId = Global.TrenutniKorisnik.KorisnikId;
                            materijal.PredmetId = Convert.ToInt16(materijalPredmetId.Text);

                            HttpResponseMessage response = _materijaliService.PostResponse(materijal);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Materijal uspjesno dodat");
                            }
                            File.WriteAllBytes("C:/Users/Admin/Foo.txt", array);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void materijalNazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(materijalNazivInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(materijalNazivInput, Messages.materijalNaziv_req);
            }
        }
    }
}
