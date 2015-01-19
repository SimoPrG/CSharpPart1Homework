/*Problem 9. Trapezoids

    Write an expression that calculates trapezoid's area by given sides a and b and height h.

Examples:
a 	    b 	    h 	    area
5 	    7 	    12 	    72
2 	    1 	    33 	    49.5
8.5 	4.3 	2.7 	17.28
100 	200 	300 	45000
0.222 	0.333 	0.555 	0.1540125
*/

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Title = "Trapezoids";

        Console.Write("Please, enter side 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter side 'b': ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter height 'h': ");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;

        Console.WriteLine("{0}{1}{2}{3}", "a".PadRight(10), "b".PadRight(10), "h".PadRight(10), "area".PadRight(10));
        Console.WriteLine("{0}{1}{2}{3}", a.ToString().PadRight(10), b.ToString().PadRight(10),
            h.ToString().PadRight(10), area.ToString().PadRight(10));

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}