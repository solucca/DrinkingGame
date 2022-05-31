using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkingGame.Services
{
    public class ColorConverter
    {
        public static string[] PlayerColors =
            {
             "#F47C7C", // Vermelho
             "#66CCCC", // Azul escuro
             "#A1DE93", // Verde escuro
             "#8A57F0", // Roxo
             "#FFB266", // Laranja
             "#FF66CC", // Rosa
             "#CEA27A", // Marrom
             "#66CCCC", // Azul Claro
             "#EFE978", // Amarelo
             "#CCFF99", // Verde Claro
            };

        public static Dictionary<string, string> TypeColors = new Dictionary<string, string>()
        {
            {"Jogo", "PaleVioletRed" },
            {"RNG", "LightGreen" },
            {"Regra", "OrangeRed" },
        };
    }
}
