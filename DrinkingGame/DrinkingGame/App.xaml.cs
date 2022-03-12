using DrinkingGame.Services;
using DrinkingGame.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame
{
    public partial class App : Application
    {
        public Players players = new Players();

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            
            MainPage = new AppShell();
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
