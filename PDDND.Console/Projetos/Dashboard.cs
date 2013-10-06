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
            return Projetos.Listar().Sum(p => p.HorasTrabalhadas);
        }

        public IEnumerable<Projeto> OrdenarProjetosPorTotalHoras()
        {
            return Projetos.Listar().OrderBy(p => p.HorasTrabalhadas);
        }

        public IEnumerable<Projeto> OrdenarProjetosPorTotalHorasDecrescente()
        {
            return Projetos.Listar().OrderByDescending(p => p.HorasTrabalhadas);
        }

        public IEnumerable<Projeto> FiltrarProjetosPorTotalHorasMinimo(int x)
        {
            return Projetos.Listar().Where(p => p.HorasTrabalhadas >= x);
        }

        public IEnumerable<Projeto> FiltrarProjetosPorTotalHorasMaximo(int x)
        {
            return Projetos.Listar().Where(p => p.HorasTrabalhadas <= x);
        }
    }

}
