/*Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one
    is greater than the second one. As a result print the values a and b, separated by a space.

Examples:
a 	    b 	    result
5 	    2 	    2 5
3 	    4 	    3 4
5.5 	4.5 	4.5 5.5
*/

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Title = "Exchange If Greater"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter two numbers 'a' and 'b'!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("\r\nresult\r\n{0} {1}", a, b);

        Console.ReadKey(); // Keeping the console opened.
    }
}