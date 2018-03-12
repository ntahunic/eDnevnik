using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using eDnevnik.PCL.Util;
using System.Net.Http;
using Newtonsoft.Json;
using eDnevnik.PCL.Model;

namespace eDnevnik.MOBILE
{
	public class Login : ContentPage
	{
        private WebAPIHelper _uceniciService = new WebAPIHelper("/api/ucenici");

        public Login ()
		{
            StackLayout stek = new StackLayout();
            stek.Margin = 10;
            stek.VerticalOptions = LayoutOptions.CenterAndExpand;

            Label zaglavljeLabel = new Label() {
                Text = "Prijava @ eDnevnik",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Image zaglavljeImage = new Image()
            {
                Source = "http://ss-brac-supetar.skole.hr/upload/ss-brac-supetar/images/static3/1161/Image/za_nastavnike.jpg",
                Aspect = Aspect.AspectFill,
                Margin = new Thickness(0, 0, 0, 75)
            };

            Entry korisnickoImeInput = new Entry() { Placeholder= "Korisnicko ime..." };
            Entry lozinkaInput = new Entry() { Placeholder= "******", IsPassword=true };

            Button prijavaButton = new Button() { Text = "Prijava" };
            prijavaButton.Clicked += (sender, args) =>
            {
                prijavaButton_Clicked(korisnickoImeInput, lozinkaInput);
            };
            
            stek.Children.Add(zaglavljeImage);
            stek.Children.Add(korisnickoImeInput);
            stek.Children.Add(lozinkaInput);
            stek.Children.Add(prijavaButton);

            Content = stek;
        }

        private void prijavaButton_Clicked(Entry korisnickoImeInput, Entry lozinkaInput)
        {
            HttpResponseMessage response = _uceniciService.GetActionResponse("GetUcenikByUsername", korisnickoImeInput.Text);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                UcenikVM n = JsonConvert.DeserializeObject<UcenikVM>(jsonResult.Result);

                if (Cryptography.VerifyPassword(n.Password, lozinkaInput.Text))
                {
                    this.Navigation.PushModalAsync(new Navigation.MyPage());
                    
                    Global.TrenutniKorisnik = new KorisnikVM
                    {
                        Ime = n.Ime,
                        Prezime = n.Prezime,
                        KorisnikId = n.UcenikId,
                        Password = n.Password,
                        Username = n.Username,
                        RazredId = n.RazredId
                    };
                }
                else
                    DisplayAlert("Info", "Podaci nisu validni", "Ok");
            }
            else
                DisplayAlert("Info", "Podaci nisu validni", "Ok");
        }
    }
}