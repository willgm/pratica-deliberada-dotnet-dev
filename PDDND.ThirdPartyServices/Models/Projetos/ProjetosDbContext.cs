using PDDND.ThirdPartyServices.Projetos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PDDND.ThirdPartyServices.Projetos
{
    public class ProjetosDbContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
    }
}