using Laboratorio191.Models.WS;
using System;
using System.Collections.Generic;
using System.IO;
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

        // Obtener un elemento tomando el ID como parámetro
        private static void GetItem(int id)
        {
            var url = $"http://localhost:44305/item/{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                Console.WriteLine("Error: " + ex.Message);
            }
        }



    }
}


