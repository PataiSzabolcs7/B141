﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Iranyitoszamos;

namespace Iranyitoszamos
{
    internal class Program
    {
        static PostalCode postalCode = null;
        static async Task Main(string[] args)
        {
            string keresettIranyitoszam = "4060";
            await telepulesAdatok(keresettIranyitoszam);
            Console.WriteLine($"{postalCode.Places[0].PlaceName.ToString()} település irányítószáma: {keresettIranyitoszam}");
            Console.WriteLine($"{postalCode.Places[0].State} megye");
            Console.WriteLine($" Google Maps link: https://www.google.com/maps/place/{postalCode.Places[0].Latitude},{postalCode.Places[0].Longitude}");
            Console.WriteLine("vége");
            Console.ReadKey();
        }
        private static async Task telepulesAdatok(string irszam)
        {
            string url = $"http://api.zippopotam.us/hu/{irszam}";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();
            postalCode = PostalCode.FromJson(jsonString);

        }
    }
}
