using DrinkingGame.Services;
using DrinkingGame.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame
{
    public partial class App : Application
    {
        public Game Game { get; set; }
        public CustomDecks CustomDecks { get; set; }
        public DefaultDecks DefaulDecks { get; set; }
        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());

            CustomDecks = new CustomDecks();
            DefaulDecks = new DefaultDecks();
            Game = new Game();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
