/*Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

Examples:
a 	    b 	    greater
5 	    6 	    6
10 	    5 	    10
0 	    0 	    0
-5 	    -2 	    -2
1.5 	1.6 	1.6
*/

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Console.Title = "Number Comparer"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter two numbers!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        double greater = Math.Max(a, b);

        Console.WriteLine();
        Console.WriteLine("{0,-16}{1,-16}{2,-16}", "a", "b", "greater");
        Console.WriteLine("{0,-16}{1,-16}{2,-16}", a, b, greater);

        Console.ReadKey(); // Keeping the console opened.
    }
}