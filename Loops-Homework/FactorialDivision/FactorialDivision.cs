/*Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.

Examples:
n 	k 	n! / k!
5 	2 	60
6 	5 	6
8 	3 	6720
*/

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.Write("Please, enter a positive integer N (1...100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer K (1...N): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine("\r\nResult: {0}", result);

        Console.ReadKey(); // Keeping the console opened.
    }
}