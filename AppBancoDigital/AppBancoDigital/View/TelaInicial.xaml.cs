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
            usuario.Source = ImageSource.FromResource("AppBancoDigital.Image.usuario.png");
            img_transferir2.Source = ImageSource.FromResource("AppBancoDigital.Image.img_transferir2.PNG");
            img_pix.Source = ImageSource.FromResource("AppBancoDigital.Image.109617.png");
            img_code.Source = ImageSource.FromResource("AppBancoDigital.Image.109617.png");
            LOGOTIPO.Source = ImageSource.FromResource("AppBancoDigital.Image.Logo.PNG");
            //mudar.Source = ImageSource.FromResource("AppBancoDigital.img_mudar.Logo.PNG");
            
        }


        private void img_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pix.EnviarPix());
        }

        private void img_pix_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pix.PixExibirQrCode());

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