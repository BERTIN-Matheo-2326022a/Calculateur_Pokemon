using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonCore;

namespace CalculateurPokemon.Classes
{
    public static class NatureList
    {
        public static List<Nature> Natures =
        [
            new Nature("Serious", "None", "None"),
            new Nature("Solo", "atk", "def"),
            new Nature("Rigide", "atk", "spatq"),
            new Nature("Mauvais", "atk", "spdef"),
            new Nature("Brave", "atk", "vit"),
            new Nature("Assuré", "def", "atk"),
            new Nature("Malin", "def", "spatq"),
            new Nature("Lâche", "def", "spdef"),
            new Nature("Relax", "def", "vit"),
            new Nature("Modeste", "spatq", "atk"),
            new Nature("Doux", "spatq", "def"),
            new Nature("Foufou", "spatq", "spdef"),
            new Nature("Discret", "spatq", "vit"),
            new Nature("Calme", "spdef", "atk"),
            new Nature("Gentil", "spdef", "def"),
            new Nature("Prudent", "spdef"," spatq"),
            new Nature("Malpoli", "spdef", "vit"),
            new Nature("Timide", "vit", "atk"),
            new Nature("Pressé", "vit", "def"),
            new Nature("Jovial", "vit", "spatq"),
            new Nature("Naïf", "vit", "spdef"),
        ];
    }
}
