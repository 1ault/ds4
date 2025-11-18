using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

using Laboratorio201.Models.WS.MulTable;

namespace Laboratorio201.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            return View(new MulTable());
        }

        [HttpPost]
        public ActionResult Index(string val = "")
        {
            long val_long;
            try
            {
                 val_long = Convert.ToInt64(val);
            }
            catch (Exception ex)
            {
                MulTable error_multable = new MulTable { msg = "Error parse: try a number"};

                return View(error_multable);
            }


            if (val_long <= 0)
            {
                return View(new MulTable { msg = $"[Err] Num 0 or Negative number: Input = {val_long}" });
            }



            MulTable mul_table = new MulTable();

            mul_table.msg = $"Tabla {val_long}x25 ";

            
            foreach (int i in Enumerable.Range(0, 26))
            {
                mul_table.result.Add($"{val_long}x{i} = {val_long * i}");
            }

            return View(mul_table);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}