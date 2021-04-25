using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FXRate.CrossCutting
{
    public class Utility
    {

        public static string HTTPGet(string url)
        {
            return Task.Run(() => HttpGetAsync(url.ToString())).GetAwaiter().GetResult();
        }

        private static async Task<string> HttpGetAsync(string url)
        {
            var result = string.Empty;
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }         

            return result;
        }
    }
}
