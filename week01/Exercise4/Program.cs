using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numberList = new List<double>();

        double userInput = 1;

        while (userInput != 0)
        {
            Console.Write("Enter Number: ");
            userInput = double.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numberList.Add(userInput);
            }
        }

        double sum = 0;
        double average = 0;
        double largestNumber = 0;        

        // Console.WriteLine(numberList.Count);


        foreach (double number in numberList)
        {
            sum = number + sum;
        }

        average = sum / numberList.Count;

        largestNumber = numberList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}