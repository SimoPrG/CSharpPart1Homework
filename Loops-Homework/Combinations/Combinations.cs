/*Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements
    (also known as the number of combinations) is calculated by the following formula: formula For example, there are
    2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use
    only two loops.

Examples:
n 	k 	n! / (k! * (n-k)!)
3 	2 	3
4 	2 	6
10 	6 	210
52 	5 	2598960
*/

using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        Console.Title = "Calculate N! / (K! * (N-K)!)"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N (1...100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer K (1...N): ");
        int k = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        for (int i = n - k + 1; i <= n; i++)
        {
            numerator *= i;
        }
        BigInteger denominator = 1;
        for (int i = 2; i <= k; i++)
        {
            denominator *= i;
        }

        Console.WriteLine("\r\nResult: {0}", numerator / denominator);

        Console.ReadKey(); // Keeping the console opened.
    }
}