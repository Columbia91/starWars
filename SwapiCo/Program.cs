using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace SwapiCo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите идентификатор персонажа из саги \"Звездные войны\": ");
            string identifier = Console.ReadLine();
            string path = $"https://swapi.co/api/people/" + identifier;

            List<StarWarsCharacters> characters = new List<StarWarsCharacters>();
            NetDataContractSerializer formatter = new NetDataContractSerializer();

            try
            {
                using (FileStream fs = new FileStream("file.xml", FileMode.OpenOrCreate))
                {
                    characters = (List<StarWarsCharacters>)formatter.Deserialize(fs);

                    foreach (var person in characters)
                    {
                        if (person.Url == path)
                        {
                            person.Show();
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Информация о таком персонаже в нашей базе отсутствует, " +
                    "выполняем запрос на сайт \"Swapi.co\"...");
            }

            var personage = RequestForSwapiCo(path);
            personage.Show();

            characters.Add(personage);
            using (FileStream fs = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, characters);
            }
            //var file = new FileInfo("file.xml");
        }
        static StarWarsCharacters RequestForSwapiCo(string path)
        {
            string json;

            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(path);
            }

            var personage = JsonConvert.DeserializeObject<StarWarsCharacters>(json);
            return personage;
        }
    }
}
