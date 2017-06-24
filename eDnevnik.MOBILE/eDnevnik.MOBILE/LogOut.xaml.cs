using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDnevnik.MOBILE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogOut : ContentPage
	{
		public LogOut ()
		{
			InitializeComponent ();

            this.Navigation.PushModalAsync(new Login());
        }
    }
}