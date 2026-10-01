namespace PokemonCore
{
    public class Pokemon
    {
        #region Attributs privés
        private int _id;

        private string _nom;

        private int _basePV;

        private int _baseAtq;

        private int _baseDef;

        private int _baseAtqSpe;

        private int _baseDefSpe;

        private int _baseVit;

        private List<string> _faiblesses;

        private List<string> _doubleFaiblesses;

        private List<string> _resistances;

        private List<string> _immunites;

        #endregion

        #region Attributs publics

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int BasePV
        { 
            get { return _basePV; }
            set { _basePV = value; }
        }

        public int BaseAtq
        {
            get { return _baseAtq; }
            set { _baseAtq = value; }
        }

        public int BaseDef
        {
            get { return _baseDef; }
            set { _baseDef = value; }
        }

        public int BaseAtqSpe
        {
            get { return _baseAtqSpe; }
            set { _baseAtqSpe = value; }
        }

        public int BaseDefSpe
        {
            get { return _baseDefSpe; }
            set { _baseDefSpe = value; }
        }

        public int BaseVit
        {
            get { return _baseVit; }
            set { _baseVit = value; }
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

        public Pokemon(int id, string nom, int basePV, int baseAtq, int baseDef, int baseAtqSpe, int baseDefSpe, int baseVit,
            List<string> faiblesses, List<string> doubleFaiblesses, List<string> resistances, List<string> immunites)
        {
            _id = id;
            _nom = nom;
            _basePV = basePV;
            _baseAtq = baseAtq;
            _baseDef = baseDef;
            _baseAtqSpe = baseAtqSpe;
            _baseDefSpe = baseDefSpe;
            _baseVit = baseVit;
            _faiblesses = faiblesses;
            _doubleFaiblesses = doubleFaiblesses;
            _resistances = resistances;
            _immunites = immunites;
        }

        #endregion
    }
}
