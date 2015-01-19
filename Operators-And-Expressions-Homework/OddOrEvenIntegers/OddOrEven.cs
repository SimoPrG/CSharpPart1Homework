/*Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.

Examples:
n 	Odd?
3 	true
2 	false
-2 	false
-1 	true
0 	false
*/

using System;

class OddOrEven
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Odd or Even Integer";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine("Integer\tOdd?\r\n" +
            "{0}\t{1}", integer,(integer%2!=0));

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }

}