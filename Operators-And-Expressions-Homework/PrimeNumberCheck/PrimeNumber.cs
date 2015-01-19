/*Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n = 100) is prime
   (i.e. it is divisible without remainder only to itself and 1).

Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false
*/

using System;

class PrimeNumber
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Prime number check";

        Console.Write("Please, enter a number between 0 and 100: ");
        int number = int.Parse(Console.ReadLine());
        bool prime = true; // prime is a flag if the number is prime. It defaults to True.

        if (number < 2) // By definition, all the numbers smaller than 2 are not prime.
        {
            prime = false;
            Console.WriteLine("Number\tPrime?\r\n{0}\t{1}", number, prime);
            //Hiding the "Press any key to continue..." message.
            Console.ReadKey();
            return;
        }
        else if (number>100) // The condition of the problem is that the number must not be greater than 100.
        {
            Console.WriteLine("Your number is greater than 100!");
            //Hiding the "Press any key to continue..." message.
            Console.ReadKey();
            return;
        }

        int root = (int)Math.Sqrt(number); // We will check if the number is devisible by any number between 2 and its root.
        for (int i = 2; i <= root; i++)
        {
            if (number % i == 0)
            {
                prime = false;
                break; // Terminating the for cycle because we've just found out that the number is not prime.
            }
        }

        Console.WriteLine("Number\tPrime?\r\n{0}\t{1}", number, prime);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}