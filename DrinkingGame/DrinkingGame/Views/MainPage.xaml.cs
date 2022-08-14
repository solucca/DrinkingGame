using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartGame(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectBaralhoPage());
        }

        private async void Baralhos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageBaralhosPage());
        }
    }
}