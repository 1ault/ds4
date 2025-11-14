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
            return new Reply
            {
                Result = 1,
                Data = {},
                Message = "Mi Hello World en API"
            };
        }
    }
}
