/*Problem 11. Bitwise: Extract Bit #3

    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.

Examples:
n 	    binary representation 	bit #3
5 	    00000000 00000101 	    0
0 	    00000000 00000000 	    0
15 	    00000000 00001111 	    1
5343 	00010100 11011111 	    1
62241 	11110011 00100001 	    0
*/

using System;

class BitNumber3
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Extract Bit #3";

        Console.Write("Please, enter an unsigned integer: ");
        uint integer = uint.Parse(Console.ReadLine());
        string binary = Convert.ToString(integer, 2).PadLeft(32,'0').Insert(24," ").Insert(16," ").Insert(8, " ");
        byte thirdBit = (byte)((integer >> 3) & 1);

        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\r\n", "Integer", "binary representation", "bit #3");
        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\r\n", integer, binary, thirdBit);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}