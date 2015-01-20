/*Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
    (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

Note: You may need to learn how to use loops.

Examples:
n 	comments
1 	0
3 	0 1 1
10 	0 1 1 2 3 5 8 13 21 34
*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Fibonacci Numbers"; //Changing the title of the console.

        Console.Write("Enter an integer n to see the first n members of the Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());
        string[] fiboMembers = new string[n]; // This array will keep the members of the Fibonacci sequence.

        for (long i = 0, a = 0, b = 1; i < n; i++)// In the for loop we declare a counter i and the first two members of the sequence (0 and 1).
        {
            fiboMembers[i] = a.ToString(); //We convert the member to string and we place it in its array position.
            b = a + b;//Then we add the previous member to the next member.
            a = b - a;//From the new next member we substract the previous member. (b=a+b and so b - a is a+b - a = b)
        }
        Console.WriteLine(string.Join(", ",fiboMembers)); //Creating a string in the requested format and printing it.

        Console.ReadKey(); // Keeping the console opened.
    }
}