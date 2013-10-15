using PDDND.ThirdPartyServices.Projetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PDDND.ThirdPartyServices.Controllers
{
    public class ProjetosController : ApiController
    {
        private ProjetosDbContext db;

        public ProjetosController()
        {
            this.db = new ProjetosDbContext();
        }

        // GET api/projects
        public IEnumerable<Projeto> Get()
        {
            return db.Projetos.AsEnumerable();
        }

        // GET api/projects/1
        public Projeto Get(int id)
        {
            return db.Projetos.Single(x => x.Id == id);
        }

        // POST api/projects
        public void Post(Projeto x)
        {
            db.Projetos.Add(x);
            db.SaveChanges();
        }
    }
}