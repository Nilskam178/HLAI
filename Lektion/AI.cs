using System;
using System.Threading;

namespace Lektion
{
    public class AI
    {
        private int _guessCeil = 100;
        private int _guessFloor = 1;

        private Random random = new Random();
        
        private void Guess(int number)
        {
            var response = Program.instance.gameManager.Guess(number, false);

            switch (response)
            {
                case(Response.LOWER):
                    _guessCeil = number - 1;
                    break;
                case(Response.HIGHER):
                    _guessFloor = number + 1;
                    break;
                case(Response.CORRECT):
                    break;
            }
        }

        public void StartGuessing()
        {
            var aiGuesser = new ThreadStart(AsyncGuesser);
            aiGuesser.Invoke();
        }

        private void AsyncGuesser()
        {
            while (Program.instance.gameManager.isGameRunning)
            {
                if (_guessCeil - _guessFloor < 20)
                {
                    var guess = random.Next(_guessFloor, _guessCeil);
                    Guess(guess);
                    TextUtils.SendAIMessage(guess.ToString());
                }
                else
                {
                    var guess = _guessFloor + (_guessCeil - _guessFloor) / 2;
                    Guess(guess);
                    TextUtils.SendAIMessage(guess.ToString());
                }

                Thread.Sleep(1000 * 3);   
            }
        }
    }
}