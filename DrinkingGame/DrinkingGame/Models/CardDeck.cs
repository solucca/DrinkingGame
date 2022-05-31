using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DrinkingGame.Models
{
    public class CardDeck
    {
        /*
            Baralho Usado No jogo
         */
        public List<Card> Cards { get; set; }
        public Card Current { get => Cards[CurrentIndex];}
        private int CurrentIndex { get; set; }
        public CardDeck()
        {
            Cards = new List<Card> { };
            CurrentIndex = 0;
        }
    

        public void AddBaralho(List<Card> cards)
        {
            Cards.AddRange(cards);
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < Cards.Count - 1; i++)
            {
                int j = rand.Next(i, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
    
        public bool DrawCard()
        {
            if (CurrentIndex >= Cards.Count - 1)
            {
                return false;
            }
            CurrentIndex++;
            return true;
        }
    }

}
