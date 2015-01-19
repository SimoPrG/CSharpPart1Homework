/*Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
    and out of the rectangle R(top=1, left=-1, width=6, height=2).

Examples:
x 	    y 	inside K & outside of R
1 	    2 	    yes
2.5   	2 	    no
0 	    1 	    no
2.5    	1 	    no
2 	    0 	    no
4 	    0 	    no
2.5    	1.5 	no
2 	    1.5 	yes
1 	    2.5 	yes
-100 	-100 	no
*/

using System;

class PointInCircleOutRectangle
{
    static double circleXCoordinate = 1d;
    static double circleYCoodrinate = 1d;
    static double circleRadius = 1.5d;
    static double rectangleTop = 1d;
    static double rectangleLeft = -1d;
    static double rectangleWidth = 6d;
    static double rectangleHeight = 2;
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Point Inside a Circle & Outside of a Rectangle";

        Console.Write("Please, enter the 'x' coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the 'y' coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow(x-circleXCoordinate, 2) + Math.Pow(y-circleYCoodrinate, 2)) <=
            Math.Pow(circleRadius,2);

        bool isOutRectangle = (x < rectangleLeft) || (x > rectangleLeft + rectangleWidth) ||
            (y > rectangleTop) || (y < rectangleTop - rectangleHeight);

        Console.WriteLine("\r\n{0}{1}{2}", "x".PadRight(10),"y".PadRight(10), "inside K & outside of R");
        Console.WriteLine("\r\n{0}{1}{2}", x.ToString().PadRight(10), y.ToString().PadRight(10),
            (isInCircle && isOutRectangle) ? "yes" :"no" );

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}