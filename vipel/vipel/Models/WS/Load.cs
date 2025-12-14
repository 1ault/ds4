using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vipel.Models.WS
{
    public class PagePayload
    {
        public List<PageModule> Modules { get; set; } = new List<PageModule>();
    }

    public class PageModule
    {
        public int IdType { get; set; }
        public int Order { get; set; }
        public ModuleData Data { get; set; }
    }

    public class ModuleData
    {
        [JsonProperty("image")]
        public ImageData Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ImageData
    {
        public string AttachKey { get; set; }
        public string OriginalName { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string Url { get; set; }
        public string Hash { get; set; }
    }

}