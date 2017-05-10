using ModernHttpClient;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace App2
{
    public class Class1
    {
        public async Task<string> GetMy()
        {
            try
            {
                HttpClient client = new HttpClient(new NativeMessageHandler());
                client.BaseAddress = new Uri("https://randomuser.me/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("api/");
                string content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (Exception ex)
            {
                var er = ex;
                return er.ToString();
            }
        }
    }
}
