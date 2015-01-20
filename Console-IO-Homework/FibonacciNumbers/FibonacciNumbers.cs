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

        for (long i = 0, previousMember = 0, nextMember = 1, temp; i < n; i++)
        // In the for loop we declare the first two members of the sequence (0 and 1) and a temp variable 
        // needed for the calculations.
        {
            fiboMembers[i] = previousMember.ToString(); //We convert the member to string and we place it in its array position.
            temp = nextMember;//After that we assign the value of the next member to temp.
            nextMember += previousMember;//Then we add the previous member to the next member.
            previousMember = temp;//Finally, we assign the value of the temp to the previous member.
        }
        Console.WriteLine(string.Join(", ",fiboMembers)); //Creating a string in the requested format and printing it.

        Console.ReadKey(); // Keeping the console opened.
    }
}