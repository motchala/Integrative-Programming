namespace Integrative_Programming
{
    public class GuessGame

    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 21);
            int guess;
            int guessCount = 0;
            int showSecret = -99;
            Console.WriteLine("Number Guessing Game!");


            do
            {
                Console.WriteLine("Enter a number from 1-20");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    guessCount++;

                    if (guess < secretNumber && guess != showSecret)
                    {
                        Console.WriteLine("\nHIGHER!");
                    }
                    else if (guess > secretNumber && guess != showSecret)
                    {
                        Console.WriteLine("\nLOWER!");
                    }
                    else if (guess == showSecret)
                    {
                        Console.WriteLine("\t\t\tSecret Number: " + secretNumber + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Correct! You guessed the number in " + guessCount + " guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid! Please input a number.");
                }
            }
            while (guess != secretNumber);



            Console.ReadLine();
            return;
        }
    }
}
