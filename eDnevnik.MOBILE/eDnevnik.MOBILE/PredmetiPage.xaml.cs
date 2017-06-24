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
	public partial class PredmetiPage : ContentPage
	{
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public PredmetiPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = _predmetiService.GetActionResponse("getPredmetiByRazred", "1");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<PredmetVM> obavijesti = JsonConvert.DeserializeObject<List<PredmetVM>>(jsonResult.Result);

                predmetiList.ItemsSource = obavijesti;
            }
            
            base.OnAppearing();
        }
    }
}