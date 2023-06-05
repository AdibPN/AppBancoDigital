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
    public partial class Login : ContentPage
    {
    
        public Login()
        {
            InitializeComponent();

           
            NavigationPage.SetHasNavigationBar(this, false);
            Logo.Source = ImageSource.FromResource("AppBancoDigital.Image.Logo.PNG");

        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try 
            {
                Model.Correntista c = await DataServiceCorrentista.LoginAsync(new Model.Correntista
                {
                    CPF = txt_cpf.Text,
                    Senha = txtSenha.Text,

                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.TelaInicial());
                  
                }
                else
                    throw new Exception("Dados de login inválidos.");
            } 
            
            
            catch (Exception ex) 
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormAdd());
        }
    }
}