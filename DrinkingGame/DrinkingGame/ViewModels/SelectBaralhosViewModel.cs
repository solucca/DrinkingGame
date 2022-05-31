using DrinkingGame.Models;
using DrinkingGame.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Views;

namespace DrinkingGame.ViewModels
{
    public class SelectBaralhosViewModel
    {
        private readonly Game Game = (Application.Current as App).Game;
        public List<Baralho> Baralhos { get; private set; }
        public ICommand Next { get; set; }

        public SelectBaralhosViewModel()
        {
            Baralhos = Game.Baralhos.Values.ToList();
            Next = new Command(NextPage);
        }

        async private void NextPage()
        {
            if ( Game.BuildDeck() )
                await Shell.Current.GoToAsync(nameof(PlayersPage));

        }
    }
}
