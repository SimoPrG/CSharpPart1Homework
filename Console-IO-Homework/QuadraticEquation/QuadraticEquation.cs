/*Problem 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic
    equation ax2 + bx + c = 0 and solves it (prints its real roots).

Examples:
a 	    b 	    c 	    roots
2 	    5 	    -3 	    x1=-3; x2=0.5
-1 	    3 	    0 	    x1=3; x2=0
-0.5 	4 	    -8 	    x1=x2=4
5 	    2 	    8 	    no real roots
*/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter the coefficients of the quadratic equation ax^2 + bx + c = 0");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine();
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, "no real roots");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine();
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, "x1 = x2 = " + x.ToString());
        }
        else
        {
            double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine();
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", "a", "b", "c", "result");
            Console.WriteLine("{0,-16}{1,-16}{2,-16}{3}", a, b, c, "x1 = " + x1.ToString() +
                "; x2 = " + x2.ToString() + ";");
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}