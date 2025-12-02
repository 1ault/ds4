using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using Parcial31.Models.WS;
using Parcial31.Services;


namespace Parcial31.Services
{
    public class Guard
    {

        static public Reply<User> UserLogin(User user)
        {

            //if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            //{
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                return new Reply<User>
                {
                    Result = false,
                    Message = $"",
                    Data = new User
                    {
                        ID = $"",
                        Username = $"",
                        Password = $"",
                        Role = $""
                    }
                };
            }

            return SQLServer.UserLogin(user);
        }


    }
}