/*Problem 13. Check a Bit at Given Position

    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
    in given integer number n, has value of 1.

Examples:
n 	    binary representation of n 	p 	bit @ p == 1
5 	    00000000 00000101 	        2 	true
0 	    00000000 00000000 	        9 	false
15 	    00000000 00001111 	        1 	true
5343 	00010100 11011111 	        7 	true
62241 	11110011 00100001 	        11 	false
*/

using System;

class CheckBit
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Check a Bit at Given Position";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the index of the bit you want to check (0-31): ");
        byte index = byte.Parse(Console.ReadLine());

        string binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        bool isOne = (((integer >> index) & 1) == 1);

        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", "Integer", "binary representation", "index", "bit@index==1");
        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", integer, binary, index, isOne);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}