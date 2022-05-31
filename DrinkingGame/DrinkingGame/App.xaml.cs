using DrinkingGame.Services;
using DrinkingGame.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame
{
    public partial class App : Application
    {
        public Game Game { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
