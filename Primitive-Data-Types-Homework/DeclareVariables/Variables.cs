/*Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte,
    short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

using System;

class Variables
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Variables Declaration";

        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;

        //Printing the variables.
        Console.WriteLine("First variable  is {0,8} of type {1}", firstVariable, firstVariable.GetType());
        Console.WriteLine("Second variable is {0,8} of type {1}", secondVariable, secondVariable.GetType());
        Console.WriteLine("Third variable  is {0,8} of type {1}", thirdVariable, thirdVariable.GetType());
        Console.WriteLine("Fourth variable is {0,8} of type {1}", fourthVariable, fourthVariable.GetType());
        Console.WriteLine("Fifth variable  is {0,8} of type {1}", fifthVariable, fifthVariable.GetType());

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}