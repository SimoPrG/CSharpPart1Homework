/*Problem 2. Float or Double?

    Which of the following values can be assigned to a variable of type float and which to a variable
    of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

class FloatOrDouble
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Float or Double";

        double firstVariable = 34.567839023d;
        float secondVariable = 12.345f;
        double thirdVariable = 8923.1234857d;
        float fourthVariable = 3456.091f;

        //Printing the variables.
        Console.WriteLine("First variable  is {0,12} of type {1}", firstVariable, firstVariable.GetType());
        Console.WriteLine("Second variable is {0,12} of type {1}", secondVariable, secondVariable.GetType());
        Console.WriteLine("Third variable  is {0,12} of type {1}", thirdVariable, thirdVariable.GetType());
        Console.WriteLine("Fourth variable is {0,12} of type {1}", fourthVariable, fourthVariable.GetType());

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}