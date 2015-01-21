/*Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.

Examples:
 a 	    b 	    c 	    result
 5 	    1 	    2 	    5       2       1
-2 	   -2 	    1 	    1      -2      -2
-2 	    4 	    3 	    4       3      -2
 0 	   -2.5 	5 	    5       0      -2.5
-1.1   -0.5    -0.1    -0.1    -0.5    -1.1
 10     20 	    30 	    30      20      10
 1 	    1 	    1 	    1       1       1
*/

using System;
using System.Globalization;
using System.Threading;

class Sort3Numbers
{
    static void Main()
    {
        Console.Title = "Sort 3 Numbers with Nested Ifs"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.WriteLine("Please, enter three numbers 'a', 'b' and 'c'!");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                Console.WriteLine("{0,-16}{1,-16}{2,-16}", c, b, a);
            }
            else
            {
                if (a < c)
                {
                    Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                    Console.WriteLine("{0,-16}{1,-16}{2,-16}", b, c, a);
                }
                else
                {
                    Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                    Console.WriteLine("{0,-16}{1,-16}{2,-16}", b, a, c);
                }
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                Console.WriteLine("{0,-16}{1,-16}{2,-16}", a, b, c);
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                    Console.WriteLine("{0,-16}{1,-16}{2,-16}", a, c, b);
                }
                else
                {
                    Console.WriteLine("\r\n{0,-16}{1,-16}{2,-16}", "a", "b", "c");
                    Console.WriteLine("{0,-16}{1,-16}{2,-16}", c, a, b);
                }
            }
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}