using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurPokemon.Classes
{
    public class Attaque
    {
        #region Attributs privés
        private string _nom;
        private string _type;
        private int _puissance;
        private int _precision;
        private string _categorie;
        #endregion
        #region Attributs publics
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Puissance
        {
            get { return _puissance; }
            set { _puissance = value; }
        }
        public int Precision
        {
            get { return _precision; }
            set { _precision = value; }
        }
        public string Categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }
        #endregion
    }
}
