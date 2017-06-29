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
	public partial class MaterijaliPage : ContentPage
	{
        private WebAPIHelper _materijaliService = new WebAPIHelper("api/materijali");
        private WebAPIHelper _predmetiService = new WebAPIHelper("api/predmeti");

        public MaterijaliPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            HttpResponseMessage response = _predmetiService.GetActionResponse("getPredmetiByRazred", Global.TrenutniKorisnik.RazredId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<PredmetVM> predmeti = JsonConvert.DeserializeObject<List<PredmetVM>>(jsonResult.Result);

                predmetiPicker.ItemsSource = predmeti;
                predmetiPicker.ItemDisplayBinding = new Binding("Naziv");
            }
                        
            base.OnAppearing();
        }

        private void materijaliList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new MaterijalDetalji((e.Item as MaterijalVM).MaterijalId));
            }
        }

        private void predmetiPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(predmetiPicker.SelectedItem != null)
            {
                int predmetId = (predmetiPicker.SelectedItem as PredmetVM).PredmetId;

                HttpResponseMessage response = _materijaliService.GetActionResponse("GetMaterialByPredmet", predmetId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    List<MaterijalVM> materijal = JsonConvert.DeserializeObject<List<MaterijalVM>>(jsonResult.Result);

                    materijaliList.ItemsSource = materijal;
                }
            }
            
        }
    }
}