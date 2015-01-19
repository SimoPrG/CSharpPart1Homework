/*Problem 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.
*/

using System;

class Exchange
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Exchange Variable Values";

        int a = 5;
        int b = 10;

        Console.WriteLine("a is {0}, b is {1}.", a, b);
        //We are going to exchange the values of "a" and "b" without a third variable for educational purposes.
        //We are going to use the "XOR swap algorithm".
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("a is {0}, b is {1}.", a, b);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}