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
	public partial class PredmetDetalji : ContentPage
	{
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");
        private WebAPIHelper _prisustvoService = new WebAPIHelper("api/prisustvo");
        private WebAPIHelper _ocjeneService = new WebAPIHelper("api/ocjene");

        public PredmetDetalji ()
		{
			InitializeComponent ();
		}

        public PredmetDetalji(int predmetId)
        {
            InitializeComponent();

            LoadPageData(predmetId);
        }

        private void LoadPageData(int predmetId)
        {
            HttpResponseMessage response = _predmetiService.GetResponse(predmetId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                PredmetVM predmet = JsonConvert.DeserializeObject<PredmetVM>(jsonResult.Result);

                NazivPredmetaText.Text = predmet.Naziv;
                NastavnikNaPredmetuText.Text = predmet.Nastavnik;


                response = _prisustvoService.GetActionResponse("GetOdsustvoFromPredmetByUcenik", predmet.PredmetId.ToString()+"/"+Global.TrenutniKorisnik.KorisnikId);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult2 = response.Content.ReadAsStringAsync();
                    int ukupnoIzostanaka = JsonConvert.DeserializeObject<int>(jsonResult2.Result);

                    UkupnoIzostanakaText.Text = ukupnoIzostanaka.ToString();
                }
                response = _ocjeneService.GetActionResponse("GetOcjeneByPredmetByUcenik", predmet.PredmetId.ToString()+"/"+Global.TrenutniKorisnik.KorisnikId);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult2 = response.Content.ReadAsStringAsync();
                    List<OcjenaVM> ocjeneNaPredmetu = JsonConvert.DeserializeObject<List<OcjenaVM>>(jsonResult2.Result);

                    OcjeneNaPredmetuList.ItemsSource = ocjeneNaPredmetu;
                }
            }
        }
    }
}