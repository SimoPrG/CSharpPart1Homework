/*Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
hexadecimal 	decimal
FE 	            254
1AE3 	        6883
4ED528CBB4 	    338583669684
*/

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Title = "Hexadecimal to Decimal Number"; //Changing the title of the console.

        Console.Write("Please, enter a hexadecimal number: ");
        string hexadecimal = Console.ReadLine().ToUpper();

        bool isNegative = false;
        if (hexadecimal.StartsWith("-"))
        {
            isNegative = true;
            hexadecimal = hexadecimal.Replace("-", "");
        }

        char[] reverseHexadecimal = hexadecimal.ToCharArray();
        Array.Reverse(reverseHexadecimal);

        long sum = 0;
        int power = 0;
        foreach (char digit in reverseHexadecimal)
        {
            switch (digit)
            {
                case '0': sum += 0 * (long)Math.Pow(16, power); break;
                case '1': sum += 1 * (long)Math.Pow(16, power); break;
                case '2': sum += 2 * (long)Math.Pow(16, power); break;
                case '3': sum += 3 * (long)Math.Pow(16, power); break;
                case '4': sum += 4 * (long)Math.Pow(16, power); break;
                case '5': sum += 5 * (long)Math.Pow(16, power); break;
                case '6': sum += 6 * (long)Math.Pow(16, power); break;
                case '7': sum += 7 * (long)Math.Pow(16, power); break;
                case '8': sum += 8 * (long)Math.Pow(16, power); break;
                case '9': sum += 9 * (long)Math.Pow(16, power); break;
                case 'A': sum += 10 * (long)Math.Pow(16, power); break;
                case 'B': sum += 11 * (long)Math.Pow(16, power); break;
                case 'C': sum += 12 * (long)Math.Pow(16, power); break;
                case 'D': sum += 13 * (long)Math.Pow(16, power); break;
                case 'E': sum += 14 * (long)Math.Pow(16, power); break;
                case 'F': sum += 15 * (long)Math.Pow(16, power); break;
                default:
                    Console.WriteLine("Invalid number");
                    Console.ReadKey(); // Keeping the console opened.break;
                    return;
            }
            power++;
        }

        if (isNegative)
        {
            sum = -sum;
        }

        Console.WriteLine("decimal number: {0}", sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}