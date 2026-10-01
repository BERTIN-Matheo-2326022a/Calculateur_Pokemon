using CalculateurPokemon.Models;
using PokemonCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurPokemon.ViewModels
{
    internal class CalculateurUserControlViewModel
    {
        #region Attributs privés
        private CalculateurModel _model;
        #endregion

        #region Attributs publics
        public CalculateurModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        #endregion

        #region Constructeur(s)
        public CalculateurUserControlViewModel(CalculateurModel model) 
        {
            _model = model;
        }

        public CalculateurUserControlViewModel(Pokemon pokemonAttaquant, Pokemon pokemonSurvivant, Attaque attaque, int? pvMinLeft, int? soin, bool? isMultiCible)
        {
            _model = new CalculateurModel(pokemonAttaquant, pokemonSurvivant, attaque)
            {
                PvMinLeft = pvMinLeft,
                Soin = soin,
                IsMultiCible = isMultiCible
            };
        }
        #endregion

        #region Méthodes privées

        #endregion

        #region Méthodes publiques

        #endregion
    }
}
