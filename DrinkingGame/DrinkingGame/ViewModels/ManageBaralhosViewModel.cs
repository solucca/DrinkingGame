using DrinkingGame.Models;
using DrinkingGame.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Views;

namespace DrinkingGame.ViewModels
{
    public class ManageBaralhosViewModel
    {
        private Game Game = (Application.Current as App).Game;

        public IEnumerable<Baralho> Baralhos { get => Game.Baralhos.Values;}
        public ICommand CreateNewBaralho { get; set; }
        public ManageBaralhosViewModel()
        {
            CreateNewBaralho = new Command(CreateNewBaralhoCommand);
        }

        private void CreateNewBaralhoCommand()
        {
            Shell.Current.GoToAsync(nameof(CreateBaralhoPage));
        }
    }
}
