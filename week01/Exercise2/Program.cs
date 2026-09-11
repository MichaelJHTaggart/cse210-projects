using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
            // Console.WriteLine("A");
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            // Console.WriteLine("B");
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            // Console.WriteLine("C");
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            // Console.WriteLine("D");
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
            // Console.WriteLine("F");
        }

        Console.WriteLine($"{letter}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but you can always try this class again!");
        }
    }
}