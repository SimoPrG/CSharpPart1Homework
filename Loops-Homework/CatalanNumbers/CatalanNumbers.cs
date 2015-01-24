/*Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (1 < n < 100).

Examples:
n 	Catalan(n)
0 	1
5 	42
10 	16796
15 	9694845
*/

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "Catalan Numbers"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N (1...100): ");
        int n = int.Parse(Console.ReadLine());

        double product = 1;
        for (int k = 2; k <= n; k++)
        {
            product *= (double)(n + k) / k;
        }

        Console.WriteLine("\r\nCatalan number: {0}", product);

        Console.ReadKey(); // Keeping the console opened.
    }
}