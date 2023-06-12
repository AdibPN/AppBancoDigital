using AppBancoDigital.Model;
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
        /*public static async Task<List<Correntista>> GetCorrentistaAsync()
        {
            string json = await DataService.GetDataFromService("/Correntista");

            List<Correntista> arr_Correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_Correntista;
        }*/

        /**
         * Envia um Model em forma de JSON ara insert no banco.
         */


        public static async Task<Correntista> LoginAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");
            Console.WriteLine(json);

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("_____________________________________________ VAI SALVAR: ");
            Console.WriteLine(json_a_enviar);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");            

            Correntista C = JsonConvert.DeserializeObject<Correntista>(json);

            return C;
        }

        public static async Task<Correntista> SaveAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

    }
}
