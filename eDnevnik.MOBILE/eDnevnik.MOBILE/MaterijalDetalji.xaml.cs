using eDnevnik.PCL.Model;
using eDnevnik.PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDnevnik.MOBILE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterijalDetalji : ContentPage
    {
        private WebAPIHelper _materijaliService = new WebAPIHelper("api/materijali");
        private WebAPIHelper _ocjeneMaterijalService = new WebAPIHelper("api/ocjeneMaterijal");
        int materijalIdGlobal;
        public MaterijalDetalji()
        {
            InitializeComponent();
        }

        public MaterijalDetalji(int materijalId)
        {
            InitializeComponent();

            LoadPageData(materijalId);
            materijalIdGlobal = materijalId;
        }

        private void LoadPageData(int materijalId)
        {
            HttpResponseMessage response = _materijaliService.GetResponse(materijalId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                MaterijalVM materijal = JsonConvert.DeserializeObject<MaterijalVM>(jsonResult.Result);

                NazivText.Text = materijal.Naziv;
                DatumText.Text = materijal.Datum;
                SadrzajText.Text = materijal.Sadrzaj;

                List<OcjenaTemp> ocjenePrikaz = new List<OcjenaTemp>();
                for (int i = 1; i <= 5; i++)
                {
                    ocjenePrikaz.Add(new OcjenaTemp { Id = i, Ocjena = i.ToString() });
                }

                response = _ocjeneMaterijalService.GetActionResponse("GetOcjeneByMaterialByUcenik", materijalId.ToString() + "/" + Global.TrenutniKorisnik.KorisnikId.ToString());
                var jsonResult3 = response.Content.ReadAsStringAsync();
                OcjenaMaterijalVM ocjena = JsonConvert.DeserializeObject<OcjenaMaterijalVM>(jsonResult3.Result);


                ocjenaPicker.ItemsSource = ocjenePrikaz;
                ocjenaPicker.ItemDisplayBinding = new Binding("Ocjena");
                ocjenaPicker.SelectedIndex = ocjena.OcjenaVrijednost-1;

                response = _materijaliService.GetActionResponse("GetSlicniMaterijali", materijal.MaterijalId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult2 = response.Content.ReadAsStringAsync();
                    List<MaterijalVM> slicniMaterijali = JsonConvert.DeserializeObject<List<MaterijalVM>>(jsonResult2.Result);

                    materijaliList.ItemsSource = slicniMaterijali;
                }
            }
        }
        private void materijaliList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new MaterijalDetalji((e.Item as MaterijalVM).MaterijalId));
            }
        }

        private void ocjenaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = _ocjeneMaterijalService.GetActionResponse("GetOcjeneByMaterialByUcenik", materijalIdGlobal.ToString() + "/" + Global.TrenutniKorisnik.KorisnikId.ToString());
            OcjenaMaterijalVM ocjena;

            if (response.IsSuccessStatusCode)
            {
                var jsonResult3 = response.Content.ReadAsStringAsync();
                ocjena = JsonConvert.DeserializeObject<OcjenaMaterijalVM>(jsonResult3.Result);
                ocjena.OcjenaVrijednost = ocjenaPicker.SelectedIndex + 1;


                response = _ocjeneMaterijalService.PostResponse(ocjena);
                if (response.IsSuccessStatusCode)
                    DisplayAlert("Uspješna izmjena", "Uspješno ste izmijenili ocjenu.", "ok");                
            }
            else
            {
                ocjena = new OcjenaMaterijalVM();
                ocjena.OcjenaVrijednost = ocjenaPicker.SelectedIndex + 1;
                ocjena.MaterijalId = materijalIdGlobal;
                ocjena.UcenikId = Global.TrenutniKorisnik.KorisnikId;
                ocjena.Datum = DateTime.Now.ToString();
                response = _ocjeneMaterijalService.PostResponse(ocjena);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Uspješna izmjena", "Uspješno ste izmijenili ocjenu.", "ok");
                }
            }
            
        }
    }
}