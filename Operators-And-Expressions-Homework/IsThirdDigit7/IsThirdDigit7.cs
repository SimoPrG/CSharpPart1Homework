/*Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.

Examples:
n 	Third digit 7?
5 	false
701 	true
9703 	true
877 	false
777877 	false
9999799 	true
*/

using System;

class IsThirdDigit7
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Third digit is 7?";

        Console.Write("Please, enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine("Integer\tThird digit 7?\r\n" +
            "{0}\t{1}", integer,(integer/100)%10==7);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}