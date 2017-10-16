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
	public partial class RasporedCasova : ContentPage
	{
        private WebAPIHelper _rasporedCasovaService = new WebAPIHelper("api/rasporedCasova");

        public RasporedCasova()
        {
            InitializeComponent();


            HttpResponseMessage response = _rasporedCasovaService.GetActionResponse("getByRazred", Global.TrenutniKorisnik.RazredId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                RasporedCasovaVM raspored = JsonConvert.DeserializeObject<RasporedCasovaVM>(jsonResult.Result);

                PopuniRaspored(raspored);
            }          

        }

        private void PopuniRaspored(RasporedCasovaVM raspored)
        {
            rasporedCasovaGrid.Children.Add(new Label { Text = "PON", FontAttributes = FontAttributes.Bold }, 0, 0);
            for (int i = 0; i < 7; i++)
            {
                rasporedCasovaGrid.Children.Add(new Label { Text = raspored.Pon.Split(',')[i] }, 0, i + 1);
            }

            rasporedCasovaGrid.Children.Add(new Label { Text = "UTO", FontAttributes = FontAttributes.Bold }, 1, 0);
            for (int i = 0; i < 7; i++)
            {
                rasporedCasovaGrid.Children.Add(new Label { Text = raspored.Uto.Split(',')[i] }, 1, i + 1);
            }

            rasporedCasovaGrid.Children.Add(new Label { Text = "SRI", FontAttributes = FontAttributes.Bold }, 2, 0);
            for (int i = 0; i < 7; i++)
            {
                rasporedCasovaGrid.Children.Add(new Label { Text = raspored.Uto.Split(',')[i] }, 2, i + 1);
            }

            rasporedCasovaGrid.Children.Add(new Label { Text = "CET", FontAttributes = FontAttributes.Bold }, 3, 0);
            for (int i = 0; i < 7; i++)
            {
                rasporedCasovaGrid.Children.Add(new Label { Text = raspored.Uto.Split(',')[i] }, 3, i + 1);
            }

            rasporedCasovaGrid.Children.Add(new Label { Text = "PET", FontAttributes = FontAttributes.Bold }, 4, 0);
            for (int i = 0; i < 7; i++)
            {
                rasporedCasovaGrid.Children.Add(new Label { Text = raspored.Uto.Split(',')[i] }, 4, i + 1);
            }
        }
    }
}