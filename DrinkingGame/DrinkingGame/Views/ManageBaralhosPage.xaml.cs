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
    public partial class ManageBaralhosPage : ContentPage
    {
        public ManageBaralhosPage()
        {
            InitializeComponent();
        }

        private async void CreateBaralho(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new CreateBaralhoPage() );
        }

        private async void GoBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}