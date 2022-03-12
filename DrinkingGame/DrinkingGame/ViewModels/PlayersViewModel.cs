using DrinkingGame.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    internal class PlayersViewModel : INotifyPropertyChanged
    {
        public string[] Players {
            get { 
                return _players; 
            }
            set
            {
                if (value != _players)
                {
                    _players = value;
                    RaisePropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public string[] _players { get; set; }
        private int count_players = 2;

        public ICommand StartGame { get; }
        public ICommand RemovePlayer { get; }
        public ICommand AddPlayer { get; }
        public PlayersViewModel()
        {
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

            if (!(Players[0] is null && Players[1] is null))
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
                Console.WriteLine("Tudo Certo");
                (Application.Current as App).players.Add_player(Players);
                await Shell.Current.GoToAsync(nameof(CardPage));
            }
            else
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine(count_players.ToString());
            }
        }
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
