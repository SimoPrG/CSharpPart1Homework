/*Problem 9. Sum of n Numbers

    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
    Note: You may need to use a for-loop.

Examples:
numbers 	sum
3 	        90
20 	
60 	
10 

5 	        6.5
2 	
-1 	
-0.5 	
4 	
2

1 	        1
1
*/

using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Title = "Sum of n Numbers"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.Write("Please, enter an integer n and n numbers after that.\nn: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("number {0}: ", i);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nsum = " + sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}