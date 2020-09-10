namespace Lektion
{
    public class AI
    {
        private int previousGuess;

        private int GuessCeil = 100;
        private int GuessFloor = 1;
        
        public void Guess(int number)
        {
            if (Program.instance.gameManager.Guess(number) == Response.HIGHER)
            {
                
            }
        }
    }
}