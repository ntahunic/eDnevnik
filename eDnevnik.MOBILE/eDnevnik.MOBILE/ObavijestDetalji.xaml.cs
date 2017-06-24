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
	public partial class ObavijestDetalji : ContentPage
	{
        private WebAPIHelper _obavijestiService = new WebAPIHelper("api/obavijesti");

		public ObavijestDetalji ()
		{
			InitializeComponent ();
		}

        public ObavijestDetalji(int obavijestId)
        {
            InitializeComponent();

            LoadPageData(obavijestId);
        }

        private void LoadPageData(int obavijestId)
        {
            HttpResponseMessage response = _obavijestiService.GetActionResponse(obavijestId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                ObavijestVM obavijest = JsonConvert.DeserializeObject<ObavijestVM>(jsonResult.Result);

                NaslovText.Text = obavijest.Naslov;
                DatumText.Text = obavijest.Datum;
                NastavnikText.Text = obavijest.Nastavnik;
                PredmetText.Text = obavijest.Predmet;
                SadrzajText.Text = obavijest.Sadrzaj;
            }
        }
    }
}