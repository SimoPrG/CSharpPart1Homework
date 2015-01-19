/*Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

Examples:
n       	binary representation of n             	binary result                       	result
1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
5351 	    00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705
*/

using System;

class BitsExchange
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Exchange Bits";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");

        Console.Write("\r\n{0,-10}\t{1,-35}\r\n", "Integer", "binary representation");
        Console.Write("\r\n{0,-10}\t{1,-35}\r\n", integer, binary);

        byte[] bits3_4_5 = new byte[3];
        byte[] bits24_25_26 = new byte[3];

        for (byte i = 0; i < 3; i++)
        {
            bits3_4_5[i] = (byte)((integer >> (i+3)) & 1);
            bits24_25_26[i] = (byte)((integer >> (i+24)) & 1);
        }

        for (byte i = 0; i < 3; i++)
        {
            if (bits3_4_5[i] == 0)
            {
                integer = ~(1 << (i + 24)) & integer;
            }
            else
            {
                integer = (1 << (i + 24)) | integer;
            }

            if (bits24_25_26[i] == 0)
            {
                integer = ~(1 << (i + 3)) & integer;
            }
            else
            {
                integer = (1 << (i + 3)) | integer;
            }
        }

        binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        Console.WriteLine("\r\nResult:\r\n{0,-10}\t{1,-35}", integer, binary);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}