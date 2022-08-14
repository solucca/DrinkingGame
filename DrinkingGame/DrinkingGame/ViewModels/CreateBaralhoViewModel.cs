using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Models;
using DrinkingGame.Views;
using DrinkingGame.Services;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace DrinkingGame.ViewModels
{
    public class CreateBaralhoViewModel : BaseViewModel
    {
        public ObservableCollection<Card> Cards { get; set; } = new ObservableCollection<Card>();

        public string Name { 
            get => name;
            set { name = value; OnPropertyChanged(); } 
        }
        private string name;

        private CustomDecks CustomDecks = (Application.Current as App).CustomDecks;

        public void SaveBaralho(string descr) 
        {
            var t = new List<Card>();
            foreach(var card in Cards) 
            {
                card.Baralho = Name;
                t.Add(card); 

            }

            Baralho novo = new Baralho()
            {
                Cards = t,
                Nome = Name,
                Descr = descr,
                Filename = "Custom"
            };

            CustomDecks.Baralhos.Add( novo );
            CustomDecks.AddCards( Cards );
            CustomDecks.AddBaralho( novo );
        }

        public Card CreateCard(string Tipo)
        {
            Card a = new Card() { Id = Cards.Count, Tipo = Tipo};
            Cards.Add(a);
            return a;
        }

        public void UpdateView()
        {
            ObservableCollection<Card> temp = new ObservableCollection<Card>();
            foreach (Card card in Cards)
            {
                if (card.Tipo != null)
                    temp.Add(card);
            }
            Cards.Clear();
            foreach (Card card in temp)
            {
                Cards.Add(card);
            }
        }
    }
}