using DrinkingGame.Models;
using DrinkingGame.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    public class SelectBaralhosViewModel : BaseViewModel
    {
        private DefaultDecks DefaultDecks = (Application.Current as App).DefaulDecks;
        private CustomDecks CustomDecks = (Application.Current as App).CustomDecks;
        public List<Baralho> Baralhos { get; set; } = new List<Baralho>();
        public SelectBaralhosViewModel()
        {
            Baralhos.AddRange(DefaultDecks.Baralhos);
            Baralhos.AddRange(CustomDecks.Baralhos);
        }
    }
}
