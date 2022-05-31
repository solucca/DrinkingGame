using DrinkingGame.Models;
using DrinkingGame.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    public class WinnerViewModel
    {
        public ICommand GoToMenu;
        public Game Game { get => (Application.Current as App).Game; }
        public Player Winner { get; set; }

        public WinnerViewModel()
        {
            Winner = Game.GetWinner();
            GoToMenu = new Command(GoBackToMenu);
        }

        private async void GoBackToMenu()
        {
            await Shell.Current.GoToAsync(nameof(MainViewModel));
        }
    }
}