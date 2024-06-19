using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WEBLET.Data
{
    public static class Api
    {
        public static async Task<List<T>> GetMethodObjectListAsync<T>(string Url)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(Url);
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = await Client.GetAsync(Client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    string user = await response.Content.ReadAsStringAsync();
                    List<T> Obj = JsonConvert.DeserializeObject<List<T>>(user);
                    return Obj;
                }
            }
            return default(List<T>);
        }
        public static async Task<T> GetMethodObjectObjAsync<T>(string Url)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(Url);
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = await Client.GetAsync(Client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    string user = await response.Content.ReadAsStringAsync();
                    T Obj = JsonConvert.DeserializeObject<T>(user);
                    return Obj;
                }
            }
            return default(T);
        }
        public static async Task<T> InsertDataObjectAsync<T>(string Url, Dictionary<string, string> data)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(Url);
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var content = new FormUrlEncodedContent(data);
                var response = await Client.PostAsync(Client.BaseAddress, content);
                if (response.IsSuccessStatusCode)
                {
                    string user = await response.Content.ReadAsStringAsync();
                    T responseData = JsonConvert.DeserializeObject<T>(user);
                    return responseData;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
