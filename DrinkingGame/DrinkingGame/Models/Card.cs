using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }
        public int Shots { get; set; }
        public int Pontos { get; set; }
        public int Players { get; set; }
        public string Categoria { get; set; }
        //Id;Tipo;Conteudo;Legenda;Shots;Pontos;Outros Players;Categoria
        public Card(string[] data)
        {
            if (data.Length != 8)
            {
                throw new ArgumentException("Wrong Data Size");
            }
            try
            {
                this.Id = int.Parse(data[0]);
                this.Tipo = data[1];
                this.Nome = data[2];
                this.Legenda = data[3];

                if (data[4].Length > 0){this.Shots = int.Parse(data[4]);
                } else { this.Shots = 0; }
                
                if (data[5].Length > 0) { this.Pontos = int.Parse(data[5]); 
                } else { this.Pontos = 0; }

                if (data [6].Length > 0) { this.Players = int.Parse(data[6]);
                } else { this.Players= 0; }
                
                this.Categoria = data[7];
            } catch 
            {
                throw new Exception("Wrong data:");
            }
            
        }
    }
}
