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
    public partial class PlayersPage : ContentPage
    {
        private int max_players { get; set; }
        private int current { get; set; }
        public PlayersPage()
        {
            InitializeComponent();
            max_players = 10;
            current = 2;
        }
        void Add(System.Object sender, System.EventArgs e)
        {
            if (current < max_players)
            {
                current++;
                switch (current)
                {
                    case 3: entry3.IsVisible = true; break;
                    case 4: entry4.IsVisible = true; break;
                    case 5: entry5.IsVisible = true; break;
                    case 6: entry6.IsVisible = true; break;
                    case 7: entry7.IsVisible = true; break;
                    case 8: entry8.IsVisible = true; break;
                    case 9: entry9.IsVisible = true; break;
                    case 10: entry10.IsVisible = true; break;
                }
            }
        }
        void Remove(System.Object sender, System.EventArgs e)
        {
            if (current > 2)
            {
                switch (current)
                {
                    case 3: entry3.IsVisible = false; break;
                    case 4: entry4.IsVisible = false; break;
                    case 5: entry5.IsVisible = false; break;
                    case 6: entry6.IsVisible = false; break;
                    case 7: entry7.IsVisible = false; break;
                    case 8: entry8.IsVisible = false; break;
                    case 9: entry9.IsVisible = false; break;
                    case 10: entry10.IsVisible = false; break;
                }
                current--;
            }
        }
    }
}