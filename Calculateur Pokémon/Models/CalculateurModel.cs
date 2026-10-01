using PokemonCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CalculateurPokemon.Models
{
    internal class CalculateurModel : INotifyPropertyChanged
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
            set
            {
                if (_pokemonSurvivant == value) return;
                _pokemonSurvivant = value;
                OnPropertyChanged(nameof(PokemonSurvivant));
            }
        }

        public int? PvMinLeft
        {
            get { return _pvMinLeft; }
            set
            {
                if (_pvMinLeft == value) return;
                _pvMinLeft = value;
                OnPropertyChanged(nameof(PvMinLeft));
            }
        }

        public int? Soin
        {
            get { return _soin; }
            set
            {
                if (_soin == value) return;
                _soin = value;
                OnPropertyChanged(nameof(Soin));
            }
        }
        
        public Pokemon PokemonAttaquant
        {
            get { return _pokemonAttaquant; }
            set
            {
                if (_pokemonAttaquant == value) return;
                _pokemonAttaquant = value;
                OnPropertyChanged(nameof(PokemonAttaquant));
            }
        }

        public Attaque Attaque
        {
            get { return _attaque; }
            set
            {
                if (_attaque == value) return;
                _attaque = value;
                OnPropertyChanged(nameof(Attaque));
            }
        }

        public bool? IsMultiCible
        {
            get { return _isMultiCible; }
            set
            {
                if (_isMultiCible == value) return;
                _isMultiCible = value;
                OnPropertyChanged(nameof(IsMultiCible));
            }
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

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
