using AppBancoDigital.Model;
using AppBancoDigital.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Inicio();
        }

        public List<DadosUsuario> lista_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Usuario = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Usuario = "adib",
                Nome = "adib",
                Senha = "1235"
            },
        };

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
