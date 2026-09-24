using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurPokemon.Classes
{
    public class Nature
    {
        #region Attributs privés

        private string _nom;

        private string _boostedStat;

        private string _loweredStat;

        #endregion

        #region Attributs publics

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string BoostedStat
        {
            get { return _boostedStat; }
            set { _boostedStat = value; }
        }

        public string LoweredStat
        {
            get { return _loweredStat; }
            set { _loweredStat = value; }
        }

        #endregion

        #region Constructeurs

        public Nature(string nom, string boostedStat, string loweredStat)
        {
            _nom = nom;
            _boostedStat = boostedStat;
            _loweredStat = loweredStat;
        }

        #endregion
    }
}
