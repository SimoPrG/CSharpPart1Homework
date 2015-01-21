/*Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
 a 	    b 	    c 	    result
 5 	    2 	    2 	    +
-2 	   -2 	    1 	    +
-2 	    4 	    3 	    -
 0 	   -2.5 	4 	    0
-1 	   -0.5    -5.1 	-
*/

using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Console.Title = "Exchange If Greater"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter three numbers 'a', 'b' and 'c'!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        char result;
        if (a == 0 || b == 0 || c == 0)
        {
            result = '0';
            Console.WriteLine("\n{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, result);

            Console.ReadKey(); // Keeping the console opened.
            return;
        }
        if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
        {
            result = '+';
            Console.WriteLine("\n{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, result);
        }
        else
        {
            result = '-';
            Console.WriteLine("\n{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, result);
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}