using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using vipel.Models.WS.Historial;
using vipel.Models.WS.Reply;
using vipel.Services;
using vipel.Services.SQLServer;




namespace vipel.Controllers
{
    public class VipelController : Controller
    {

        [HttpGet]
        public async Task<ActionResult> Index()
        {

            var item = await Api.Get<string>("api/vil/get/Index");
            //var item = await Api.Get<Historial[]>($"api/Access/DBCalc");
            //var reply = await Api.Get<Reply<List<Historial>>>("api/Vipel/DBCalc");
            return View(model: item);
        }

        [HttpGet]
        public async Task<ActionResult> Calc()
        {

            var item = await Api.Get<Historial[]>("api/vil/get/Calc");
            //var item = await Api.Get<List<Historial>>("api/Access/GetAll");
            //var item = await Api.Get<>("api/Access/GetAll");

            return View(model: item);
        }

        [HttpGet]
        public async Task<ActionResult> Info()
        {
            var item = await Api.Get<string>($"api/vil/get/info");
            return View(model: item);
        }




    }
}


