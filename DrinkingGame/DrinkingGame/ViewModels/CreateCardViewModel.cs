using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Models;
using DrinkingGame.Services;

namespace DrinkingGame.ViewModels
{
    public class CreateCardViewModel : BaseViewModel
    {
        public string Baralho { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }
        public int Pontos { get; set; }
        public int Shots { get; set; }

        public string Tipo { get; set; }
        public string _tipo;
        public string[] TipoVisible { get => GetTipo(); }

        private Card NewCard;
        
        public CreateCardViewModel(Card newCard)
        {
            NewCard = newCard;
            Tipo = newCard.Tipo;
        }

        public void SaveCard()
        {
            NewCard.Nome = Nome;
            NewCard.Legenda = Legenda;
            NewCard.Shots = Shots;
            NewCard.Pontos = Pontos;
        }
        public void DeleteCard()
        {
            NewCard.Tipo = null;
        }
        private string[] GetTipo()
        {
            string[] result = null;
            if (Tipo != null)
            {
                switch (Tipo)
                {
                    case "Desafio": result = new string[] { "True", "False", "False" }; break;
                    case "Jogo": result = new string[] { "False", "True", "False" }; break;
                    case "Regra": result = new string[] { "False", "False", "True" }; break;
                    default: result = new string[] { "False", "False", "False" }; break;
                }
            }
            return result;
        }
    }
}
