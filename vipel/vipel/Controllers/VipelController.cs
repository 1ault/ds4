using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using vipel.Models.WS.Reply;
using vipel.Services;


using vipel.Models.WS.ServerConfig;
using System.Diagnostics;

namespace vipel.Controllers
{
    public class VipelController : Controller
    {

        //[HttpGet]
        public ActionResult Index()
        {
            //    Debug.WriteLine("dddddddddddddddddddddddddddddddddddd");
            //    Debug.WriteLine(DotNetEnv.Env.Load());
            //var item = await Api.Get<string>("api/vil/get/Index");
            //string endpoint = ;
            //var item = await Api.Get<Historial[]>($"api/Access/DBCalc");
            //var reply = await Api.Get<Reply<List<Historial>>>("api/Vipel/DBCalc");

            ServerConfig model = new ServerConfig
            {
                EndpointAcess = Environment.GetEnvironmentVariable("EndpointAcess"),
            };


            return View(model);
        }


        public ActionResult Debug(string url)
        {
            return Content($"Routed to MVC. url={url ?? "(null)"}");
        }

        //[HttpGet]
        //public async Task<ActionResult> Calc()
        //{

        //    var item = await Api.Get<Historial[]>("api/vil/get/Calc");
        //    //var item = await Api.Get<List<Historial>>("api/Access/GetAll");
        //    //var item = await Api.Get<>("api/Access/GetAll");

        //    return View(model: item);
        //}

        //[HttpGet]
        //public async Task<ActionResult> Info()
        //{
        //    var item = await Api.Get<string>($"api/vil/get/info");
        //    return View(model: item);
        //}




    }
}


