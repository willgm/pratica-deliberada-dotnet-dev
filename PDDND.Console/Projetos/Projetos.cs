﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDDND.Console.Projetos
{
    public interface IProjetos
    {
        IEnumerable<Projeto> Listar();
    }

}