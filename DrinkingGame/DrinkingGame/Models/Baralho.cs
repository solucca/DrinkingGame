using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Models
{
    public class Baralho
    {
        public string Nome { get; set; }
        public string Descr { get; set; }
        public List<Card> Cards { get; set; }
        public string Filename { get; set; }
        public int Count { get => Cards.Count; }
    }

    public class Baralho_DB
    {
        public string Nome { get; set; }
        public string Descr { get; set; }
    }
}
