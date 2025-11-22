using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace vipel.Controllers
{
    public class AcessController : ApiController
    {
        private SQLServer sql_server = new SQLServer();

        // GET: api/Access/Get
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Access/Get/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Access/Post
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Access/put/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Access/5
        public void Delete(int id)
        {
        }
 

    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace vipel.Controllers
//{
//    public class VilController : ApiController
//    {
//        // GET: api/Vil/get/
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET: api/Vil/get/index
//        // GET: api/Vil/get/calc
//        // GET: api/Vil/get/info
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/Vil
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT: api/Vil/5
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE: api/Vil/5
//        public void Delete(int id)
//        {
//        }
//    }
//}


////// GET: api/Values
////public IEnumerable<string> Get()
////{
////    return new string[] { "value1", "value2" };
////}

////// GET: api/Values/5
////public string Get(int id)
////{
////    return "value";
////}

////// POST: api/Values
////public void Post([FromBody] string value)
////{
////}

////// PUT: api/Values/5
////public void Put(int id, [FromBody] string value)
////{
////}

////// DELETE: api/Values/5
////public void Delete(int id)
////{
////}













































////using System;
////using System.Collections.Generic;
////using System.Data.SqlClient;
////using System.Linq;
////using System.Net;
////using System.Net.Http;
////using System.Web.Http;
////using System.Windows.Forms;
////using vipel.Models.WS;
////using vipel.Models.WS.Historial;
////using vipel.Models.WS.Reply;
////using vipel.Services;
////using vipel.Services.SQLServer;


////namespace vipel.Controllers
////{
