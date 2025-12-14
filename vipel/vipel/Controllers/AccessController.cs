using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Services.Description;
using vipel.Models.WS;
using vipel.Models.WS.Reply;
using vipel.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static vipel.Services.SQLServer;

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


        //// POST: api/Access/Post
        //public void Post([FromBody] string value)
        //{
        //}



        //// DELETE: api/Access/5
        //public void Delete(int id)
        //{
        //}

        //    {
        //// GET: api/Default
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Default/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Default
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Default/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/Default/5
        //public void Delete(int id)
        //{
        //}

        //[System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetImage(string id)
        {
            var hash = id;
            System.Diagnostics.Debug.WriteLine($"{hash}");
            var folder = HttpContext.Current.Server.MapPath("~/App_Data/uploads");
            var matches = Directory.GetFiles(folder, hash + ".*");

            if (matches.Length == 0)
                return Request.CreateResponse(HttpStatusCode.NotFound);

            var path = matches[0];
            var ext = Path.GetExtension(path).ToLowerInvariant();

            var contentType =
                ext == ".png" ? "image/png" :
                (ext == ".jpg" || ext == ".jpeg") ? "image/jpeg" :
                ext == ".gif" ? "image/gif" :
                ext == ".webp" ? "image/webp" :
                "application/octet-stream";

            var result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StreamContent(File.OpenRead(path));
            result.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return result;
        }

        [System.Web.Http.Authorize]
        [System.Web.Http.HttpPost]
        public async Task<Reply<string>> userInsertPost()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            if (!int.TryParse(userRole, out var role) || role < 1)
                return new Reply<string> { Result = false, Message = "Unauthorized", Data = null };

            if (!Request.Content.IsMimeMultipartContent())
                return new Reply<string> { Result = false, Message = "Expected multipart/form-data", Data = null };

            var uploadsFolder = HttpContext.Current.Server.MapPath("~/App_Data/uploads");
            Directory.CreateDirectory(uploadsFolder);

            var provider = new MultipartFormDataStreamProvider(uploadsFolder);
            await Request.Content.ReadAsMultipartAsync(provider);

            //var pageIdStr = provider.FormData["pageId"];
            //if (string.IsNullOrWhiteSpace(pageIdStr) || !int.TryParse(pageIdStr, out var pageId) || pageId < 1)
            //    return new Reply<string> { Result = false, Message = "Missing/invalid pageId", Data = null };

            var payloadJson = provider.FormData["payload"];
            if (string.IsNullOrWhiteSpace(payloadJson))
                return new Reply<string> { Result = false, Message = "Missing payload", Data = null };

            PagePayload payload;
            try { payload = JsonConvert.DeserializeObject<PagePayload>(payloadJson); }
            catch (Exception ex)
            {
                return new Reply<string> { Result = false, Message = "Invalid payload JSON: " + ex.Message, Data = null };
            }

            foreach (var file in provider.FileData)
            {
                var attachKey = file.Headers.ContentDisposition.Name?.Trim('"');
                var originalName = (file.Headers.ContentDisposition.FileName ?? "upload").Trim('"');
                var contentType = file.Headers.ContentType?.MediaType ?? "application/octet-stream";
                var tempPath = file.LocalFileName;

                if (!contentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase))
                {
                    File.Delete(tempPath);
                    continue;
                }

                var sha256 = Hash.ComputeSha256(tempPath);

                var extension = Path.GetExtension(originalName);
                if (string.IsNullOrWhiteSpace(extension)) extension = ".bin";
                extension = extension.ToLowerInvariant();

                var finalName = sha256 + extension;
                var finalPath = Path.Combine(uploadsFolder, finalName);

                if (File.Exists(finalPath)) File.Delete(tempPath);
                else File.Move(tempPath, finalPath);

                var privateUrl = "/access/GetImage/" + sha256;

                var module = payload.Modules.FirstOrDefault(m =>
                    m.Data?.Image != null && m.Data.Image.AttachKey == attachKey);

                if (module != null)
                {
                    module.Data.Image.OriginalName = originalName;
                    module.Data.Image.type = extension;
                    module.Data.Image.Url = privateUrl;
                    module.Data.Image.Hash = sha256;

                }
            }

            int pageIdOrigin = await SQLServer.PageCreate();
            return await Guard.UserInsertPost(pageIdOrigin, payload);
        }

        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<List<Object>> UserGetPost()
        {
            var identity = (ClaimsIdentity)User.Identity;

            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            System.Diagnostics.Debug.WriteLine($"Role = {userRole}");
            System.Diagnostics.Debug.WriteLine($"ssssssss = {Convert.ToInt32(userRole)}");

            if (Convert.ToInt32(userRole) >= 1)
            {
                return Guard.UserGetPost();
            }

            return new Reply<List<object>>
            {
                Result = false,
                Message = $"unauthorized Err",
                Data = new List<object>(),
            };

        }

        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<List<Object>> UserGetPost(int id)
        {
            var identity = (ClaimsIdentity)User.Identity;

            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            System.Diagnostics.Debug.WriteLine($"Role = {userRole}");

            if (Convert.ToInt32(userRole) >= 1)
            {
                return Guard.UserGetPostID(id);
            }

            return new Reply<List<object>>
            {
                Result = false,
                Message = $"Server error. Please try again later.",
                Data = new List<object>(),
            };

        }





        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<List<User>> AdminGetUser()
        {
            var identity = (ClaimsIdentity)User.Identity;

            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            System.Diagnostics.Debug.WriteLine($"Role = {userRole}");

            if (userRole == "100")
            {
                return Guard.AdminGetUser();
            }

            return new Reply<List<User>>
            {
                Result = false,
                Message = $"Error role.",
                Data = new List<User>(),
            };
        }


        // PUT: api/Access/put/5
        [System.Web.Http.Authorize]
        [System.Web.Http.HttpPut]
        public Reply<string> AdminSetRole([FromBody] User value)
        {
            var identity = (ClaimsIdentity)User.Identity;

            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            System.Diagnostics.Debug.WriteLine($"Set Roles = {value.ID}");
            System.Diagnostics.Debug.WriteLine($"Set Rolesssssss = {value.Role}");

            if (userRole == "100")
            {
                return Guard.AdminSetRole(value);
            }

            return new Reply<string>
            {
                Result = false,
                Message = $"Error role.",
                Data = "Error",
            };
        }



        [System.Web.Http.Authorize]
        [System.Web.Http.HttpGet]
        public Reply<object> UserGetAvatar()
        {
            var identity = (ClaimsIdentity)User.Identity;

            var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

            var serverPath = HttpContext.Current.Server.MapPath("~/App_Data/icon/");
            string imagePath = null;
            
            //if (userId == "100")
            //{
            //}
            imagePath = System.IO.Path.Combine(serverPath, $"2.png");

            if (!System.IO.File.Exists(imagePath))
            {
                return new Reply<object>
                {
                    Result = false,
                    Message = "File not found",
                    Data = "void"
                };
            }

            byte[] img_bytes = System.IO.File.ReadAllBytes(imagePath);
            string img_base64 = Convert.ToBase64String(img_bytes);

            var json = new
            {
                Image = img_base64,
                ContentType = "image/png"
            };

            return new Reply<Object>
            {
                Result = true,
                Message = "Image found",
                Data = json
            };
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

