using DrinkingGame.Services;

namespace DrinkingGame.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int Shots { get ; set; }
        public int Desafios { get; set; }
        public string Color { get => ColorConverter.PlayerColors[Id]; }
    }
}
