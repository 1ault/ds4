using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial31.Models.WS.Reply
{
    public class Reply<T>
    {
        public int Result { get; set; } = default;
        public string Message { get; set; } = default;
        public T Data { get; set; } = default;
    }
}