/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.

Examples:
n 	x 	S
3 	2 	2.75000
4 	3 	2.07407
5 	-4 	0.75781
*/

using System;
using System.Globalization;
using System.Threading;

class FactorialSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please, enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer X: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1d;

        for (int i = 1; i <= n; i++)
        {
            sum += Factorial(i) / Math.Pow(x, i); // I am using a recursive method Factorial to calculate the factorial of i
        }

        Console.WriteLine("\r\nResult: {0:f5}", sum);

        Console.ReadKey(); // Keeping the console opened.
    }

    static double Factorial(double i) // the method takes a long as an input and it also returns a long
    {
        if (i <= 1) // if i is 1 or less, the method returns 1.
            return 1d;
        return i * Factorial(i - 1); // the method is calling itself. for example if we execute Factorial(3); it will return
    }                                // 3 * Factorial(3 - 1) which is 3 * Factorial(2) which is 3 * 2 * Factorial(2-1)
}                                    // which is 3 * 2 * Factorial(1) which is 3 * 2 * 1 = 6
