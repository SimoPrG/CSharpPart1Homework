/*Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

Example 1:
program 	            user
Please choose a type: 	
1 --> int 	
2 --> double 	        3
3 --> string 	
	
Please enter a string: 	hello
	
hello* 	

Example 2:
program 	            user
Please choose a type: 	
1 --> int 	
2 --> double 	        2
3 --> string 	
	
Please enter a double: 	1.5
	
2.5
*/

using System;
using System.Globalization;
using System.Threading;

class IntDoubleString
{
    static void Main()
    {
        Console.Title = "Sort 3 Numbers with Nested Ifs"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.Write
            ("Please, choose a type:\r\n" +
             "1 --> int\r\n" +
             "2 --> double\r\n" +
             "3 --> string\r\n" +
             ":");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                {
                    Console.Write("\r\nPlease, enter an integer: ");
                    int integer = int.Parse(Console.ReadLine());
                    integer++;
                    Console.WriteLine("\r\n{0}", integer);
                }
                break;
            case "2":
                {
                    Console.Write("\r\nPlease, enter a double: ");
                    double number = double.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("\r\n{0}", number);
                }
                break;
            case "3":
                {
                    Console.Write("\r\nPlease, enter a string: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("\r\n{0}", text + "*");
                }
                break;
            default:
                Console.WriteLine("Not a valid choice!");
                break;
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}