/*Problem 3. Variable in Hexadecimal Format

    Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    Use Windows Calculator to find its hexadecimal representation.
    Print the variable and ensure that the result is 254.
*/

using System;

class Hexadecimal
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Hexadecimal Format";

        int hexadecimal = 0xFE;
        Console.WriteLine("Hexadecimal {0:X} is {0} decimal.", hexadecimal);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}