/*Problem 12.* Zero Subset

    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem.

Examples:
numbers 	    result
3 -2 1 1 8 	    -2 + 1 + 1 = 0
	
3 1 -7 35 22 	no zero subset
	
1 3 -4 -2 -1 	1 + -1 = 0
	            1 + 3 + -4 = 0
	            3 + -2 + -1 = 0
	
1 1 1 -1 -1 	1 + -1 = 0
	            1 + 1 + -1 + -1 = 0
	
0 0 0 0 0 	    0 + 0 + 0 + 0 + 0 = 0

Hint: you may check for zero each of the 32 subsets with 32 if statements.
*/

using System;

class ZeroSubset
{
    static void Main()
    {
        int number;
        int[] numbers = new int[5];
        bool result = false;

        for (int i = 0; i <= 4; i++)
        {
        here:
            Console.Write("Please, enter number {0}: ", i + 1);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                numbers[i] = number;
            }
            else
            {
                goto here;
            }
        }

        //if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
        //{
        //    result = true;
        //    Console.WriteLine(String.Join("+", numbers) + " = 0");
        //    Console.ReadKey(); // Keeping the console opened.
        //    return;
        //}

        for (int firstNum = 0; firstNum <= 3; firstNum++)
        {
            for (int secondNum = firstNum + 1; secondNum <= 4; secondNum++)
            {
                if (numbers[firstNum] + numbers[secondNum] == 0)
                {
                    result = true;
                    Console.WriteLine("{0} + {1} = 0", numbers[firstNum], numbers[secondNum]);
                }
            }
        }

        for (int firstNum = 0; firstNum <= 2; firstNum++)
        {
            for (int secondNum = firstNum + 1; secondNum <= 3; secondNum++)
            {
                for (int thirdNum = secondNum + 1; thirdNum <= 4; thirdNum++)
                {
                    if (numbers[firstNum] + numbers[secondNum] + numbers[thirdNum] == 0)
                    {
                        result = true;
                        Console.WriteLine("{0} + {1} + {2} = 0", numbers[firstNum], numbers[secondNum], numbers[thirdNum]);
                    }
                }
            }
        }

        for (int firstNum = 0; firstNum <= 1; firstNum++)
        {
            for (int secondNum = firstNum + 1; secondNum <= 2; secondNum++)
            {
                for (int thirdNum = secondNum + 1; thirdNum <= 3; thirdNum++)
                {
                    for (int fourthNum = thirdNum + 1; fourthNum <= 4; fourthNum++)
                    {
                        if (numbers[firstNum] + numbers[secondNum] + numbers[thirdNum] + numbers[fourthNum] == 0)
                        {
                            result = true;
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[firstNum], numbers[secondNum]
                                    , numbers[thirdNum], numbers[fourthNum]);
                        }
                    }
                }
            }
        }

        if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            result = true;
            Console.WriteLine(String.Join(" + ", numbers) + " = 0");
        }

        if (result == false)
        {
            Console.WriteLine("no zero subset");
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}