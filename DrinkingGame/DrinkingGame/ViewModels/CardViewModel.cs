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
        public CardViewModel()
        {
            _deck = new CardDeck();
            Card = _deck.cards[_deck.current];

            NextCommand = new Command(() =>
            {
                _deck.current++;
                Card = _deck.cards[_deck.current];
                Console.WriteLine("Button Pressed");
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
