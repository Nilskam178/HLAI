using System;
using System.Net.Mime;

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

        private bool isGameRunning;

        public void StartGame()
        {
            random = new Random();
            correctNumber = random.Next(1, 100);
            isGameRunning = true;


        }

        public Response Guess(int number, bool isPlayer)
        {
            if (number > correctNumber)
                return Response.HIGHER;
            if (number < correctNumber)
                return Response.LOWER;

            if (isPlayer)
            {
                Console.WriteLine("The Player won!");
                isGameRunning = false;
                return Response.CORRECT;
            }

            Console.WriteLine("The AI won!");
            isGameRunning = false;
            return Response.CORRECT;
        }

        public Response Guess(int number)
        {
            throw new NotImplementedException();
        }
    }
}