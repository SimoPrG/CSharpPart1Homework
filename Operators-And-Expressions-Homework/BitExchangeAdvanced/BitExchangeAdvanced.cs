/*Problem 16.** Bit Exchange (Advanced)

    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap.

Examples:
n 	            p 	q 	k 	binary representation of n 	            binary result 	                        result
1140867093 	    3 	24 	3 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
4294901775 	    24 	3 	3 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
2369124121 	    2 	22 	10 	10001101 00110101 11110111 00011001 	01110001 10110101 11111000 11010001 	1907751121
987654321 	    2 	8 	11 	- 	                                    - 	                                    overlapping
123456789 	    26 	0 	7 	- 	                                    - 	                                    out of range
33333333333 	-1 	0 	33 	- 	                                    - 	                                    out of range
*/

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Exchange Bits (Advanved)";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Please, enter position 'p': ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please, enter position 'q': ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Please, enter lenght 'k': ");
        int k = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        Console.Write("\r\n{0,-10}\t{1}\t{2}\t{3}\t{4,-35}\r\n", "Integer", "p", "q", "k", "binary representation");
        Console.Write("\r\n{0,-10}\t{1}\t{2}\t{3}\t{4,-35}\r\n", integer, p, q, k, binary);

        if (p>q) //making sure that q is greater than (or equal to) p
        {
            int c = p;
            p = q;
            q = c;
        }

        if ((q+k>32)||(p<0))
        {
            Console.WriteLine("out of range");
            //Hiding the "Press any key to continue..." message.
            Console.ReadKey();
            return;
        }
        else if (p+k>q)
        {
            Console.WriteLine("overlapping");
            //Hiding the "Press any key to continue..." message.
            Console.ReadKey();
            return;
        }

        byte[] bits_p_k = new byte[k];
        byte[] bits_q_k = new byte[k];

        for (byte i = 0; i < k; i++)
        {
            bits_p_k[i] = (byte)((integer >> (i + p)) & 1);
            bits_q_k[i] = (byte)((integer >> (i + q)) & 1);
        }

        for (byte i = 0; i < k; i++)
        {
            if (bits_p_k[i] == 0)
            {
                integer = ~(1 << (i + q)) & integer;
            }
            else
            {
                integer = (1 << (i + q)) | integer;
            }

            if (bits_q_k[i] == 0)
            {
                integer = ~(1 << (i + p)) & integer;
            }
            else
            {
                integer = (1 << (i + p)) | integer;
            }
        }

        binary = Convert.ToString(integer, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");
        Console.WriteLine("\r\nResult:\r\n{0,-10}\t\t\t\t{1,-35}", integer, binary);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}