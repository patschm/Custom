using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Models;
using Newtonsoft.Json;

namespace TheClient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            LeestMetingen();
            PostMeting();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            LeestMetingen();
            Console.ReadLine();
        }

        private static async void PostMeting()
        {
            var m1 = new MeetResult
            {
                SerialNumber = "Serie 3",
                TypeNummer = "Type 3",
                Resultaten = new string[] { "Resultaat 4", "Resultaat 5" }
            };
            string jdata = JsonConvert.SerializeObject(m1);
            StringContent content = new StringContent(jdata);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await client.PostAsync("meting/add", content);
            Console.WriteLine(result.StatusCode);
        }

        private static async void LeestMetingen()
        {
            var result = await client.GetAsync("meting/results");
            if (result.IsSuccessStatusCode)
            {
                string data = await result.Content.ReadAsStringAsync();
                //Console.WriteLine(data);
                var list = JsonConvert.DeserializeObject<List<MeetResult>>(data);
                
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.SerialNumber} {item.TypeNummer}");
                    foreach (var res in item.Resultaten)
                    {
                        Console.WriteLine(res);
                    }
                    Console.WriteLine("=======================================");
                }
               // Console.WriteLine(data);
            }
        }
    }
}
