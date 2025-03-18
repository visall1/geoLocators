using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace geoLocator
{
    public class Data
    {
        public string city { get; set;}
        public string ip { get; set;}
        public string region { get; set;}
        public string country { get; set;}
        public string postal { get; set;}
        public string loc { get; set;}
        public string org { get; set;}
        public string timezone { get; set;}
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "GeoLocator";
            Console.Write("Enter IP Address: ");
            string ip = Console.ReadLine();
            string url = $"https://ipinfo.io/{ip}/json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    Console.WriteLine("[+] Request Successful Made");

                    string responseData = await response.Content.ReadAsStringAsync();
                    Data ipInfo = JsonConvert.DeserializeObject<Data>(responseData);

                    Console.Clear();
                    Console.WriteLine($"IP: {ipInfo.ip}");
                    Console.WriteLine($"Country: {ipInfo.country}");
                    Console.WriteLine($"City: {ipInfo.city}");
                    Console.WriteLine($"Coordinates: {ipInfo.loc}");
                    Console.WriteLine($"Postal Code: {ipInfo.postal}");
                    Console.WriteLine($"Region: {ipInfo.region}");
                    Console.WriteLine($"ANS: {ipInfo.org}");

                    string[] Coords = ipInfo.loc.Split(',');
                    Console.WriteLine($"Google Map: https://www.google.com/maps/?q={Coords[0]},{Coords[1]}");
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Exception: {ex.Message}");
                }
            }
           
        }
    }
}
