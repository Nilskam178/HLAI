namespace Lektion
{
    public abstract class Guesser
    {
        protected GameManager manager = Program.instance.gameManager;
        protected Response response;
        
        public virtual void Guess(int number)
        {
            response = manager.Guess(number);
        }
        
        

    }
}