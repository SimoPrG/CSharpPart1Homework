/*Problem 2. Numbers Not Divisible by 3 and 7

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n
    not divisible by 3 and 7, on a single line, separated by a space.

Examples:
n 	output
3 	1 2
10 	1 2 4 5 8 10
*/

using System;
using System.Collections.Generic;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Title = "Numbers Not Divisible by 3 and 7"; //Changing the title of the console.

        Console.Write("Please, enter a positive number N: ");
        int n = int.Parse(Console.ReadLine());
        List<int> notDivisibleBy3And7 = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (((i + 1) % 3 != 0) && ((i + 1) % 7 != 0))
            {
                notDivisibleBy3And7.Add(i + 1);
            }
        }
        Console.WriteLine("\r\nN\tOutput");
        Console.Write("{0}\t{1}", n, string.Join(" ", notDivisibleBy3And7));

        Console.ReadKey(); // Keeping the console opened.
    }
}