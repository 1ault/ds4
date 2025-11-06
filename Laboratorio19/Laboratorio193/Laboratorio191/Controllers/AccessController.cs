using Laboratorio191.Models.WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Laboratorio191.Controllers
{
    public class AccessController : ApiController
    {

        [HttpGet]
        public Reply HelloWorld()
        {
            Reply oR = new Reply();
            oR.Result = 1;
            oR.Message = "Mi Hello World en API";

            return oR;
        }


    }
}


