using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DrinkingGame.Models
{
    public class CardDeck
    {
        public List<Card> cards { get; set; }
        public int current { get; set; }
        public CardDeck()
        {
            this.cards = new List<Card> { };
            this.current = 0;

            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("DrinkingGame.Resources.Cards.txt");
            string line = "";
            string[] fields;
            using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1"), true))
            {
                reader.ReadLine(); //remove first line
                while (reader.Peek() >= 0)
                {
                    line = reader.ReadLine();
                    fields = line.Split(';');
                    try
                    {
                        cards.Add(new Card(fields));
                    } catch
                    {
                        continue;
                    }
                    
                }
            }

            Random rand = new Random();
            for (int i = 0; i < cards.Count - 1; i++)
            {
                int j = rand.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
    }

}
