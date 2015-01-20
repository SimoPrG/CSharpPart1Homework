/*Problem 7. Sum of 5 Numbers

    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

Examples:
numbers 	        sum
1 2 3 4 5 	        15
10 10 10 10 10 	    50
1.5 3.14 8.2 -1 0 	11.84
*/

using System;
using System.Globalization;
using System.Threading;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Title = "Quadratic Equation"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.Write("Please, enter 5 numbers in a single line, separated by a space!\nnumbers: ");
        string[] numbers = Console.ReadLine().Split();
        double sum = 0;
        foreach (string number in numbers)
        {
            sum += double.Parse(number);
        }
        Console.WriteLine("sum: " + sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}