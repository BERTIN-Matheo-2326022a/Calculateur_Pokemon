using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class PokemonSet
    {
        #region Attributs privés
        private Pokemon _pokemon;

        private Nature _nature;

        private Talent _talent;

        private Objet _objet;

        private StatSet _spreads;

        private List<Attaque> _attaques;
        #endregion

        #region Attributs publics
        public Pokemon Pokemon
        {
            get { return _pokemon; }
            set { _pokemon = value; }
        }

        public Nature Nature
        {
            get { return _nature; }
            set { _nature = value; }
        }

        public Talent Talent
        {
            get { return _talent; }
            set { _talent = value; }
        }

        public Objet Objet
        {
            get { return _objet; }
            set { _objet = value; }
        }

        public StatSet Spreads
        {
            get { return _spreads; }
            set { _spreads = value; }
        }

        public List<Attaque> Attaques
        {
            get { return _attaques; }
            set { _attaques = value; }
        }
        #endregion

        #region Constructeur(s)
        // Le constructeur statique ne doit pas avoir de modificateur d'accès
        public PokemonSet(int id)
        {
            _pokemon = PokemonRepository.GetByIdAsync(id).Result ?? throw new ArgumentException($"Aucun Pokémon trouvé avec l'ID {id}");
        }
        #endregion
    }
}
