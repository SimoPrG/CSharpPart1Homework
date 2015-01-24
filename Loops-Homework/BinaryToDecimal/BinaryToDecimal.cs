/*Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
binary 	                        decimal
0 	                            0
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
        int sum = 0;
        for (int j = 0, i = binary.Length - 1; i >= 0; j++, i--)
        {
            if (binary[i]=='1')
            {
                sum += 1 << j;
            }
        }
        Console.WriteLine("\r\nbinary: {0}\r\ndecimal: {1}", binary, sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}