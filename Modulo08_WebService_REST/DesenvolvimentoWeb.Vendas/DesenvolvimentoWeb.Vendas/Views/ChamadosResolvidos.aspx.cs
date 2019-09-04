using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DesenvolvimentoWeb.Vendas.Views
{
    public partial class MostrarChamadosResolvidos : System.Web.UI.Page
    {
        HttpClient client;
        static Chamado chamado;

        public MostrarChamadosResolvidos()
        {

            
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:50501/");
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                }
            
        }
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync("chamadosResolvidos").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var resultado = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert
                            .DeserializeObject<Chamado[]>(resultado).ToList();

                        chamadosRepeater.DataSource = lista;
                        chamadosRepeater.DataBind();
                        

                       

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}