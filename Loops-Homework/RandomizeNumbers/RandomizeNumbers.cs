/*Problem 12.* Randomize the Numbers 1…N

    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

Examples:
n 	randomized numbers 1…n
3 	2 1 3
10 	3 4 8 2 6 7 9 1 10 5

Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
      You might need to use arrays.
*/

using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Title = "Randomize the Numbers 1…N"; //Changing the title of the console.

        Console.Write("Please, enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());

        int[] randomArray = new int[n];
        for (int i = 0; i < n; )
        {
            randomArray[i] = ++i;
        }

        Random getRandom = new Random();
        for (int temp, firstRandom, secondRandom, i = 0; i < n; i++)
        {
            firstRandom = getRandom.Next(0, n);
            secondRandom = getRandom.Next(0, n);
            temp = randomArray[firstRandom];
            randomArray[firstRandom] = randomArray[secondRandom];
            randomArray[secondRandom] = temp;
        }

        Console.WriteLine(string.Join(" ", randomArray));

        Console.ReadKey(); // Keeping the console opened.
    }
}