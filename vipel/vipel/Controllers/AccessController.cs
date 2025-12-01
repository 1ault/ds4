using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using vipel.Models.WS;
using vipel.Models.WS.Reply;
using vipel.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace vipel.Controllers
{
    public class AccessController : ApiController
    {
        private SQLServer sql_server = new SQLServer();

        [System.Web.Http.HttpPost]
        public Reply<string> Login([FromBody] User user)
        {
            //System.Diagnostics.Debug.WriteLine($"{user}");
            //System.Diagnostics.Trace.WriteLine($"{user}");
            return Guard.UserLogin(user);
        }


        [System.Web.Http.HttpPost]
        //public Reply<string> Register(string username, string password, string email)
        public Reply<string> SingUp([FromBody] User user)
        {
            return Guard.UserRegister(user);
        }


        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<bool> UserCheck()
        {
            return new Reply<bool>
            {
                Result = true,
                Data = true,
                Message = "Token OK"
            };
        }

        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<User> UserStatus()
        {

            //    ID = identity.FindFirst(JwtRegisteredClaimNames.Sub).Value,
            //            Username = identity.FindFirst(JwtRegisteredClaimNames.UniqueName).Value,
            //            Role = identity.FindFirst(ClaimTypes.Role).Value

            //                "ID":null,
            //"Username": null,
            //"Password": null,
            //"Email": null,
            //"Role": null
            ClaimsIdentity identity = HttpContext.Current.JwtIdentityCheck();

            //identity.FindAll
            //identity.FindFirst()
            System.Diagnostics.Debug.WriteLine($"::::::::::::::::::::::::::::::::::::::::::");
            System.Diagnostics.Debug.WriteLine($"{identity.Name}");
            System.Diagnostics.Debug.WriteLine($"{identity.FindFirst(JwtRegisteredClaimNames.UniqueName)}");
            System.Diagnostics.Debug.WriteLine($"{identity.FindFirst("unique_name")}");
            System.Diagnostics.Debug.WriteLine($"{identity.NameClaimType}");
            System.Diagnostics.Debug.WriteLine($"{identity.Claims}");
            System.Diagnostics.Debug.WriteLine($"::::::::::::::::::::::::::::::::::::::::::");

            System.Diagnostics.Debug.WriteLine("::::::::::::::::::::::::::::::::::::::::::");
            foreach (var c in identity.Claims)
            {
                System.Diagnostics.Debug.WriteLine($"TYPE: {c.Type}");
                System.Diagnostics.Debug.WriteLine($"VALUE: {c.Value}");
            }
            System.Diagnostics.Debug.WriteLine("::::::::::::::::::::::::::::::::::::::::::");

            //ClaimsIdentity identity = (ClaimsIdentity)User.Identity;
            return new Reply<User>
            {
                Result = true,
                Message = "User Status Data",
                Data = new User
                {
                    ID = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value,
                    Username = identity.FindFirst(ClaimTypes.Name)?.Value,
                    Role = identity.FindFirst(ClaimTypes.Role)?.Value,
                }
            };
        }

        //[Authorize(Roles = "Admin")]
        //[HttpDelete]
        //public Reply<bool> DeleteUser(int id)
        //{
        //    // this can only be called by Admins
        //}



        // GET: api/Access/Get
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Access/Get/5
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

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

