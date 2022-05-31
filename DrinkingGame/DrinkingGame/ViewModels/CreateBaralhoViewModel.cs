using System.Windows.Input;
using Xamarin.Forms;
using DrinkingGame.Models;
using DrinkingGame.Views;

namespace DrinkingGame.ViewModels
{
    public class CreateBaralhoViewModel : BaseViewModel
    {
        public ICommand CreateCard { get; set; }
        public Baralho Baralho { get; set; }

        public CreateBaralhoViewModel()
        {
            Baralho = new Baralho();
            CreateCard = new Command(OpenCreateCardPopUp);
        }

        async public void OpenCreateCardPopUp()
        {
            string response = await Shell.Current.DisplayActionSheet(
                                                "Tipo de Carta:",
                                                "Cancelar",
                                                null,
                                                FlowDirection.RightToLeft,
                                                new string[] { "Desafio", "Jogo", "Regra"}
                                                );
            if (response != null)
            {
                if (response == "Cancelar") return;
                await Shell.Current.GoToAsync($"{nameof(CreateCardPage)}?type={response}");
            }
        }
    }
}