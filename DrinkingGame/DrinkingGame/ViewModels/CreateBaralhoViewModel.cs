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

        private Baralho Baralho;
        private string Descrição;
        public CreateBaralhoViewModel()
        {
        }
        public CreateBaralhoViewModel(Baralho Baralho)
        {
            this.Baralho = Baralho;
            foreach (Card card in Baralho.Cards)
            {
                Cards.Add(card);
            }
            Name = Baralho.Nome;
        }
        public void DeleteBaralho()
        {
            if (Baralho != null)
            {
                if (CustomDecks.Baralhos.Contains(Baralho))
                {
                    CustomDecks.Baralhos.Remove(Baralho);
                    CustomDecks.RemoveCards(Baralho.Cards);
                    CustomDecks.RemoveBaralho(Baralho);
                    Baralho = null;
                }
            }
        }

        public void AddDescr(string descr)
        {
            Descrição = descr;
        }
        public int SaveBaralho() 
        {
            if (CustomDecks.CheckName(Name) && Baralho == null)
            {
                return -1;
            }
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
                Descr = Descrição,
                Filename = "Custom"
            };

            DeleteBaralho(); // delete baralho antigo (Salvo na variavel Baralho)

            CustomDecks.Baralhos.Add( novo );
            CustomDecks.AddCards( Cards );
            CustomDecks.AddBaralho( novo );
            Baralho = novo;
            return 0;
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