using Laboratorio193.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio193.Controllers
{
    public class ValuesController : Controller
    {
        // GET: Value
        // GET /Values/Index
        // calls https://localhost:44305/api/values/get
        public async Task<ActionResult> Index()
        {
            var items = await Api.Get<string[]>("api/values/get");
            return View(items);
        }

        // GET /Values/Details/1
        // calls https://localhost:44305/api/value/get/1
        [HttpGet]
        public async Task<ActionResult> Details(int id = 1)
        {
            var item = await Api.Get<string>($"api/Values/get/{id}");
            return View(model: item);
        }
    }
}