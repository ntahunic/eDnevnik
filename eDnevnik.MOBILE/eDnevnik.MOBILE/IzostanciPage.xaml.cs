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
	public partial class IzostanciPage : ContentPage
	{
        private WebAPIHelper _prisustvoService = new WebAPIHelper("/api/prisustvo");

        public IzostanciPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            HttpResponseMessage response = _prisustvoService.GetActionResponse("GetOdsustvoByUcenik", "1");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<PrisustvoVM> obavijesti = JsonConvert.DeserializeObject<List<PrisustvoVM>>(jsonResult.Result);

                izostanciList.ItemsSource = obavijesti;
            }

            base.OnAppearing();
        }
    }
}