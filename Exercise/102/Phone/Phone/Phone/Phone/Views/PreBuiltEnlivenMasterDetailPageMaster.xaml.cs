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

namespace Phone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreBuiltEnlivenMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public PreBuiltEnlivenMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new PreBuiltEnlivenMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PreBuiltEnlivenMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PreBuiltEnlivenMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public PreBuiltEnlivenMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<PreBuiltEnlivenMasterDetailPageMenuItem>(new[]
                {
                    new PreBuiltEnlivenMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new PreBuiltEnlivenMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new PreBuiltEnlivenMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new PreBuiltEnlivenMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new PreBuiltEnlivenMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
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