using AppBancoDigital.Model;
using AppBancoDigital.Service;
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
    public partial class NovoUsuario : ContentPage
    {
        //readonly App PropriedadeApp;
        public NovoUsuario()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //PropriedadeApp = (App)Application.Current;
            //NavigationPage.SetHasNavigationBar(this, false);
            //Logo.Source = ImageSource.FromResource("AppBancoDigital.Image.Logo.PNG");
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Correntista c = await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    Nome = txtNome.Text,
                    Senha = txtSenha.Text,
                    Data_Nasc = txtDataNasc.Date.ToString("yyyy-MM-dd"),
                    CPF = txtCPF.Text
                });

                string msg = $"Correntista inserido com sucesso. Código gerado: {c.Id} ";

                await DisplayAlert("Sucesso!", msg, "OK");

                await Navigation.PushAsync(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}