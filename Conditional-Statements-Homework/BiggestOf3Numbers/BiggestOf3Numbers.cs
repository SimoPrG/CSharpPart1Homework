/*Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.

Examples:
 a 	    b 	    c 	    biggest
 5 	    2 	    2 	    5
-2 	   -2 	    1 	    1
-2 	    4 	    3 	    4
 0 	   -2.5 	5 	    5
-0.1   -0.5    -1.1    -0.1
*/

using System;
using System.Globalization;
using System.Threading;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.Title = "The Biggest of 3 Numbers"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter three numbers 'a', 'b' and 'c'!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double biggest = a;
        if (biggest < b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }

        Console.WriteLine("\n{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "biggest");
        Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, biggest);

        Console.ReadKey(); // Keeping the console opened.
    }
}