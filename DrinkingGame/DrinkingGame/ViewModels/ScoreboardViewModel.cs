using DrinkingGame.Models;
using DrinkingGame.Services;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    public class ScoreboardViewModel : BaseViewModel
    {
        private Game Game = (Application.Current as App).Game;
        public List<Player> Players { get; private set; }
        public int Score { get; private set; }

        public ScoreboardViewModel()
        {
            Players = Game.Players;
            Score = Game.Goal;
        }
    }
}
