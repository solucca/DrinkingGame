using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Models
{
    public class Baralho
    {
        public string Nome { get; set; }
        public string Descr { get; set; }
        public int Count { get => Cards.Count; }
        public List<Card> Cards { get; set; }
        public bool Selected { get ; set; }
        public string Filename { get; set; }
        
    }
}
