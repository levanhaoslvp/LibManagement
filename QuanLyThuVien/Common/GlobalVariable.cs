using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Common
{
    class GlobalVariable
    {
        public static string url = "https://localhost:44353/";
        public async Task<string> GetApiAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage Response = await client.GetAsync(url);
                if (Response.IsSuccessStatusCode)
                {
                    var responseJsonString = await Response.Content.ReadAsStringAsync();
                    return responseJsonString;
                }
                else
                {
                    return Response.ReasonPhrase;
                }
            }
        }
        public bool PostApi(string url, string body)
        {
            HttpClient client = new HttpClient();
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
