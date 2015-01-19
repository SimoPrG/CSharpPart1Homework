 /* Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of
      the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each
      other than a fixed constant eps.

Examples:
Number a 	Number b 	Equal  	                            Explanation
                        (with precision eps=0.000001)
5.3     	6.01 	    false 	                            The difference of 0.71 is too big (> eps)
5.00000001 	5.00000003 	true 	                            The difference 0.00000002 < eps
5.00000005 	5.00000001 	true 	                            The difference 0.00000004 < eps
-0.0000007 	0.00000007 	true 	                            The difference 0.00000077 < eps
-4.999999 	-4.999998 	false 	                            Border case. The difference 0.000001 == eps.
                                                            We consider the numbers are different.
4.999999 	4.999998 	false 	                            Border case. The difference 0.000001 == eps.
                                                            We consider the numbers are different.
*/

using System;

class FloatCompare
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Comparing Floats";

        double a = 5.3;
        double b = 6.01;
        bool equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        a = 5.00000001;
        b = 5.00000003;
        equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        a = 5.00000005;
        b = 5.00000001;
        //Float is rounding a and b to 5.
        equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        a = -0.0000007;
        b = 0.00000007;
        equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        a = -4.999999;
        b = -4.999998;
        equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        a = 4.999999;
        b = 4.999998;
        equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine("{0} is equal to {1} with precision 1.0e-006: {2}", a, b, equal);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}