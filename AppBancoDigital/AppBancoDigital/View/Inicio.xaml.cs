using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        readonly App PropriedadeApp;
        public Inicio()
        {
            InitializeComponent();

            PropriedadeApp = (App)Application.Current;
            NavigationPage.SetHasNavigationBar(this, false);
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Image.Logo.PNG");
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Login());

        }
    }
}