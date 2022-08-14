using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace DrinkingGame.Models
{
    public class Card
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }
        public int Shots { get; set; }
        public int Pontos { get; set; }
        public string Baralho { get; set; }
        //Id;Tipo;Conteudo;Legenda;Shots;Pontos;Outros Players;Categoria
    }
}
