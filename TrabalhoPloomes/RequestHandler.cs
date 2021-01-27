using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Security.Claims;

namespace TrabalhoPloomes
{
    class RequestHandler
    {

        private static string PLOOMES_API_PATH = "https://api2.ploomes.com/";
        private static HttpClient ploomesClient;
        private static string uk = "5ADA3864712EC6CE18E7B56A9F89B64CD9DBAB9A5BA0666ECDDAD8337BE3C18C02A631AC2DDEB70DBA131DD0BB8F33BB595F3A485678F6169967F773C4A57348";

        public static void instantiatePloomesConnection()
        {
            ploomesClient = new HttpClient();
            ploomesClient.DefaultRequestHeaders.Add("User-key", uk);
            ploomesClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static JArray MakePloomesRequest(string url, Method method, JObject json = null)
        {
            try
            {
                instantiatePloomesConnection();

                System.Threading.Thread.Sleep(1000);
                string response = string.Empty;
                url = PLOOMES_API_PATH + url;

                if (method == Method.GET)
                    response = ploomesClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                else if (method == Method.POST)
                {
                    if (json != null)
                        response = ploomesClient.PostAsync(url, new StringContent(json.ToString())).Result.Content.ReadAsStringAsync().Result;
                    else
                        response = ploomesClient.PostAsync(url, new StringContent(new JObject().ToString())).Result.Content.ReadAsStringAsync().Result;
                }
                else if (method == Method.DELETE)
                {
                    ploomesClient.DeleteAsync(url);
                    return null;
                }
                else if (method == Method.PATCH)
                {
                    var content = new ObjectContent<JObject>(json, new JsonMediaTypeFormatter());
                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), url) { Content = content };
                    response = ploomesClient.SendAsync(request).Result.Content.ReadAsStringAsync().Result;

                    Console.WriteLine(response.ToString());
                }
                return JsonConvert.DeserializeObject<JObject>(response)["value"] as JArray;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("ERROR in MakePloomesRequest method ---" + ex.Message);
                throw ex;
            }
        }
    }
}
