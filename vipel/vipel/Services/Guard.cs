using Azure;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using vipel.Models.WS;
using vipel.Models.WS.Reply;
using vipel.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace vipel.Services
{
    public class Guard
    {

        //return new HttpStatusCodeResult(200);     // OK
        //return new HttpStatusCodeResult(400);     // Bad Request
        //return new HttpStatusCodeResult(401);     // Unauthorized
        //return new HttpStatusCodeResult(404);     // Not Found
        static public Reply<string> UserRegister(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                    Data = "Name, Email and password are required. Please try again.",
                };
            }

            return SQLServer.UserInsert(user);
        }


        
         static public Reply<string> AdminSetRole(User user)
        {
            return SQLServer.AdminSetRole(user);
        }

            static public Reply<string> UserLogin(User user)
        {

            //if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            //{
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Email and password are required. Please try again.",
                    //Data = "Username, password and Email are required. Please try again.",
                    Data = "Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                };
            }

            return SQLServer.UserLogin(user);
        }

        static public Reply<List<User>> AdminGetUser()
        {
            return SQLServer.AdminGetUser();
        }

        static public Reply<List<Object>> UserGetPost()
        {
            return SQLServer.UserGetPost();
        }

        static public Reply<List<Object>> UserGetPostID(int id)
        {
            return SQLServer.UserGetPostID(id);
        }

        

        public static Task<Reply<string>> UserInsertPost(int pageId, PagePayload payload)
        {
            if (pageId < 1)
                return Task.FromResult(new Reply<string> { Result = false, Message = "Invalid PageID", Data = null });

            if (payload?.Modules == null || payload.Modules.Count == 0)
                return Task.FromResult(new Reply<string> { Result = false, Message = "No modules to insert", Data = null });

            return SQLServer.UserInsertPost(pageId, payload);
        }

        static public int CheckStatusCodeResult(HttpStatusCodeResult result)
        {
            if (result.StatusCode >= 400)
            {
                return 1;
            }

            return 0;
        }

        
        public Guard() 
        { 
        }

        

    }
}