using DrinkingGame.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DrinkingGame.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "Main";
            StartGame = new Command(async () => await Shell.Current.GoToAsync(nameof(SelectBaralhoPage), true));
            CreateCard = new Command(async () => await Shell.Current.GoToAsync(nameof(ManageBaralhosPage), true));
        }
        public ICommand StartGame { get; }
        public ICommand CreateCard { get; }
    }
}
