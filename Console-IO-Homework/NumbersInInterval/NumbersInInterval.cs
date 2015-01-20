/*Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such
    that the reminder of the division by 5 is 0.

Examples:
start 	end 	p 	comments
17 	    25 	    2 	20, 25
5 	    30 	    6 	5, 10, 15, 20, 25, 30
3 	    33 	    6 	5, 10, 15, 20, 25, 30
3 	    4 	    0 	-
99 	    120 	5 	100, 105, 110, 115, 120
107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
*/

using System;
using System.Collections.Generic;

class NumbersInInterval
{
    static void Main()
    {
        Console.Title = "Numbers in Interval Dividable by 5"; //Changing the title of the console.

        Console.Write("Please, enter the start of the interval: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the end of the interval: ");
        int end = int.Parse(Console.ReadLine());

        List<int> list = new List<int>(); // A list of the numbers divisible by 5
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                list.Add(i);
            }
        }

        Console.WriteLine("\nstart\tend\tp\tcomments");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", start, end, list.Count, string.Join(", ",list));

        Console.ReadKey(); // Keeping the console opened.
    }
}