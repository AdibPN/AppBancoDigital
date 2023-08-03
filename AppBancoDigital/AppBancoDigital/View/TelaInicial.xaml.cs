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
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            img_transferir2.Source = ImageSource.FromResource("AppBancoDigital.Image.img_transferir2.PNG");
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    /*Navigation.PushAsync(new View.Pix.EnviarPix());*/

        //}

        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    /*Navigation.PushAsync(new View.Pix.ReceberPix());*/

        //}
    }
}