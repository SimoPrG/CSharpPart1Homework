/*Problem 1. Numbers from 1 to N

    Write a program that enters from the console a positive integer n and prints all the numbers
    from 1 to n, on a single line, separated by a space.

Examples:
n 	output
3 	1 2 3
5 	1 2 3 4 5
*/

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Title = "Numbers from 1 to N"; //Changing the title of the console.

        Console.Write("Please, enter a positive number N: ");
        int n = int.Parse(Console.ReadLine());
        string[] from1ToN = new string[n];

        for (int i = 0; i < n; )
        {
            from1ToN[i] = (++i).ToString();
        }
        Console.WriteLine("\r\nN\tOutput");
        Console.Write("{0}\t{1}", n, string.Join(" ", from1ToN));

        Console.ReadKey(); // Keeping the console opened.
    }
}