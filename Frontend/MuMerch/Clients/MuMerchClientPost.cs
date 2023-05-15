using MuMerch.Utils.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MuMerch.Clients
{
    public class MuMerchClientPost
    {
        public static async Task<T> Post<T>(string actionUrl, object data, string authToken = null)
        {
            T result = default(T);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.baseUrl);
                if (!string.IsNullOrEmpty(authToken))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(actionUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(responseContent);
                }
            }
            return result;
        }
    }
}