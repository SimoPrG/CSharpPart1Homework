/*Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.

Examples:
n 	    binary representation 	p 	bit @ p
5 	    00000000 00000101 	    2 	1
0 	    00000000 00000000 	    9 	0
15 	    00000000 00001111 	    1 	1
5343 	00010100 11011111 	    7 	1
62241 	11110011 00100001 	    11 	0
*/

using System;

class ExtractBit
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Extract Bit from Integer";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the index of the bit (0-31): ");
        byte index = byte.Parse(Console.ReadLine());

        string binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        byte bitValue = (byte)((integer >> index) & 1);

        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", "Integer", "binary representation", "index", "value");
        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", integer, binary, index, bitValue);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}