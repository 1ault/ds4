using Laboratorio202.Models.WS.MatrizTable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebGrease;


namespace Laboratorio202.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new MatrizTable());
        }

        [HttpPost]
        public ActionResult Index(string val = "")
        {

            // val x val = n x n

            long val_long;
            try
            {
                val_long = Convert.ToInt64(val);
            }
            catch (Exception ex)
            {
                return View(new MatrizTable { msg = "Err parse: try a number" });
            }

            if (val_long <= 0) {
                return View(new MatrizTable { msg = $"[Err] Num 0 or Negative number: Input = {val_long}" });
            }

            MatrizTable mul_table = new MatrizTable
            {
                main_val = $"{val_long}",
                msg = $"{val_long} x {val_long}",

                //string[] matriz_n_x_n
                result = new string[val_long * val_long]
            };

            long control = (val_long * val_long) - (val_long + 1);
            //int one_time = 0;
            for (int i = mul_table.result.Length - 1; i >= 0; i = i - 1)
            {
                //if (i == ((mul_table.result.Length - (val_long * control)) - one_time))
                Trace.WriteLine($"|i: {i} | control: {control} | Check Next one: {control - val_long} |`Check Next more: {control - val_long + 1} ");
                if (i == 0)
                {
                    mul_table.result[i] = "0";
                    continue;
                }
                
                if (i == control + 1)
                {
                    //one_time = 1;
                    mul_table.result[i] = "1";
                    control = control - val_long + 1;
                } 
                else
                {
                    mul_table.result[i] = "0";
                }
            }

            // View > Output > Debug
            Debug.WriteLine($"Size: {mul_table.result.Length}");
            //Trace.WriteLine($"{mul_table.result[1]}");
            //Trace.WriteLine($"{mul_table.result[2]}");
            //Trace.WriteLine("Hello");

            for (int i = mul_table.result.Length - 1; i >= 0; i = i - 1)
            {
                Trace.WriteLine($"{i}:{mul_table.result[i]}");
            }


            return View(model: mul_table);
        }
    }
}
