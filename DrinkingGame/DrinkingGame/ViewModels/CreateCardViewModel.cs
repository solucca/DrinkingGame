using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    [QueryProperty(nameof(Tipo), "type")]
    public class CreateCardViewModel : BaseViewModel
    {
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
        public CreateCardViewModel()
        {

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
