using System;

namespace Lektion
{
    public class Player
    {

        public void StartGuessing()
        {
            if (Program.instance.gameManager.isGameRunning == true)
            {
                Console.WriteLine("Write your guess in numbers. 0-100");
                
                Guesser guesser = new Guesser();
                String Answer = Console.ReadLine();
                int number = Convert.ToInt32(Answer);
                
                Response response = guesser.Guess(number, true);
                if(response != Response.CORRECT) 
                { 
                    Console.WriteLine("Wrong number -> " + response);
                    StartGuessing();
                }
            }

        }
    }
}