using MuMerch.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MuMerch.Clients
{
    public class MuMerchClientGet
    {
        public static T Get<T>(string actionUrl, string authToken = null)
        {
            T item = default(T);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.baseUrl);
                if (!string.IsNullOrEmpty(authToken))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                }
                var responseTask = client.GetAsync(actionUrl);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<T>();
                    readTask.Wait();

                    item = readTask.Result;
                }
            }

            return item;
        }

    }
}