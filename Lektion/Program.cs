namespace Lektion
{
    internal class Program
    {
        public GameManager gameManager { get; set; }
        public Guesser guesser { get; set; }
        public static Program instance { get; set; }
        
        
        
        public static void Main(string[] args)
        {
            Player _player = new Player();
            instance = new Program();
            instance.gameManager = new GameManager();
            instance.guesser = new Guesser();
            instance.gameManager.StartGame();
            _player.StartGuessing();
        }
    }
}