using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial31.Models.WS.ServerConfig;

namespace Parcial31.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ServerConfig model = new ServerConfig
            {
                EndpointAcess = "https://localhost:44386/api/Acess/"
            };

            

            return View(model);
        }
    }
}
