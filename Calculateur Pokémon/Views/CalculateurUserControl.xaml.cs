using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculateurPokemon.ViewModels;
using CalculateurPokemon.Models;
using PokemonCore;

namespace CalculateurPokemon.Views
{
    /// <summary>
    /// Logique d'interaction pour CalculateurUserControl.xaml
    /// </summary>
    public partial class CalculateurUserControl : UserControl
    {
        public CalculateurUserControl()
        {
            InitializeComponent();

            PokemonSet pokeSurvivant = new PokemonSet();

            var model = new CalculateurModel();
            this.DataContext = new CalculateurUserControlViewModel(model);
        }
    }
}
