/*Problem 2. Bonus Score

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is 0 or more than 9, the program prints “invalid score”.

Examples:
score 	result
2 	    20
4 	    400
9 	    9000
-1 	    invalid score
10 	    invalid score
*/

using System;

class BonusScore
{
    static void Main()
    {
        Console.Title = "Bonus Score"; //Changing the title of the console.

        Console.WriteLine("Please, enter your score to get the bonus!");
        Console.Write("score: ");
        int score = int.Parse(Console.ReadLine());
        int bonus;

        switch (score)
        {
            case 1:
            case 2:
            case 3: bonus = score * 10; Console.WriteLine("\r\nresult\r\n" + bonus); break;
            case 4:
            case 5:
            case 6: bonus = score * 100; Console.WriteLine("\r\nresult\r\n" + bonus); break;
            case 7:
            case 8:
            case 9: bonus = score * 1000; Console.WriteLine("\r\nresult\r\n" + bonus); break;
            default: Console.WriteLine("\r\nresult\r\ninvalid score"); break;
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}