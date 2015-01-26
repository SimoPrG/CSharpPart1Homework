/*Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).

Examples:
a 	b 	    GCD(a, b)
3 	2 	    1
60 	40 	    20
5 	-15 	5
*/

using System;

class GCD
{
    static void Main()
    {
        Console.Title = "Calculate GCD"; //Changing the title of the console.

        Console.Write("Please, enter an integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer b: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int reminder = a % b;
        while (reminder != 0)
        {
            a = b;
            b = reminder;
            reminder = a % b;
        }

        Console.WriteLine("\r\nGCD: " + b);

        Console.ReadKey(); // Keeping the console opened.
    }
}