/*Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

Examples:
weight 	weight on the Moon
86  	14.62
74.6 	12.682
53.7 	9.129
 */

using System;

class MoonGravity
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Gravity on the moon";

        Console.Write("Please, don't be shy and enter your weight (: ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("weight\tweight on the Moon\r\n" +
            "{0}\t{1}", weight, (weight*0.17));

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}