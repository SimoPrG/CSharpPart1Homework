/*Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
*/

using System;

class NullValues
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Null Values Arithmetic";

        //Declaring number using the Type? format.
        int? number = null;
        //Declaring fraction using the Nullable<Type> format.
        Nullable<double> fraction = null;

        //The following code prints anything.
        Console.Write(number);
        Console.Write(fraction);

        number += null;
        fraction += null;

        //The following code also prints anything.
        Console.Write(number);
        Console.Write(fraction);

        number += 10;
        fraction += 10.0;

        //The following code still prints anything, because "null" is considered to be unknown.
        //If you add something to unknow you get unknown again.
        Console.Write(number);
        Console.Write(fraction);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}