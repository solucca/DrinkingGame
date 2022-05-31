using DrinkingGame.ViewModels;
using DrinkingGame.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DrinkingGame
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CardPage), typeof(CardPage));
            Routing.RegisterRoute(nameof(ScoreboardPage), typeof(ScoreboardPage));
            Routing.RegisterRoute(nameof(PlayersPage), typeof(PlayersPage));
            Routing.RegisterRoute(nameof(WinnerPage), typeof(WinnerPage));
            Routing.RegisterRoute(nameof(CreateCardPage), typeof(CreateCardPage));
            Routing.RegisterRoute(nameof(SelectBaralhoPage), typeof(SelectBaralhoPage));
            Routing.RegisterRoute(nameof(ManageBaralhosPage), typeof(ManageBaralhosPage));
            Routing.RegisterRoute(nameof(CreateBaralhoPage), typeof(CreateBaralhoPage));
        }
    }
}
