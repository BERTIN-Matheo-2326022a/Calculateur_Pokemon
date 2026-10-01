using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonCore;

namespace PokemonBattle
{
    internal interface IPokemonRepository
    {
        Task<List<Pokemon>> GetAllAsync();

        Task<Pokemon?> GetByIdAsync(int id);
    }
}
