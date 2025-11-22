using Laboratorio203.Models.WS.ServerConfig;
using Laboratorio203.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio203.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServerConfig model = new ServerConfig {
                Endpoint = "https://localhost:44386/api/"
            };

            return View(model);
        }
    }
}
