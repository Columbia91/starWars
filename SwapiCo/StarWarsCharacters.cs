using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwapiCo
{
    [Serializable]
    class StarWarsCharacters
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mass")]
        public string Mass { get; set; }

        [JsonProperty("hair_color")]
        public string Hair_color { get; set; }

        [JsonProperty("skin_color")]
        public string Skin_color { get; set; }

        [JsonProperty("eye_color")]
        public string Eye_color { get; set; }

        [JsonProperty("birth_year")]
        public string Birth_year { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("films")]
        public IList<string> Films { get; set; }

        [JsonProperty("species")]
        public IList<string> Species { get; set; }

        [JsonProperty("vehicles")]
        public IList<string> Vehicles { get; set; }

        [JsonProperty("starships")]
        public IList<string> Starships { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public void Show()
        {
            Console.WriteLine("name: " + Name +
                "\nheight: " + Species +
                "\nmass: " + Gender +
                "\nhair_color: " + House +
                "\nskin_color: " + DateOfBirth +
                "\neye_color: " + YearOfBirth +
                "\nbirth_year: " + Ancestry +
                "\ngender: " + EyeColour +
                "\nHairColour: " + HairColour +
                "\nWood: " + Wand.Wood +
                "\nCore: " + Wand.Core +
                "\nLength: " + Wand.Length +
                "\nPatronus: " + Patronus +
                "\nHogwartsStudent: " + HogwartsStudent +
                "\nHogwartsStaff: " + HogwartsStaff +
                "\nActor: " + Actor +
                "\nAlive: " + Alive +
                "\nImage: " + Image + "\n\n");
        }
    }
}
