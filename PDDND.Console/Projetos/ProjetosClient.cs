using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using PDDND.ThirdPartyServices.Projetos;

namespace PDDND.Console.Projetos
{
    public class ProjetosClient
    {
        private HttpClient client;

        public ProjetosClient(HttpClient httpClient)
        {
            client = httpClient;
            client.BaseAddress = new Uri("http://localhost:60000/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IEnumerable<Projeto> Listar()
        {
            var response = client.GetAsync("api/projetos").Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsAsync<IEnumerable<Projeto>>().Result;
        }

        public Projeto ObterPorId(long id)
        {
            var response = client.GetAsync("api/projetos/" + id).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsAsync<Projeto>().Result;
        }

        public void Postar(Projeto projeto)
        {
            var response = client.PostAsJsonAsync<Projeto>("api/projetos", projeto).Result;
            response.EnsureSuccessStatusCode();
        }
    }
}
