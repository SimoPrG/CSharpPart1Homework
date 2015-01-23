/*Problem 4. Print a Deck of 52 Cards

    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
    The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and
    spades. Use 2 nested for-loops and a switch-case statement.

output

2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds

Note: You may use the suit symbols instead of text.
*/

using System;
using System.Globalization;
using System.Threading;

class PrintDeck52Cards
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string output = null;
        for (int rang = 0; rang < 13; rang++)
        {
            for (int suite = 6; suite > 2; suite--)
            {
                switch (rang)
                {
                    case 0: output += string.Format("{0,4}", "2" + (char)suite); break;
                    case 1: output += string.Format("{0,4}", "3" + (char)suite); break;
                    case 2: output += string.Format("{0,4}", "4" + (char)suite); break;
                    case 3: output += string.Format("{0,4}", "5" + (char)suite); break;
                    case 4: output += string.Format("{0,4}", "6" + (char)suite); break;
                    case 5: output += string.Format("{0,4}", "7" + (char)suite); break;
                    case 6: output += string.Format("{0,4}", "8" + (char)suite); break;
                    case 7: output += string.Format("{0,4}", "9" + (char)suite); break;
                    case 8: output += string.Format("{0,4}", "10" + (char)suite); break;
                    case 9: output += string.Format("{0,4}", "J" + (char)suite); break;
                    case 10: output += string.Format("{0,4}", "Q" + (char)suite); break;
                    case 11: output += string.Format("{0,4}", "K" + (char)suite); break;
                    case 12: output += string.Format("{0,4}", "A" + (char)suite); break;
                }
            }
            output += "\r\n";
        }
        Console.Write(output);

        Console.ReadKey(); // Keeping the console opened.
    }
}