using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkingGame.Models;
using DrinkingGame.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkingGame.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateBaralhoPage : ContentPage
    {
        public CreateBaralhoPage()
        {
            InitializeComponent();
            BindingContext = new CreateBaralhoViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
            viewModel.UpdateView();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
            await Navigation.PopAsync();
        }

        private async void CreateCard(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Qual tipo de carta?", "Cancelar", null, "Desafio", "Jogo");
            if (result != null)
            {
                CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
                await Navigation.PushAsync(new CreateCardPage(viewModel.CreateCard(result)));
            }
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
            string descr = await DisplayPromptAsync("Descrição:", "Descreva o seu baralho", maxLength: 100);
            if (descr != null)
            {
                viewModel.SaveBaralho(descr);
                await Navigation.PopAsync();
            }
                

        }
    }
}