using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vipel.Models.WS.Reply
{
    public class Reply<T>
    {
        public bool Result { get; set; } // success = true, failure = false
        public string Message { get; set; }
        public T Data { get; set; }
    }
}