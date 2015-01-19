/*Problem 6. Strings and Objects

    Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

using System;

class StringsAndObjects
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Strings and Objects";

        string hello = "Hello";
        string world = "World";
        object helloWorldObj = hello + " " + world;
        string helloWorldStr = (string)helloWorldObj;

        Console.WriteLine("string hello is \"{0}\"", hello);
        Console.WriteLine("string world is \"{0}\"", world);
        Console.WriteLine("object helloWorldObj is \"{0}\"", helloWorldObj);
        Console.WriteLine("string helloWorldStr is \"{0}\"", helloWorldStr);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}