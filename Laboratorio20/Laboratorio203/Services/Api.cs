using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using Newtonsoft.Json;

namespace Laboratorio203.Services.Api
{
    public static class Api
    {

        private static readonly string BaseUrl = "https://localhost:44379/";

        private static readonly HttpClient _httpClient;

        static Api()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (m, c, ch, e) => true
            };

            _httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(BaseUrl),
                Timeout = TimeSpan.FromSeconds(15)
            };
        }

        public static async Task<T> Get<T>(string relativePath)
        {
            try
            {
                var json = await _httpClient.GetStringAsync(relativePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (FormatException ex)
            {
                throw new Exception($"[Get Json Err]: {ex}");
            }

        }

    }
}