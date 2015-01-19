/*Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.
*/

using System;

class Quotes
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Quotes in Strings";

        string quotation = "The \"use\" of quotations causes difficulties.";
        string verbatim = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotation);
        Console.WriteLine(verbatim);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}