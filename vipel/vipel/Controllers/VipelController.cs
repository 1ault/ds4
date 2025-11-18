using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using vipel.Models.WS.Historial;
using vipel.Models.WS.Reply;
using vipel.Services;




namespace vipel.Controllers
{
    public class VipelController : Controller
    {

        // GET: Vipel
        //public ActionResult Index()
        //{

        //    var item = await Api.Get<string>($"api/Access/DBCalc");
        //    return View(model: item);
        //}
        [HttpGet]
        public async Task<ActionResult> Index()
        {

            //var item = await Api.Get<string>("api/Access/DBCalc");
            //var item = await Api.Get<Historial[]>($"api/Access/DBCalc");
            var reply = await Api.Get< Reply<List<Historial>> >("api/Access/DBCalc");
            return View(model: reply.Data);
        }

        [HttpGet]
        public async Task<ActionResult> Calc()
        {

            var item = await Api.Get<Historial[]>($"api/Access/DBCalc");
            //var item = await Api.Get<List<Historial>>("api/Access/GetAll");
            //var item = await Api.Get<>("api/Access/GetAll");

            return View(model: item);
        }

        [HttpGet]
        public async Task<ActionResult> Info()
        {
            var item = await Api.Get<string>($"api/Access/DBInfo");
            return View(model: item);
        }
    }
}