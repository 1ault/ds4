using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace vipel
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //string root = Server.MapPath("~");
            //Env.Load(Path.Combine(root, ".env"));

            DotNetEnv.Env.Load(Server.MapPath("~/.env"));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            

        }
    }
}
