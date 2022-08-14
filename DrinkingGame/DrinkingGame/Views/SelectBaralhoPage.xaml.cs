using System;
using System.Collections.Generic;
using DrinkingGame.Models;
using DrinkingGame.Services;
using DrinkingGame.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectBaralhoPage : ContentPage
    {
        Game Game = (Application.Current as App).Game;
        List<Baralho> Baralhos = (Application.Current as App).DefaulDecks.Baralhos;

        List<Baralho> SelectedBaralhos = new List<Baralho>();
        public SelectBaralhoPage()
        {
            InitializeComponent();
        }

        private async void Next(object sender, EventArgs e)
        {
            Game.BuildDeck(SelectedBaralhos);
            await Navigation.PushAsync(new PlayersPage() );
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var test2 = (CheckBox)((Frame)sender).FindByName("Select");
            test2.IsChecked = !test2.IsChecked;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var parent = (StackLayout)((CheckBox)sender).Parent.Parent;

            Label test1 = (Label)parent.FindByName("Nome");
            string name = test1?.Text;
            var test2 = (CheckBox)parent.FindByName("Select");
            bool selected = test2.IsChecked;
            if (SelectedBaralhos.Contains(Baralhos.Find(x => x.Nome == name)))
                SelectedBaralhos.Remove(Baralhos.Find(x => x.Nome == name));
            else
                SelectedBaralhos.Add(Baralhos.Find(x => x.Nome == name));
        }
    }
}