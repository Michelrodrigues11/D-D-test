using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dandd.Models.Services
{
    public class Races
    {
        private HttpClient client;
        private JsonSerializerOptions _serializerOptions;
        private const string baseUrl = "https://www.dnd5eapi.co/api/ability-scores/cha";

        public Races() { }


    }
}
