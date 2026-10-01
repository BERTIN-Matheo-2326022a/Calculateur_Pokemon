using PokemonCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class PokemonRepository : IPokemonRepository
    {
        public Task<List<Pokemon>> GetAllAsync()
        {
            string jsonFilePath = "pokemon.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            List<Pokemon>? pokemonList = System.Text.Json.JsonSerializer.Deserialize<List<Pokemon>>(jsonString);

            return Task.FromResult(pokemonList ?? []);
        }

        public Task<Pokemon?> GetByIdAsync(int id)
        {
            string jsonFilePath = "pokemon.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            List<Pokemon>? pokemonList = System.Text.Json.JsonSerializer.Deserialize<List<Pokemon>>(jsonString);
            Pokemon? pokemon = pokemonList?.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(pokemon);
        }
    }
}
