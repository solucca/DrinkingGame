using DrinkingGame.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DrinkingGame.Services
{
    public class CustomDecks
    {
        private readonly SQLiteConnection _database;
        public ObservableCollection<Baralho> Baralhos { get; set; }

        public CustomDecks()
        {
            string dbPath = Path.Combine( Environment.GetFolderPath(Environment
                                          .SpecialFolder.LocalApplicationData), "gamedata.db" );

            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Card>();

            Baralhos = new ObservableCollection<Baralho>();
            _database.CreateTable<Baralho_DB>(); // Apenas para Baralhos Custom

            LoadBaralhos();
        }

        private void LoadBaralhos()
        {
            foreach (Baralho_DB a in _database.Table<Baralho_DB>().ToList())
            {
                Baralhos.Add(new Baralho()
                {
                    Nome = a.Nome,
                    Descr = a.Descr,
                    Filename = "Custom",
                    Cards = GetBaralho(a.Nome)
                });
            }
        }

        public int AddBaralho(Baralho baralho)
        {
            Baralho_DB baralho_DB = new Baralho_DB()
            {
                Descr = baralho.Descr,
                Nome = baralho.Nome,
            };
            return _database.Insert(baralho_DB);
        }
        public List<Card> GetBaralho(string Baralho)
        {
            return _database.Table<Card>().Where(b => b.Baralho == Baralho).ToList();
        }
        public int AddCards(IEnumerable<Card> card)
        {
            return _database.InsertAll(card);
        }
        public int AddCard(Card card)
        {
            return _database.Insert(card);
        }
        public int RemoveCards(Card card)
        {
            return _database.Table<Card>().Delete(x => x.Id == card.Id);
        }
        public int RemoveCards(IEnumerable<Card> Cards)
        {
            int i = 0;
            foreach (Card card in Cards)
            {
                i += _database.Table<Card>().Delete(x => x.Id == card.Id);
            }
            return i;
        }
        public int RemoveBaralho(Baralho baralho)
        {
            return _database.Table<Baralho_DB>().Delete(x=>x.Nome == baralho.Nome);
        }

        public bool CheckName(string name)
        {
            Baralho_DB result = _database.Table<Baralho_DB>().FirstOrDefault(x => x.Nome == name);
            if (result == null)
                return false;
            return true;
        }
    }
}
