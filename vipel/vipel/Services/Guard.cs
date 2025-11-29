using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    Data = "Username and password are required. Please try again.",
                };
            }

            return SQLServer.UserInsert(user);
        }

        static public Reply<string> UserLogin(User user)
        {

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                return new Reply<string>
                {
                    Result = false,
                    Message = $"Bad request - {SQLServer.EnumHttp.HttpStatusBadRequest}",
                    Data = "Username, password and Email are required. Please try again.",
                };
            }

            return SQLServer.UserLogin(user);
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

        public void InitJWT()
        {

        }

        public void CheckJWT()
        {

        }
    }
}