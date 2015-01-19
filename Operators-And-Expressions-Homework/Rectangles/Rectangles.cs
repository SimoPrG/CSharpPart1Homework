/*Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.

Examples:
width 	height 	perimeter 	area
3 	    4 	    14 	        12
2.5 	3 	    11 	        7.5
5 	    5 	    20 	        25
*/

using System;

class Rectangles
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Rectangles";

        Console.Write("Please, enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("width\theight\tperimeter\tarea\r\n" +
            "{0}\t{1}\t{2}\t\t{3}", width, height, (width+height)*2, width*height);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}