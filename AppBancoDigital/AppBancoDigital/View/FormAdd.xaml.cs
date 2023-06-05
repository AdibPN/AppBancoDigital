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
    public partial class FormAdd : ContentPage
    {
        public FormAdd()
        {
            InitializeComponent();
        }
  
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    Nome = txt_nome.Text,
                    CPF = txt_cpf.Text,
                    Senha = txt_Senha.Text,
                    Data_Nascimento = dtpck_data_nasc.Date,
                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;

                    await Navigation.PushAsync(new View.Listagem());
                }
                else
                    throw new Exception("Erro, correntista não cadastrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}