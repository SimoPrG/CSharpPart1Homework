/*Problem 8. Square Root

    Create a console application that calculates and prints the square root of the number 12345.
    Find in Internet “how to calculate square root in C#”.
*/

using System;

class SquareRootOf12345
{
    static void Main()
    {
        double squareRoot;
        squareRoot = Math.Sqrt(12345);
        Console.WriteLine("The square root of 12345 is {0}", squareRoot);
    }
}
