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

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            act_carregando.IsRunning = true;
            act_carregando.IsVisible = true;

            try
            {
                Correntista c = await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    Nome = txt_nome.Text,
                    CPF= txt_cpf.Text,
                    Senha = txt_Senha.Text,
                    Data_Nascimento = dtpck_data_nasc.Date,
                });

                if (c.Id != null)
                {
                    string msg = $"Correntista inserido com sucesso. Código gerado: {c.Id} ";

                    await DisplayAlert("Sucesso!", msg, "OK");

                    await Navigation.PushAsync(new View.Listagem());
                } else
                    throw new Exception("Erro, correntista não cadastrado");                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                act_carregando.IsRunning = false;
                act_carregando.IsVisible = false;
            }
        }
    }
}