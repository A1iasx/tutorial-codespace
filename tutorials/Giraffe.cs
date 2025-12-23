namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;

            while (guess != secretWord)
            {
                if (guessCount <= 3)
                {
                   Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++; 
                }
                else
                {
                    System.Console.WriteLine("You're out of guesses bro");
                    
                }
                
            }
            
            System.Console.WriteLine("Success, You Win!");
        }
    }
}