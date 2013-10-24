using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDDND.Console.Projetos;
using PDDND.ThirdPartyServices.Controllers;
using PDDND.ThirdPartyServices.Projetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.SelfHost;
using System.Net.Http;

namespace PDDND.Console.Projetos
{
    [TestClass]
    public class ProjetosClientTest
    {
        private HttpSelfHostServer server;
        private ProjetosClient projetos;

        [TestInitialize]
        public void Setup()
        {
            server = new ThirdPartyServicesHelper().SubirServidor();
            projetos = new ProjetosClient(new HttpClient());
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (server != null)
            {
                server.CloseAsync();
            }
        }

        [TestMethod]
        public void DeveListarTodosProjetos()
        {
            var expected = new ProjetosDbContext().Projetos.Count();
            var actual = projetos.Listar().Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeveObterProjetoPorId()
        {
            var expected = "Vencer Raphael no Mortal Kombat";
            var actual = projetos.ObterPorId(2).Nome;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DevePostarUmNovoProjeto()
        {
            var count = new ProjetosDbContext().Projetos.Count();
            projetos.Postar(
                new Projeto
                {
                    Nome = "Teste",
                    HorasTrabalhadas = 0
                });
            var expected = count + 1;
            var actual = projetos.Listar().Count();
            Assert.AreEqual(expected, actual);
        }
    }
}
