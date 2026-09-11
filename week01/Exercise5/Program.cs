using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int favoriteSquared = favoriteNumber * favoriteNumber;
            return favoriteSquared;
        }
        
        static void DisplayResult(string username, int favoriteSquared)
        {
            Console.WriteLine($"{username}, the square of your favorite number is {favoriteSquared}.");
        }

        DisplayWelcome();
        string username = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int favoriteSquared = SquareNumber(favoriteNumber);
        DisplayResult(username, favoriteSquared);
        

    }
}