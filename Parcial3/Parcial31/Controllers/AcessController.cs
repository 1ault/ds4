using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Parcial31.Models.WS;
using Parcial31.Services;

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

        [System.Web.Http.HttpPost]
        public Reply<User> Login([FromBody] User user)
        {
            //System.Diagnostics.Debug.WriteLine($"{user}");
            //System.Diagnostics.Trace.WriteLine($"{user}");
            return Guard.UserLogin(user);
        }

        //INser
        // POST: api/Acess/Post
        public void Post([FromBody]string value)
        {


        }

        //Update
        // PUT: api/Acess/Put/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acess/Delete/5
        public void Delete(int id)
        {
        }
    }
}
