/*Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold
    the value v at the position p from the binary representation of n while preserving all other bits in n.

Examples:
n 	    binary representation of n 	p 	v 	binary result 	    result
5 	    00000000 00000101 	        2 	0 	00000000 00000001 	1
0 	    00000000 00000000 	        9 	1 	00000010 00000000 	512
15 	    00000000 00001111 	        1 	1 	00000000 00001111 	15
5343 	00010100 11011111 	        7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	        11 	0 	11110011 00100001 	62241
*/

using System;

class ModifyBit
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Modify a Bit at Given Position";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the position of the bit you want to modify (0-31): ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Please, enter the value you want to set (0 or 1): ");
        byte value = byte.Parse(Console.ReadLine());

        string binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");

        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", "Integer", "binary representation", "p", "v");
        Console.Write("\r\n{0,-10}\t{1,-35}\t{2}\t{3}\r\n", integer, binary, p, value);

        if (value==0)
        {
            integer = ~(1 << p) & integer;
        }
        else if (value==1)
        {
            integer = (1 << p) | integer;
        }
        else
        {
            Console.WriteLine("The value can not differ from 0 or 1!");
            //Hiding the "Press any key to continue..." message.
            Console.ReadKey();
            return;
        }
        binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        Console.WriteLine("\r\nResult:\r\n{0,-10}\t{1,-35}", integer, binary);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}