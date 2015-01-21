/*Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.

Examples:
 a 	    b 	    c 	    d 	e 	    biggest
 5 	    2 	    2 	    4 	1 	    5
-2 	   -22 	    1 	    0 	0 	    1
-2 	    4 	    3 	    2 	0 	    4
 0 	   -2.5 	0 	    5 	5 	    5
-3 	   -0.5    -1.1    -2  -0.1    -0.1
*/

using System;
using System.Globalization;
using System.Threading;

class BiggestOf5Numbers
{
    static void Main()
    {
        Console.Title = "The Biggest of Five Numbers"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter five numbers 'a', 'b', 'c', 'd' and 'e'!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e: ");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;
        if (biggest < b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        if (biggest < d)
        {
            biggest = d;
        }
        if (biggest < e)
        {
            biggest = e;
        }
        Console.WriteLine("\n{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5}", "a", "b", "c", "d", "e", "biggest");
        Console.WriteLine("{0,-105}{1,-10}{2,-10}{3,-10}{4,-10}{5}", a, b, c, d, e, biggest);

        Console.ReadKey(); // Keeping the console opened.
    }
}