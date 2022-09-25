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
        public CreateBaralhoPage(Baralho baralho)
        {
            InitializeComponent();
            BindingContext = new CreateBaralhoViewModel(baralho);
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

            bool save = await DisplayAlert("Aviso", "Você quer salvar?", "sim", "não");
            
            if (!save)
            {
                await Navigation.PopAsync();
            }

            int result = viewModel.SaveBaralho();

            if (result == 0)
            {
                await Navigation.PopAsync();
            }
            else if (result == -1)
            {
                await DisplayAlert("Erro", "Já existe um baralho com esse nome", "Ok");
            }

            
        }

        private async void CreateCard(object sender, EventArgs e)
        {
            CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
            string result = await DisplayActionSheet("Qual tipo de carta?", "Cancelar", null, "Desafio", "Jogo");
            if (result != null)
            {
                await Navigation.PushAsync(new CreateCardPage(viewModel.CreateCard(result)));
            }
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            CreateBaralhoViewModel viewModel = (CreateBaralhoViewModel)BindingContext;
            string[] buttons = new string[] { "Descrição", "Deletar" };
            string result = await DisplayActionSheet("Configure", "Cancelar", null, buttons);
            
            if (result == "Descrição")
            {
                string descr = await DisplayPromptAsync("Descrição:", "Descreva o seu baralho", maxLength: 100);
                if (descr != null)
                {
                    viewModel.AddDescr(descr);
                }
            }
            else if (result == "Deletar")
            {
                bool del = await DisplayAlert("Aviso", "Você mesmo DELETAR?", "sim", "não" );
                if (del == true)
                {
                    viewModel.DeleteBaralho();
                    await Navigation.PopAsync();
                }
            }

            
                

        }
    }
}