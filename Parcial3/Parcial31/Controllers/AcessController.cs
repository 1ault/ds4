using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial31.Controllers
{
    public class AcessController : ApiController
    {
        // GET: api/Acess
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Acess/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Acess
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Acess/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acess/5
        public void Delete(int id)
        {
        }
    }
}
