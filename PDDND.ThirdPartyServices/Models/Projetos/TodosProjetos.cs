using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDDND.ThirdPartyServices.Projetos
{
    public class TodosProjetos
    {
        private IList<Projeto> todos;

        public TodosProjetos(IList<Projeto> todos)
        {
            this.todos = todos;
        }

        public IEnumerable<Projeto> Listar()
        {
            return todos;
        }

        public void Adicionar(Projeto projeto)
        {
            this.todos.Add(projeto);
        }
    }

}
