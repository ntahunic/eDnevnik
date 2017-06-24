using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDnevnik.MOBILE.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMenuItem> MenuItems { get; set; }

            public MyPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyPageMenuItem>(new[]
                {
                    new MyPageMenuItem { Title = "Obavijesti", TargetType = typeof(MainPage) },
                    new MyPageMenuItem { Title = "Predmeti", TargetType = typeof(PredmetiPage) },
                    new MyPageMenuItem { Title = "Izostanci", TargetType = typeof(IzostanciPage) },
                    new MyPageMenuItem { Title = "Log out", TargetType = typeof(LogOut) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}