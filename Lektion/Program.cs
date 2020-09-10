namespace Lektion
{
    internal class Program
    {
        public GameManager gameManager { get; set; }
        public Guesser guesser { get; set; }
        public static Program instance { get; set; }
        
        public static void Main(string[] args)
        {
            instance = new Program {gameManager = new GameManager(), guesser = new Guesser()};
        }
    }
}