using DrinkingGame.Models;
using DrinkingGame.Services;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace DrinkingGame.ViewModels
{
    public class ManageBaralhosViewModel
    {
        DefaultDecks defaultDecks = (Application.Current as App).DefaulDecks;
        CustomDecks CustomDecks = (Application.Current as App).CustomDecks;
        public ObservableCollection<Baralho> Baralhos{ get; set; }
        public ManageBaralhosViewModel()
        {
            Baralhos = new ObservableCollection<Baralho>();
            foreach(Baralho a in defaultDecks.Baralhos)
            {
                Baralhos.Add(a);
            }
            foreach (Baralho a in CustomDecks.Baralhos)
            {
                Baralhos.Add(a);
            }
        }
    }
}
