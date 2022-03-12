using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Services
{
    public class Players
    {
        private Dictionary<string, int> Values { get; set; }
        private int WinCond = 100;
        
        public Players()
        {
            Values = new Dictionary<string, int>();
        }
        public void Add_player(string Name)
        {
            Values[Name] = 0;
        }
        public void Add_player(string[] Names)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Values[Names[i]] = 0;
            }
        }
        public void Set_WinCondition(int value)
        {
            WinCond = value;
        }
        public string IsGameOver()
        {
            foreach (string Name in Values.Keys)
            {
                if (Values[Name] >= WinCond)
                {
                    return Name;
                }
            }
            return null;
        }
    }
}
