﻿using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        /**
         * Obtém a lista de pessoas
         */
        public static async Task<List<Correntista>> GetCorrentistaAsync()
        {
            string json = await DataService.GetDataFromService("/Correntista");

            List<Correntista> arr_Correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_Correntista;
        }

        /**
         * Envia um Model em forma de JSON ara insert no banco.
         */
        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/Correntista/salvar");

            Correntista C = JsonConvert.DeserializeObject<Correntista>(json);

            return C;
        }

        /**
         * Realiza uma busca de pessoas no banco de dados.
         */
        public static async Task<List<Correntista>> SearchAsync(string q)
        {
            var json_a_enviar = JsonConvert.SerializeObject(q);

            string json = await DataService.PostDataToService(json_a_enviar, "/Correntista/buscar");

            List<Correntista> arr_Correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_Correntista;
        }

        /**
         * Deleta uma pessoa do banco de dados.
         */
        public static async Task<List<Correntista>> DeleteAsync(int id)
        {
            var json_a_enviar = JsonConvert.SerializeObject(id);

            string json = await DataService.PostDataToService(json_a_enviar, "/Correntista/delete");

            List<Correntista> arr_Correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_Correntista;
        }

    }
}
