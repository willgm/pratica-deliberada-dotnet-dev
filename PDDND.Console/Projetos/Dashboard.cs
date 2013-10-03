using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDDND.Console.Projetos
{
    public class Dashboard
    {
        public Dashboard(IProjetos projetos)
        {
            Projetos = projetos;
        }

        public IProjetos Projetos { get; private set; }

        public int TotalHorasTrabalhadas()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> OrdenarProjetosPorTotalHoras()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> OrdenarProjetosPorTotalHorasDecrescente()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> FiltrarProjetosPorTotalHorasMinimo(int x)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> FiltrarProjetosPorTotalHorasMaximo(int x)
        {
            throw new NotImplementedException();
        }
    }

}
