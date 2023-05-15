using MuMerch.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MuMerch.Clients
{
    public class MuMerchClientGet
    {
        public static async Task<T> Get<T>(string actionUrl, string authToken = null)
        {
            T item = default(T);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.baseUrl);

                if (!string.IsNullOrEmpty(authToken))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }

                var response = await client.GetAsync(actionUrl);

                if (response.IsSuccessStatusCode)
                {
                    item = await response.Content.ReadAsAsync<T>();
                }
            }

            return item;
        }


    }
}