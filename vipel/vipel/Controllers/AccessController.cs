using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using vipel.Models.WS;
using vipel.Models.WS.Historial;
using vipel.Models.WS.Reply;
using vipel.Services;
using vipel.Services.SQLServer;


namespace vipel.Controllers
{
    public class AccessController : ApiController
    {

        private SQLServer sql_server = new SQLServer();

        // api/Access/DBCalc
        [HttpGet]
        //public IEnumerable<Historial> DBCalc()
         public Reply<List<Historial>> DBCalc()
        {

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


            return new Reply< List<Historial> >
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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Access/put/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Access/5
        public void Delete(int id)
        {
        }
    }
}
