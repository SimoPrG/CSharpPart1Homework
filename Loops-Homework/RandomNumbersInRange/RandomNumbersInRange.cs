/*Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

Examples:
n 	min 	max 	random numbers
5 	0 	    1 	    1 0 0 1 1
10 	10 	    15 	    12 14 12 15 10 12 14 13 13 11

Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
*/

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Title = "Random Numbers in Given Range"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the minimum of the range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the maximum of the range greater than {0}: ", min);
        int max = int.Parse(Console.ReadLine());

        string randomNumbers = "\r\n";
        Random getRandom = new Random();
        for (int i = 0; i < n; i++)
        {
            randomNumbers += getRandom.Next(min, max + 1) + " ";
        }
        Console.WriteLine(randomNumbers.TrimEnd());

        Console.ReadKey(); // Keeping the console opened.
    }
}