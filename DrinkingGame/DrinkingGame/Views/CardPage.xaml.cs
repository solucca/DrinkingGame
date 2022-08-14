using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardPage : ContentPage
    {
        public CardPage()
        {
            InitializeComponent();
            (Application.Current as App).Game.GameWon += GameWon;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void OpenScoreboard(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScoreboardPage());
        }

        private async void GameWon(object sender, bool e)
        {
            await Navigation.PushAsync(new WinnerPage());
        }
    }
}