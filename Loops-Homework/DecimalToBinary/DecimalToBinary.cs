/*Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	binary
0 	        0
3 	        11
43691 	    1010101010101011
236476736 	1110000110000101100101000000
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Title = "Decimal to Binary Number"; //Changing the title of the console.

        Console.Write("Please, enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        bool isNegative = n < 0;
        string binaryBackwards = null; // We will devide n by two and we will keep the reminders in this string.

        do
        {
            binaryBackwards += Math.Abs(n % 2); //We make sure that we will add only "0"s and "1"s to the string without "-"s.
            n /= 2;
        } while (n!=0);

        if (isNegative)
        {
            binaryBackwards += "-";
        }

        char[] charBinary = binaryBackwards.ToCharArray();
        Array.Reverse(charBinary);
        string stringBinary = new string(charBinary);

        Console.WriteLine("\r\nBinary representation: {0}", stringBinary);

        Console.ReadKey(); // Keeping the console opened.
    }
}