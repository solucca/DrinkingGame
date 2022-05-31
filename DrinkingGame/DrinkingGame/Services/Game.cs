using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using DrinkingGame.Models;

namespace DrinkingGame.Services
{
    public class Game
    {
        public Player CurrentPlayer { get => Players[IndexPlayer]; }
        public CardDeck Deck { get; private set; }
        public Dictionary<string, Baralho> Baralhos { get; private set; }
        public int Goal { get; set; }

        int IndexPlayer = 0;
        public List<Player> Players;

        public Game()
        {
            Players = new List<Player>();
            Goal = 40;
            GetBaralhos();
        }

        public bool BuildDeck()
        {
            int i = 0;
            Deck = new CardDeck();
            foreach(Baralho bar in Baralhos.Values)
            {
                if (bar.Selected)
                {
                    Deck.AddBaralho(bar.Cards);
                    i++;
                }
            }
            
            if (i > 0)
            {
                Deck.Shuffle();
                return true;
            }
            return false;
        }

        private void GetBaralhos()
        {
            Baralhos = new Dictionary<string, Baralho>();
            Card card;
            var assembly = Assembly.GetExecutingAssembly();

            Stream stream = assembly.GetManifestResourceStream("DrinkingGame.Resources.Cards.txt");
            string line = "";
            string[] fields;
            using (var reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1"), true))
            {
                reader.ReadLine(); //remove first line
                while (reader.Peek() >= 0)
                {
                    line = reader.ReadLine();
                    fields = line.Split(';');
                    try
                    {
                        card = new Card(fields);
                        if (Baralhos.ContainsKey(card.Categoria))
                        {
                            Baralhos[card.Categoria].Cards.Add(card);
                        }
                        else
                        {
                            Baralhos.Add(card.Categoria, new Baralho { Cards = new List<Card> { card }, 
                                                                       Nome = card.Categoria });
                        }
                        
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
            stream = assembly.GetManifestResourceStream("DrinkingGame.Resources.Baralhos.txt");
            using (var reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1"), true))
            {
                while (reader.Peek() >= 0)
                {
                    line = reader.ReadLine();
                    fields = line.Split(':');
                    try
                    {
                        Baralhos[fields[0]].Filename = fields[1];
                        Baralhos[fields[0]].Descr = fields[2];
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
        }

        public void SetPlayer(string Name, int id)
        {
            Players.Add(
                new Player { Id = id,
                             Name = Name, 
                             Points = 0});
        }

        public void SetPlayer(string[] Names)
        {
            int id = 0;
            foreach (string Name in Names)
            {
                if (!(Name is null))
                {
                    SetPlayer(Name, id);
                    id++;
                } 
            }
        }

        public string IsGameOver()
        {
            foreach (Player Player in Players)
            {
                if (Player.Points >= Goal)
                {
                    return Player.Name;
                }
            }
            return null;
        }

        public bool PassTurn(int Shots, int Points)
        {
            if (Deck.Current.Tipo == "Desafio")
            {
                CurrentPlayer.Points += Shots + Points;
                if (CurrentPlayer.Points >= Goal)
                {
                    return true;
                }
                IndexPlayer++;
                if (IndexPlayer >= Players.Count)
                {
                    IndexPlayer = 0;
                }
            }
            Deck.DrawCard();
            return false;
        }
        public Player GetWinner()
        {
            Player max_player = null;
            foreach(Player Player in Players)
            {
                if (max_player == null)
                {
                    max_player = Player;
                }
                else
                {
                    if (max_player.Points < Player.Points)
                    {
                        max_player = Player;
                    }
                }
            }
            return max_player;
        }
    }
}
