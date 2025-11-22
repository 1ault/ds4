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

        // api/Access/DBCalc

        // api/end_point/get/
        [HttpGet]
        //public IEnumerable<Historial> DBCalc()
        public Reply<List<Historial>> DBCalc()
        {
            // Api
            // Guard


            List<Historial> list_historial = new List<Historial>();

            sql_server.SelectCalcHistorial();

            while (sql_server.Read())
            {
                try
                {
                    var historial = new Historial
                    {
                        Id = Convert.ToInt64(sql_server.List()["id"]),
                        Num1 = Convert.ToDouble(sql_server.List()["Num1"]),
                        Op = Convert.ToChar(sql_server.List()["Op"]),
                        Num2 = Convert.ToDouble(sql_server.List()["Num2"])
                    };

                    list_historial.Add(historial);
                }
                catch (Exception ex)
                {
                    //throw new Exception($"[Get json error]: {ex}");
                    //MessageBox.Show($"[Err]: Parsing error. {ex}");
                    return new Reply<List<Historial>>
                    {
                        Result = 0,
                        Message = "[Err]: Historial Error",
                        Data = list_historial
                    };
                }
            }


            return new Reply<List<Historial>>
            {
                Result = 1,
                Message = "[OK]: Historial Load",
                Data = list_historial
            };
            //return list_historial;
            //list_historial
        }

        // api/Access/DBInfo
        [HttpGet]
        public IEnumerable<string> DBInfo()
        {
            //return new Reply
            //{
            //    Result = 1,
            //    Data = { },
            //    Message = "Mi Hello World en API"
            //};
            return new string[] { "value1", "value2" };
        }


        // GET: api/Access/get
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Access/get/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Access
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
