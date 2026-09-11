using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1,101);
        int userGuess;

        do
        {
            // Console.WriteLine("What is the magic number?");
            // int magicNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());
            
            if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
        }
        while (magicNumber != userGuess);
       
        Console.WriteLine("You guessed it!");
        

    }
}