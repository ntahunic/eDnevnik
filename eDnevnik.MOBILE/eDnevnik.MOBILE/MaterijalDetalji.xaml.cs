using eDnevnik.PCL.Model;
using eDnevnik.PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDnevnik.MOBILE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterijalDetalji : ContentPage
    {
        private WebAPIHelper _materijaliService = new WebAPIHelper("api/materijali");
        private WebAPIHelper _ocjeneMaterijalService = new WebAPIHelper("api/ocjeneMaterijal");
        int materijalIdGlobal;
        public MaterijalDetalji()
        {
            InitializeComponent();
        }

        public MaterijalDetalji(int materijalId)
        {
            InitializeComponent();

            LoadPageData(materijalId);
            materijalIdGlobal = materijalId;
        }

        private void LoadPageData(int materijalId)
        {
            HttpResponseMessage response = _materijaliService.GetResponse(materijalId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                MaterijalVM materijal = JsonConvert.DeserializeObject<MaterijalVM>(jsonResult.Result);

                NazivText.Text = materijal.Naziv;
                DatumText.Text = materijal.Datum;
                SadrzajText.Text = materijal.Sadrzaj;

                List<OcjenaTemp> ocjenePrikaz = new List<OcjenaTemp>();
                for (int i = 1; i <= 5; i++)
                {
                    ocjenePrikaz.Add(new OcjenaTemp { Id = i, Ocjena = i.ToString() });
                }

                response = _ocjeneMaterijalService.GetActionResponse("GetOcjeneByMaterialByUcenik", materijalId.ToString() + "/" + Global.TrenutniKorisnik.KorisnikId.ToString());
                var jsonResult3 = response.Content.ReadAsStringAsync();
                OcjenaMaterijalVM ocjena = JsonConvert.DeserializeObject<OcjenaMaterijalVM>(jsonResult3.Result);


                ocjenaPicker.ItemsSource = ocjenePrikaz;
                ocjenaPicker.ItemDisplayBinding = new Binding("Ocjena");
                ocjenaPicker.SelectedIndex = ocjena.OcjenaVrijednost-1;

                response = _materijaliService.GetActionResponse("GetSlicniMaterijali", materijal.MaterijalId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult2 = response.Content.ReadAsStringAsync();
                    PreporuceniMaterijaliVM preporuceniMaterijali = JsonConvert.DeserializeObject<PreporuceniMaterijaliVM>(jsonResult2.Result);

                    materijaliList.ItemsSource = preporuceniMaterijali.SlicniMaterijali;
                    materijaliList.HeightRequest = preporuceniMaterijali.SlicniMaterijali.Count * 60;
                    popularniMaterijaliList.ItemsSource = preporuceniMaterijali.PopularniMaterijali;
                    popularniMaterijaliList.HeightRequest = preporuceniMaterijali.PopularniMaterijali.Count * 60;
                }
            }
        }
        private void materijaliList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new MaterijalDetalji((e.Item as MaterijalVM).MaterijalId));
            }
        }

        private void ocjenaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = _ocjeneMaterijalService.GetActionResponse("GetOcjeneByMaterialByUcenik", materijalIdGlobal.ToString() + "/" + Global.TrenutniKorisnik.KorisnikId.ToString());
            OcjenaMaterijalVM ocjena;

            if (response.IsSuccessStatusCode)
            {
                var jsonResult3 = response.Content.ReadAsStringAsync();
                ocjena = JsonConvert.DeserializeObject<OcjenaMaterijalVM>(jsonResult3.Result);
                ocjena.OcjenaVrijednost = ocjenaPicker.SelectedIndex + 1;


                response = _ocjeneMaterijalService.PostResponse(ocjena);
                if (response.IsSuccessStatusCode)
                    DisplayAlert("Uspješna izmjena", "Uspješno ste izmijenili ocjenu.", "ok");                
            }
            else
            {
                ocjena = new OcjenaMaterijalVM();
                ocjena.OcjenaVrijednost = ocjenaPicker.SelectedIndex + 1;
                ocjena.MaterijalId = materijalIdGlobal;
                ocjena.UcenikId = Global.TrenutniKorisnik.KorisnikId;
                ocjena.Datum = DateTime.Now.ToString();
                response = _ocjeneMaterijalService.PostResponse(ocjena);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Uspješna izmjena", "Uspješno ste izmijenili ocjenu.", "ok");
                }
            }
            
        }

        private async void FileDownload_Clicked(object sender, EventArgs e)
        {
            HttpResponseMessage response = _materijaliService.GetResponse(materijalIdGlobal.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                MaterijalVM materijal = JsonConvert.DeserializeObject<MaterijalVM>(jsonResult.Result);

                FileSavePicker savePicker = new FileSavePicker();
                savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
                savePicker.FileTypeChoices.Add("Word Document", new List<string>() { ".docx" });
                savePicker.FileTypeChoices.Add("Word 97 - 2003 Document", new List<string>() { ".doc" });
                savePicker.FileTypeChoices.Add("Text document", new List<string>() { ".txt" });
                savePicker.FileTypeChoices.Add("Rich Text Document", new List<string>() { ".rtf" });
                savePicker.FileTypeChoices.Add("PDF", new List<string>() { ".pdf" });
                savePicker.FileTypeChoices.Add("JPG", new List<string>() { ".jpg" });
                savePicker.DefaultFileExtension = materijal.FileEkstenzija;
                savePicker.SuggestedFileName = materijal.FileIme;
                StorageFile file = await savePicker.PickSaveFileAsync();
                if (null != file)
                {
                    Windows.Storage.CachedFileManager.DeferUpdates(file);
                    // write to file
                    await Windows.Storage.FileIO.WriteBytesAsync(file, materijal.File);
                    
                    Windows.Storage.Provider.FileUpdateStatus status =
                        await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);

                    if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
                    {
                        await DisplayAlert("Preuzimanje file", "File preuzet", "ok");
                    }
                    else
                    {
                        await DisplayAlert("Preuzimanje file", "Doslo je do greske prilikom preuzimanja file-a", "ok");
                    }
                }
                else
                {
                    await DisplayAlert("Preuzimanje file", "Ponisteno", "ok");
                }
            }
        }

        private void popularniMaterijaliList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new MaterijalDetalji((e.Item as MaterijalVM).MaterijalId));
            }
        }
    }
}