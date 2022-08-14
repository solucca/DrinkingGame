using DrinkingGame.Models;
using DrinkingGame.ViewModels;
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
    public partial class CreateCardPage : ContentPage
    {
        public CreateCardPage(Card newCard)
        {
            InitializeComponent();
            BindingContext = new CreateCardViewModel(newCard);
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            CreateCardViewModel vm = (CreateCardViewModel)BindingContext;
            vm.SaveCard();
            await Navigation.PopAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            CreateCardViewModel vm = (CreateCardViewModel)BindingContext;
            vm.DeleteCard();
            await Navigation.PopAsync();
        }
    }
}