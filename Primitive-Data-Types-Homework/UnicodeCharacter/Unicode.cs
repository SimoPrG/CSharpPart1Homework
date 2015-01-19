/*Problem 4. Unicode Character

    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the
    \u00XX syntax, and then print it.

Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
*/

using System;

class Unicode
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Unicode Character \\u002A Asterisk";

        //42 decimal is 2A hexadecimal.
        char asterisk = '\u002A';
        Console.WriteLine(@"The symbol which has unicode symbol \u002A (42 decimal) is '{0}'.", asterisk);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}