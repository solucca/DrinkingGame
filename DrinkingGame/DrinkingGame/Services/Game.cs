using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using DrinkingGame.Models;

namespace DrinkingGame.Services
{
    public class Game
    {
        public Player CurrentPlayer { get => Players[IndexPlayer]; }
        public List<Player> Players { get; set; }
        public CardDeck Deck { get; private set; }
        public int Goal { get; set; }
        public event EventHandler<bool> GameWon;

        int IndexPlayer = 0;
        
        public Game()
        {
            Players = new List<Player>();
            Goal = 40;
        }

        public bool BuildDeck(ICollection<Baralho> baralhos)
        {
            if (baralhos.Count == 0)
                return false;

            Deck = new CardDeck();
            foreach ( Baralho baralho in baralhos)
            {
                Deck.AddBaralho(baralho);
            }
            Deck.Shuffle();
            return true;
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
                    OnGameWon(true);
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

        protected virtual void OnGameWon(bool e)
        {
            if (GameWon != null)
            {
                GameWon(this, e);
            }
        }
    }
}
