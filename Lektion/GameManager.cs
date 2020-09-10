using System;

namespace Lektion
{
    public enum Response
    {
        HIGHER, LOWER, CORRECT
    }
    public class GameManager
    {

        private int correctNumber = 0;
        private Random random;

        public Guesser player;
        public Guesser ai;

        public void StartGame()
        {
            random = new Random();
            correctNumber = random.Next(1, 100);
            
            
        }

        public Response Guess(int number)
        {
            if (number > correctNumber)
                return Response.HIGHER;
            if (number < correctNumber)
                return Response.LOWER;
            return Response.CORRECT;
        }
        
    }
}