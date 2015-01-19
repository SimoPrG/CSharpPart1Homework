/*Problem 1. Sum of 3 Numbers

    Write a program that reads 3 real numbers from the console and prints their sum.

Examples:
a 	    b 	    c 	    sum
3 	    4 	    11 	    18
-2 	    0 	    3 	    1
5.5 	4.5 	20.1 	30.1
*/

using System;
using System.Threading;
using System.Globalization;

class Sum3Numbers
{
    static void Main()
    {
        Console.Title = "Sum of 3 Numbers"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //Setting the culture to Invariant

        Console.WriteLine("Please, enter 3 real numbers!");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("{0,-10}\t{1,-10}\t{2,-10}\t{3}", "a", "b", "c", "sum");
        Console.WriteLine("{0,-10}\t{1,-10}\t{2,-10}\t{3}", a, b, c, sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}