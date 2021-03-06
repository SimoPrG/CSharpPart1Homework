﻿/*Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
binary 	                        decimal
0 	                            0
1                               1
11 	                            3
1010101010101011 	            43691
1110000110000101100101000000 	236476736
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Title = "Binary to Decimal Number"; //Changing the title of the console.

        Console.Write("Please, enter a binary number: ");
        string binary = Console.ReadLine();

        bool isNegative = false;
        if (binary.StartsWith("-"))
        {
            isNegative = true;
            binary = binary.Replace("-", "");
        }

        int sum = 0;
        for (int j = 0, i = binary.Length - 1; i >= 0; j++, i--)
        {
            if (binary[i] == '1')
            {
                sum += 1 << j;
            }
        }

        if (isNegative)
        {
            sum = -sum;
        }

        Console.WriteLine("\r\ndecimal number: {0}", sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}