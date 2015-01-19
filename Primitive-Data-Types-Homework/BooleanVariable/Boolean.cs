/*Problem 5. Boolean Variable

    Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    Print it on the console.
*/

using System;

class Boolean
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Boolean Variable isFemale";

        bool isFemale = false;
        Console.WriteLine("The value of isFemale is {0}.", isFemale);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}