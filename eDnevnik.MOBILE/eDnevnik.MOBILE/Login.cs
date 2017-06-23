using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace eDnevnik.MOBILE
{
	public class Login : ContentPage
	{
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

            Entry korisnickoImeInput = new Entry() { Placeholder= "Korisnicko ime..." };
            Entry lozinkaInput = new Entry() { Placeholder= "******", IsPassword=true };

            Button prijavaButton = new Button() { Text = "Prijava" };
            prijavaButton.Clicked += (sender, args) =>
            {
                DisplayAlert("Info", "Prijava na sistem ce biti uskoro omogucena INSALLAH", "Ok");
            };
            
            stek.Children.Add(zaglavljeLabel);
            stek.Children.Add(korisnickoImeInput);
            stek.Children.Add(lozinkaInput);
            stek.Children.Add(prijavaButton);

            Content = stek;
		}
        
    }
}