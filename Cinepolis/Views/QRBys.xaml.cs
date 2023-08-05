using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRBys : ContentPage
    {
        public QRBys()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }
        private async void ButtonFinalizarClicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new AppShell();

        }
    }
}