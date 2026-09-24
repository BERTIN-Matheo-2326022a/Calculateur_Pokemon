namespace CalculateurPokemon.Classes
{
    public class Pokemon
    {
        #region Attributs privés
        private string _nom;

        private string _spritePath;

        private Dictionary<string, int> _spreads = new Dictionary<string, int>
        {
            { "atq", 0 },
            { "def", 0 },
            { "spatq", 0 },
            { "spdef", 0 },
            { "vit", 0 }
        };

        private Nature _nature;

        private string _talent;

        private List<string> _faiblesses;

        private List<string> _doubleFaiblesses;

        private List<string> _resistances;

        private List<string> _immunites;

        #endregion

        #region Attributs publics

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string SpritePath
        {
            get { return _spritePath; }
            set { _spritePath = value; }
        }

        public Dictionary<string, int> Spreads
        {
            get { return _spreads; }
            set { _spreads = value; }
        }

        public Nature Nature
        {
            get { return _nature; }
            set { _nature = value; }
        }

        public string Talent
        {
            get { return _talent; }
            set { _talent = value; }
        }

        public List<string> Faiblesses
        {
            get { return _faiblesses; }
            set { _faiblesses = value; }
        }

        public List<string> DoubleFaiblesses
        {
            get { return _doubleFaiblesses; }
            set { _doubleFaiblesses = value; }
        }

        public List<string> Resistances
        {
            get { return _resistances; }
            set { _resistances = value; }
        }

        public List<string> Immunites
        {
            get { return _immunites; }
            set { _immunites = value; }
        }

        #endregion

        #region Constructeurs

        public Pokemon(string nom, string spritePath, Dictionary<string, int> spreads, Nature nature, string talent, List<string> faiblesses, List<string> doubleFaiblesses, List<string> resistances, List<string> immunites)
        {
            _nom = nom;
            _spritePath = spritePath;
            _spreads = spreads;
            _nature = nature;
            _talent = talent;
            _faiblesses = faiblesses;
            _doubleFaiblesses = doubleFaiblesses;
            _resistances = resistances;
            _immunites = immunites;
        }

        #endregion
    }
}
