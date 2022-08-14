using DrinkingGame.Models;
using DrinkingGame.Services;
using DrinkingGame.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{

    internal class CardViewModel : BaseViewModel
    {
        public ICommand NextCommand { get; private set; }
        public Card Card { get => (Application.Current as App).Game.Deck.Current; }
        public string[] Visible { get => GetVisibility(Card); }
        public Game Game { get => (Application.Current as App).Game;}
        public List<Player> Players { get => (Application.Current as App).Game.Players; }
        public bool ShotsSwitch 
        { 
            get => _shotsSwitch;
            set
            {
                _shotsSwitch = value;
                OnPropertyChanged(nameof(ShotsSwitch));
            }
        }
        public bool PointsSwich
        {
            get => _pointsSwich;
            set
            {
                _pointsSwich = value;
                OnPropertyChanged(nameof(PointsSwich));
            }
        }
        public string CardName { get => FormatName(Card.Nome); }
        public string Color { get => GetColor(); }

        private bool _shotsSwitch;
        private bool _pointsSwich;

        public CardViewModel()
        {
            NextCommand = new Command(NextCard);
            ShotsSwitch = false;
            PointsSwich = false;
        }

        public void NextCard()
        {

            int Shots = 0, Points = 0;
            if (ShotsSwitch)
            {
                Shots = Card.Shots;
            }
            if (PointsSwich)
            {
                Points = Card.Pontos;
            }
            bool won = Game.PassTurn(Shots, Points);
           
            ShotsSwitch = false;
            PointsSwich = false;

            OnPropertyChanged(nameof(Game));
            OnPropertyChanged(nameof(Card));
            OnPropertyChanged(nameof(Visible));
            OnPropertyChanged(nameof(Players));
            OnPropertyChanged(nameof(CardName));
            OnPropertyChanged(nameof(Color));
        }

        private string[] GetVisibility( Card Card )
        {
            switch (Card.Tipo)
            {
                case "Desafio": 
                    return new string[] { "True", "False", "False", "False" }; 
                case "Jogo": 
                    return new string[] { "False", "True", "False", "False" };
                case "RNG": 
                    return new string[] { "False", "False", "True", "False" };
                case "Regra": 
                    return new string[] { "False", "False", "False", "True" };
            }

            return null;
        }
        
        private string FormatName(string Nome)
        {
            if (Nome.Contains("<jogador_x>"))
            {
                Player player = Game.CurrentPlayer;
                while (player == Game.CurrentPlayer)
                {
                    var random = new Random();
                    int index = random.Next(Players.Count);
                    player = Players[index];
                }
                return Nome.Replace("jogador_x", player.Name);
            }
            return Nome;
        }
        private string GetColor()
        {
            string color = ColorConverter.PlayerColors[Game.CurrentPlayer.Id];
            string type = Game.Deck.Current.Tipo;
            if (ColorConverter.TypeColors.ContainsKey(type))
            {
                return ColorConverter.TypeColors[type];
            }
            return color;
        }
    }
}
