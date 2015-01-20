/*Problem 3. Circle Perimeter and Area

    Write a program that reads the radius r of a circle and prints its perimeter
    and area formatted with 2 digits after the decimal point.

Examples:
r 	    perimeter 	area
2 	    12.57 	    12.57
3.5 	21.99 	    38.48
*/

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Title = "Circle Perimeter and Area"; //Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); //Setting the culture to en-US

        Console.Write("Please, enter the radius of the circle!\r\nr: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * r * Math.PI;
        double area = r * r * Math.PI;

        Console.WriteLine();
        Console.WriteLine("{0,-16}{1,-16}{2,-16}", "r", "perimeter", "area");
        Console.WriteLine("{0,-16:F2}{1,-16:F2}{2,-16:F2}", r, perimeter, area);

        Console.ReadKey(); // Keeping the console opened.
    }
}