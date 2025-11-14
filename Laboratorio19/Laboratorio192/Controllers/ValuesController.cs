using Laboratorio192.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio192.Controllers
{
    public class ValuesController : Controller
    {
        // GET /Values/Index
        // calls https://localhost:44305/api/values/get
        public async Task<ActionResult> Index()
        {
            var items = await Api.Get<string[]>("api/values/get");
            return View(items);
        }
    }
}