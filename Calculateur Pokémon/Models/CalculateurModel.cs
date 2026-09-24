using CalculateurPokemon.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurPokemon.Models
{
    internal class CalculateurModel
    {
        #region Attributs privés

        private Pokemon _pokemonSurvivant;

        private int? _pvMinLeft;

        private int? _soin;

        private Pokemon _pokemonAttaquant;

        private Attaque _attaque;

        private bool? _isMultiCible;

        #endregion

        #region Attributs publics

        public Pokemon PokemonSurvivant
        {
            get { return _pokemonSurvivant; }
            set { _pokemonSurvivant = value; }
        }

        public int? PvMinLeft
        {
            get { return _pvMinLeft; }
            set { _pvMinLeft = value; }
        }

        public int? Soin
        {
            get { return _soin; }
            set { _soin = value; }
        }
        
        public Pokemon PokemonAttaquant
        {
            get { return _pokemonAttaquant; }
            set { _pokemonAttaquant = value; }
        }

        public Attaque Attaque
        {
            get { return _attaque; }
            set { _attaque = value; }
        }

        public bool? IsMultiCible
        {
            get { return _isMultiCible; }
            set { _isMultiCible = value; }
        }

        #endregion

        #region Constructeurs

        public CalculateurModel(Pokemon pokemonSurvivant, Pokemon pokemonAttaquant, Attaque attaque)
        {
            _pokemonSurvivant = pokemonSurvivant;
            _pokemonAttaquant = pokemonAttaquant;
            _attaque = attaque;
        }

        #endregion
    }
}
