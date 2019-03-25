using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SwapiCo
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            string path = $"https://swapi.co/api/people/10";



            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(path);
            }

            var characters = JsonConvert.DeserializeObject<StarWarsCharacters>(json);

            Console.WriteLine(json);


        }
    }
}
