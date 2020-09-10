namespace Lektion
{
    public class AI : Guesser
    {
        private int previousGuess;

        private int GuessCeil;
        private int GuessFloor;
        
        public override void Guess(int number)
        {
            base.Guess(number);
            if (response == Response.HIGHER)
            {
                
            }
        }
    }
}