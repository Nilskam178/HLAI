using System;

namespace Lektion
{
    public static class TextUtils
    {
        private static int aiGuesses = 0;
        private static int playerGuesses = 0;
        
        public static void SendPlayerMessage(string message)
        {
            var x = Console.WindowWidth / 4;
            var y = 2 + playerGuesses;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
            playerGuesses++;
        }
        
        public static void SendAIMessage(string message)
        {
            var x = Console.WindowWidth / 4 * 3;
            var y = 2 + aiGuesses;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
            aiGuesses++;
        }
        
    }
}