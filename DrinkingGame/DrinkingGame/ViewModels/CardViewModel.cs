using DrinkingGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    internal class CardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand NextCommand { get; private set; }
        private CardDeck _deck;
        private Card _card;
        public Card Card {
            get
            {
                return _card;
            }
            set
            {
                _card = value;
                OnPropertyChanged(nameof(Card));
            }
        }
        public string Player
        {
            get
            {
                return _player;
            }
            set
            {
                if (_player != value)
                {
                    _player = value;
                    OnPropertyChanged(nameof(Player));
                }
            }
        }
        private string _player;
        public string[] Visible { 
            get { return _visible; }
            set
            {
                if (_visible != value)
                {
                    _visible = value;
                    OnPropertyChanged(nameof(Visible));
                }
            }
        }
        private string[] _visible;
        public CardViewModel()
        {
            _deck = new CardDeck();
            Player = (Application.Current as App).players.Atual;
            Card = _deck.cards[_deck.current];
            switch (Card.Tipo){
                case "Desafio": Visible = new string[] { "True", "False", "False", "False" };break;
                case "Jogo": Visible = new string[] { "False", "True", "False", "False" }; break;
                case "RNG": Visible = new string[] { "False", "False", "True", "False" }; break;
                case "Regra": Visible = new string[] { "False", "False", "False", "True" }; break;
            }

            NextCommand = new Command(() =>
            {
                _deck.current++;
                Card = _deck.cards[_deck.current];
                (Application.Current as App).players.PassTurn();
                Player = (Application.Current as App).players.Atual;
                switch (Card.Tipo)
                {
                    case "Desafio": Visible = new string[] { "True", "False", "False", "False" }; break;
                    case "Jogo": Visible = new string[] { "False", "True", "False", "False" }; break;
                    case "RNG": Visible = new string[] { "False", "False", "True", "False" }; break;
                    case "Regra": Visible = new string[] { "False", "False", "False", "True" }; break;
                }
            });

        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
