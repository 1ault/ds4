using Laboratorio203.Models.WS.Laptops;
using Laboratorio203.Models.WS.Reply;
using Laboratorio203.Services.SQLServer;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Laboratorio203.Controllers
{
    public class AcessController : ApiController
    {

        private SQLServer sql_server = new SQLServer();

        // GET: api/Acess/get
        [HttpGet]
        public Reply<List<Laptops>> Get()
        {

            List<Laptops> list = new List<Laptops>();

            sql_server.DBProductosLaptopSelect();

            while (sql_server.ListRead())
            {
                try
                {
                    var row_data = this.sql_server.ListData();
                    Laptops laptops = new Laptops
                    {
                        id = row_data["id"].ToString(),
                        nombre = row_data["nombre"].ToString(),
                        precio = row_data["precio"].ToString(),
                        stock = row_data["stock"].ToString()
                    };

                    list.Add(laptops);
                }
                catch (Exception ex)
                {
                    //throw new Exception($"[Get json error]: {ex}");
                    //MessageBox.Show($"[Err]: Parsing error. {ex}");
                    return new Reply<List<Laptops>>
                    {
                        Result = 1,
                        Message = $"[Err]: Laptops {ex}",
                        Data = list
                    };
                }
            }

            return new Reply<List<Laptops>>
            {
                Result = 0,
                Message = "[Ok]: Laptops data",
                Data = list
            };
        }

        // GET: api/Acess/get/1
        // api/Acess/get/1
        // https://localhost:44386/api/Acess/get/1
        [HttpGet]
        public Laptops Get(int id)
        {

            this.sql_server.DBProductosLaptopIdSelect(id);

            Laptops item;

            if (this.sql_server.ListRead())
            {

                var row_data = this.sql_server.ListData();

                item = new Laptops
                {
                    id = row_data["id"].ToString(),
                    nombre = row_data["nombre"].ToString(),
                    precio = row_data["precio"].ToString(),
                    stock = row_data["stock"].ToString()
                };
            }
            else
            {
                item = new Laptops
                {
                    id = "",
                    nombre = "",
                    precio = "",
                    stock = ""
                };
            }

            this.sql_server.Quit();
            return item;
        }

        // Inset
        // POST: api/Acess/Post
        [HttpPost]
        public Reply<String> Post([FromBody]Laptops value)
        {

            Debug.WriteLine($"{value}");
            Debug.WriteLine($"{value.id} {value.nombre} {value.precio} {value.stock}");

            try
            {
                Convert.ToDouble(value.precio);
                Convert.ToInt32(value.stock);
            }
            catch (FormatException ex)
            {
                return new Reply<string>
                {
                    Result = 1,
                    Message = "[Err] Post",
                    Data = $"Not parser {ex}",
                };
            }

            this.sql_server.DBProductosLaptopInsert(new Laptops
            {
                id = value.id,
                nombre = value.nombre,
                precio = value.precio,
                stock = value.stock
            });


            return new Reply<string>
            {
                Result = 0,
                Message = "[Ok] Post/Inset/Create",
                Data = $"Laptop id: {value.id}",
            };
        }

        // Update
        // PUT: api/Acess/Put/5
        //public void Put(int id, [FromBody] Laptops value)
        [HttpPut]
        public Reply<string> Put([FromBody]Laptops value)
        {
            this.sql_server.DBProductosLaptopUpdate(new Laptops
            {
                id = value.id,
                nombre = value.nombre,
                precio = value.precio,
                stock = value.stock
            });

            
            return new Reply<string>
            {
                Result = 0,
                Message = "[Ok] Put/Update",
                Data = $"Laptop",
            };
        }

        // DELETE: api/Acess/5
        [HttpDelete]
        public Reply<string> Delete([FromBody] Laptops value)
        {
            this.sql_server.DBProductosLaptopIdDelete(new Laptops
            {
                id = value.id,
                nombre = value.nombre,
                precio = value.precio,
                stock = value.stock
            });


            return new Reply<string>
            {
                Result = 0,
                Message = "[Ok] Delete",
                Data = $"Laptop",
            };
        }
    }
}
