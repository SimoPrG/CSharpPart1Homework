/*Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix
    like in the examples below. Use two nested loops.

Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
*/

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Title = "Matrix of Numbers"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N (1...20): ");
        int n = int.Parse(Console.ReadLine());

        string matrix = "\r\n";
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                matrix += string.Format("{0,2}", j);
            }
            matrix += "\r\n";
        }

        Console.Write(matrix);

        Console.ReadKey(); // Keeping the console opened.
    }
}