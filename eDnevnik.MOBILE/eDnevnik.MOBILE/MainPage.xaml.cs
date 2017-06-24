﻿using eDnevnik.PCL.Model;
using eDnevnik.PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eDnevnik.MOBILE
{
	public partial class MainPage : ContentPage
	{
        private WebAPIHelper _obavijestiService = new WebAPIHelper("api/obavijesti");
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = _obavijestiService.GetActionResponse("GetObavijestiByRazred", "1");
            if(response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                List<ObavijestVM> obavijesti = JsonConvert.DeserializeObject<List<ObavijestVM>>(jsonResult.Result);

                obavijestiList.ItemsSource = obavijesti;
            }


            base.OnAppearing();
        }

        private void obavijestiList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                this.Navigation.PushModalAsync(new ObavijestDetalji((e.Item as ObavijestVM).ObavijestId));
            }
        }
    }
}