namespace Lektion
{
    public class Guesser
    {
        private GameManager manager = Program.instance.gameManager;

        public Response Guess(int number, bool isPlayer)
        {
            return manager.Guess(number, isPlayer);
        }
        
        

    }
}