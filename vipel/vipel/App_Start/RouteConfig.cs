using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace vipel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("api/{*pathInfo}");


            //routes.MapRoute(
            //    name: "Api",
            //    url: "api/{controller}/{action}/{id}",
            //    defaults: new { id = UrlParameter.Optional }
            //);


         

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Vipel", action = "Index" }
            );

            routes.MapRoute(
                name: "Register",
                url: "register",
                defaults: new { controller = "Vipel", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vipel", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "Vipel|Index|Api|Login|..." } // this is basically a regular expression
            );

            routes.MapRoute(
             name: "Anything",
             url: "{*anything}",
             defaults: new { controller = "Vipel", action = "Index" }
            );


            routes.MapRoute(
                name: "NotFound1",
                url: "{*url}",
                defaults: new { controller = "Vipel", action = "Debug" }
            );

            routes.MapRoute(
                name: "NotFound2",
                url: "{*.*}",
                defaults: new { controller = "Vipel", action = "Debug" }
            );

            routes.MapRoute(
                name:  "NotFound3",
                url:  "{*.}",
                defaults: new { controller = "Vipel", action = "Debug" }
            );

            routes.MapRoute(
                name: "NotFound0",
                url: "{anything}",
                defaults: new { controller = "Vipel", action = "Debug" }
            );



        }
    }
}
