/*Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the
    maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.

Example 1:
input 	output
3 	    min = 1
2 	    max = 5
5 	    sum = 8
1 	    avg = 2.67

Example 2:
input 	output
2 	    min = -1
-1 	    max = 4
4 	    sum = 3
	    avg = 1.50
*/

using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Title = "Min, Max, Sum and Average of N Numbers"; //Changing the title of the console.

        Console.Write("Please, enter a positive number N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int number, i = 0; i < n; i++)
        {
            Console.Write("Please, enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }

        Console.WriteLine
            ("min = {0}\r\n" +
             "max = {1}\r\n" +
             "sum = {2}\r\n" +
             "avg = {3}",
            min, max, sum, (double)sum / n);

        Console.ReadKey(); // Keeping the console opened.
    }
}