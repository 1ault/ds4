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

        static public string UserLogin(User user)
        {

            SQLServer sql_server = new SQLServer();

            var result = sql_server.UserInsert(user);

            return "";
        }

        //return new HttpStatusCodeResult(200);     // OK
        //return new HttpStatusCodeResult(400);     // Bad Request
        //return new HttpStatusCodeResult(401);     // Unauthorized
        //return new HttpStatusCodeResult(404);     // Not Found
        static public Reply<string> UserRegister(User user)
        {
            return SQLServer.UserInser(user);
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