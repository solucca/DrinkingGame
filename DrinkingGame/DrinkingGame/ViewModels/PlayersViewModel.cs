using DrinkingGame.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Services;

namespace DrinkingGame.ViewModels
{
    internal class PlayersViewModel : BaseViewModel
    {

        private Game Game = (Application.Current as App).Game;
        public string[] Players {
            get 
            { 
                return _players; 
            }
            set
            {
                if (value != _players)
                {
                    _players = value;
                    OnPropertyChanged(nameof(Players));
                }
            }
        }

        private int _maxPoints;
        public int MaxPoints { 
            get => _maxPoints;
            set
            {
                _maxPoints = value;
                OnPropertyChanged(nameof(MaxPoints));
            }
        }

        public string[] _players { get; set; }
        private int count_players = 2;

        public ICommand StartGame { get; }
        public ICommand RemovePlayer { get; }
        public ICommand AddPlayer { get; }


        public PlayersViewModel()
        {
            MaxPoints = 40;
            Players = new string[10];
            StartGame = new Command(startGame);
            RemovePlayer = new Command(removePlayer);
            AddPlayer = new Command(addPlayer);
        }
        public void addPlayer()
        {
            if (count_players < 10)
            {
                count_players++;
            }  
        }
        public void removePlayer()
        {
            if (count_players > 2)
            {
                count_players--;
            }
        }
        public async void startGame()
        {
            int i = 0;

            if (!(Players[0] is null || Players[1] is null))
            {
                foreach (var item in Players)
                {
                    if (item != null)
                    {
                        i++;
                    }
                }
            }

            if (i == count_players)
            {
                Game.SetPlayer(Players);
                await Shell.Current.GoToAsync(nameof(CardPage), true);
                Game.Goal = MaxPoints;
            }
            else
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine(count_players.ToString());
            }
        }
    }
}
