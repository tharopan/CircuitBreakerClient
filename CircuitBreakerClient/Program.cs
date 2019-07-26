using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CircuitBreakerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come to Circuit Breaker Client\n--------------------------------------");
            int index = 0;
            while (index < 100)
            {
                Console.WriteLine(index);
                CircuitBreakerClient("http://localhost", "cartid/9817ee95-8c97-4317-9662-a01785b00e7f");
                index++;
            }

            Console.ReadKey();
        }


        public static async Task CircuitBreakerClient(string baseUrl, string apiMethod)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                ////GET Method "api/Department/1"
                //HttpResponseMessage response = await client.GetAsync(apiMethod);

                //if (response.IsSuccessStatusCode)
                //{
                //    var resp = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine(resp);
                //}
                //else
                //{
                //    Console.WriteLine("Internal server Error");
                //}

                Console.WriteLine("Internal server Error");
            }
        }
    }
}
