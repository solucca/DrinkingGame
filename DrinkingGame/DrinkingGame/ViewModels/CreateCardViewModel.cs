using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Models;
using DrinkingGame.Services;

namespace DrinkingGame.ViewModels
{
    [QueryProperty(nameof(Tipo), "type"), QueryProperty(nameof(Baralho), "name")]
    public class CreateCardViewModel : BaseViewModel
    {
        public string Baralho { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }
        public int Pontos { get; set; }
        public int Shots { get; set; }

        public string Tipo { 
            get => _tipo;
            set
            { 
                if (_tipo != value)
                {
                    _tipo = value;
                    SetCardType(value);
                    OnPropertyChanged();
                }
            }
        }
        public string _tipo;
        public string[] TipoVisible { get; set; }

        private Card NewCard;
        
        public CreateCardViewModel(Card newCard)
        {
            NewCard = newCard;
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
        private void SetCardType(string type)
        {
            if (type != null)
            {
                switch (type)
                {
                    case "Desafio": TipoVisible = new string[] { "True", "False", "False" }; break;
                    case "Jogo": TipoVisible = new string[] { "False", "True", "False" }; break;
                    case "Regra": TipoVisible = new string[] { "False", "False", "True" }; break;
                    default: TipoVisible = new string[] { "False", "False", "False" }; break;
                }
                OnPropertyChanged(nameof(TipoVisible));
            }
        }
    }
}
