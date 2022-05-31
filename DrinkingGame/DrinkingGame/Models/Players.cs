using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Services
{
    public class Players
    {
        private List<string> Nomes { get; set; }
        private List<int> Pontos { get; set; }
        public string Atual
        {
            get { return Nomes[_current]; }
        }
        private int _current = 0;

        private int WinCond = 100;
        
        public Players()
        {
            Nomes = new List<string>();
            Pontos = new List<int>();
        }
        public void Add_player(string Name)
        {
            Nomes.Add(Name);
            Pontos.Add(0);
        }
        public void Add_player(string[] Names)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Nomes.Add(Names[i]);
                Pontos.Add(0);
            }
        }
        public void Set_WinCondition(int value)
        {
            WinCond = value;
        }
        public string IsGameOver()
        {
            for (int i = 0; i < Nomes.Count; i++)
            {
                if (Pontos[i] >= WinCond)
                {
                    return Nomes[i];
                }
            }
            return null;
        }
        public void PassTurn()
        {
            _current++;
            if (_current >= Nomes.Count)
            {
                _current = 0;
            }
        }
    }
}
