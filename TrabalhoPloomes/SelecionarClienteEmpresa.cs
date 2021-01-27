using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Claims;

namespace TrabalhoPloomes
{
    class SelecionarClienteEmpresa
    {
                
        public void SelecionarNomeEmpresaCliente(ComboBox adicionarClientes, int typeID)
        {

            adicionarClientes.Items.Clear();

            JArray clienteste = RequestHandler.MakePloomesRequest($"Contacts?$filter=TypeId+eq+{typeID}", RestSharp.Method.GET);

            if (clienteste.Count > 0)
            {
                foreach (JObject item in clienteste)
                {
                    adicionarClientes.Items.Add(item["Name"].ToString());

                }
               
            }
        }


        public void FiltrarNegociosTarefas(string TipoDeFiltro, ComboBox adicionarClientes, string NomeDoCliente)
        {

            adicionarClientes.Items.Clear();
            

            JArray clienteste = RequestHandler.MakePloomesRequest($"{TipoDeFiltro}", RestSharp.Method.GET);
           


            for(int i= 0; i < clienteste.Count; i++)
            {
                if (clienteste[i]["ContactName"].ToString() == NomeDoCliente)
                {
                    adicionarClientes.Items.Add(clienteste[i]["Title"].ToString());

                }
            }


            
            
        }




    }
}
