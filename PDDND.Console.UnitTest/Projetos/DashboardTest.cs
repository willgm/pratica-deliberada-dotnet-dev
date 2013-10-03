using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDDND.Console.Projetos
{
    class ProjetosStub : IProjetos
    {
        public IEnumerable<Projeto> Listar()
        {
            return new List<Projeto> {
            new Projeto {
                Nome = "Vencer Breno no Mortal Kombat",
                HorasTrabalhadas = 40
            },
            new Projeto {
                Nome = "Vencer Raphael no Mortal Kombat",
                HorasTrabalhadas = 10
            },
            new Projeto {
                Nome = "Vencer Juliano no Mortal Kombat",
                HorasTrabalhadas = 120
                },
            };
        }
    }

    [TestClass]
    public class DashBoardTest
    {
        Dashboard dashboard;

        [TestInitialize]
        public void setup()
        {
            dashboard = new Dashboard(new ProjetosStub());
        }

        [TestMethod]
        public void deveSomarTotalDeHoras()
        {
            var expected = 170;
            var actual = dashboard.TotalHorasTrabalhadas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deveOrdernarAscendentementePorTotalHoras()
        {
            var expected = new int[]{ 10, 40, 120 };
            var actual = dashboard.OrdenarProjetosPorTotalHoras().Select(p => p.HorasTrabalhadas).ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deveOrdernarDecrescentementePorTotalHoras()
        {
            var expected = new int[] { 120, 40, 10 };
            var actual = dashboard.OrdenarProjetosPorTotalHorasDecrescente().Select(p => p.HorasTrabalhadas).ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deveFiltrarPorTotalHorasMinimo()
        {
            var expected = 2;
            var actual = dashboard.FiltrarProjetosPorTotalHorasMinimo(20).Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deveFiltrarPorTotalHorasMaximo()
        {
            var expected = 1;
            var actual = dashboard.FiltrarProjetosPorTotalHorasMaximo(30).Count();
            Assert.AreEqual(expected, actual);
        }

    }
}
