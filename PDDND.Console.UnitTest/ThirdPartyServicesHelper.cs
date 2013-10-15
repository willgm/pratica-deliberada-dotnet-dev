using PDDND.ThirdPartyServices.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace PDDND.Console
{
    public class ThirdPartyServicesHelper
    {
        public HttpSelfHostServer SubirServidor()
        {
            var config = new HttpSelfHostConfiguration("http://localhost:60000/");

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            var loadControllersAssemblyHack = typeof(ProjetosController).Assembly;
            var server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
            
            return server;
        }
    }
}
