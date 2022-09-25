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
    public partial class ScoreboardPage : ContentPage
    {
        public ScoreboardPage()
        {
            InitializeComponent();
        }

        private async void GoBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void QuitGame(object sender, EventArgs e)
        {
            bool quit = await DisplayAlert("CUIDADO!", "Você quer mesmo sair do jogo?", "Sim", "Não");
            if (quit)
                await Navigation.PopToRootAsync();
        }
    }
}