using PDDND.ThirdPartyServices.Projetos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace PDDND.ThirdPartyServices.Projetos
{
    public class Configuration : DbMigrationsConfiguration<ProjetosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjetosDbContext context)
        {
            context.Projetos.AddOrUpdate(
                x => x.Id,
                new Projeto
                {
                    Id = 1,
                    Nome = "Vencer Breno no Mortal Kombat",
                    HorasTrabalhadas = 40
                },
                new Projeto
                {
                    Id = 2,
                    Nome = "Vencer Raphael no Mortal Kombat",
                    HorasTrabalhadas = 10
                },
                new Projeto
                {
                    Id = 3,
                    Nome = "Vencer Juliano no Mortal Kombat",
                    HorasTrabalhadas = 120
                }
            );
        }
    }
}