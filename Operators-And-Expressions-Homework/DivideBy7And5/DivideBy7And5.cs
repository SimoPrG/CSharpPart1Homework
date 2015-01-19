/*
    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

Examples:
n 	Divided by 7 and 5?
3 	false
0 	false
5 	false
7 	false
35 	true
140 	true
*/

using System;

class DivideBy7And5
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Devide by 7 and 5";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine("Integer\tDevided by 7 and 5?\r\n" +
            "{0}\t{1}", integer, integer%35==0);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}