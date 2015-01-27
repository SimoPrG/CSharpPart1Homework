/*Problem 18.* Trailing Zeroes in N!

    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.

Examples:
n 	    trailing zeroes of n! 	explaination
10 	    2 	                    3628800
20 	    4 	                    2432902008176640000
100000 	24999 	                think why
*/

using System;

class FactorielZeroes
{
    static void Main()
    {
        Console.Title = "Trailing Zeroes in N!";

        Console.Write("Please, enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        int trailingZeroes = 0;
        int power = 1;
        while (n / Math.Pow(5, power) >= 1)
        {
            trailingZeroes += n / (int)Math.Pow(5, power);
            power++;
        }

        Console.WriteLine("trailing zeroes of n! " + trailingZeroes);

        Console.ReadKey();
    }
}