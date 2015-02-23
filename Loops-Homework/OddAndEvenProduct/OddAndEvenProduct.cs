/*Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

Examples:
numbers 	result
2 1 1 6 3 	yes
product = 6 	
	
3 10 4 6 5 1 	yes
product = 60 	
	
4 3 2 5 2 	no
odd_product = 16 	
even_product = 15
*/

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Title = "Odd and Even Product"; //Changing the title of the console.

        Console.Write("Please, enter a string of numbers separated by space!\r\n: ");
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split();
        int oddProduct = 1;
        int evenProduct = 1;
        for (int number, i = 0; i < numbers.Length; i++)
        {
            number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}