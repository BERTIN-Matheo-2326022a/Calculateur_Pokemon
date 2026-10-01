using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class PokeApiImporter
    {
        private HttpClient _client = new HttpClient();

        public async Task GetAllPokemon()
        {
            var response = await _client.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=10000");
            response.EnsureSuccessStatusCode();
            string jsonPokemon = JsonSerializer.Serialize(response.Content);
            File.WriteAllText("allPokemon.json", jsonPokemon);
        }
    }
}
