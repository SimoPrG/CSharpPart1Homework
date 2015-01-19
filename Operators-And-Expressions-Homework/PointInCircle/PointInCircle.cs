/*Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

Examples:
x 	    y 	    inside
0 	    1 	    true
-2 	    0 	    true
-1 	    2 	    false
1.5 	-1 	    true
-1.5 	-1.5 	false
100 	-30 	false
0 	    0 	    true
0.2 	-0.8 	true
0.9 	-1.93 	false
1 	    1.655 	true
*/

using System;

class PointInCircle
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Point in a circle";

        Console.Write("Please, enter the 'x' coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the 'y' coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("The point is in the circle K({{0, 0}}, 2): {0}", (Math.Pow(x, 2) + Math.Pow(y, 2))<=4);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}