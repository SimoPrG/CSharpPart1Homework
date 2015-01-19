/*Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0.

Examples:
n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
2011 	    4 	    1102 	        1201 	                        2101
3333 	    12 	    3333 	        3333 	                        3333
9876 	    30 	    6789 	        6987 	                        9786
*/

using System;

class FourDigit
{
    static void Main()
    {
        //Changing the title of the console
        Console.Title = "Four-digit number";
        //Making sure that the result will show properly on the console.
        Console.WindowWidth = 100;

        Console.Write("Please, enter a four digit number: ");
        string digits = Console.ReadLine();

        //Checking if there are exactly four symbols in the string.
        if (digits.Length!=4)
        {
            Console.WriteLine("Your entry is not a four digit number!");
            Console.ReadKey();
            return;
        }

        //Checking if the first symbol is '0'
        if (digits[0]=='0')
        {
            Console.WriteLine("The number must start with a digit from 1 to 9!");
            Console.ReadKey();
            return;
        }

        byte digit; //each symbol from the string will be parsed to digit
        byte sum = 0; //this will keep the sum of the four digits
        foreach (char symbol in digits) //going through the digits string
        {
            //cheking if the user has entered only digits and adding them in sum
            if (byte.TryParse(symbol.ToString(), out digit))
            {
                sum += digit;
            }
            else
            {
                Console.WriteLine("You must enter only digits!");
                Console.ReadKey();
                return;
            }
        }

        //creating the needed strings
        string reversed = digits[3].ToString() + digits[2].ToString() +
            digits[1].ToString() + digits[0].ToString();
        string lastInFront = digits[3].ToString() + digits[0].ToString() +
            digits[1].ToString() + digits[2].ToString();
        string secondAndThirdExchanged = digits[0].ToString() + digits[2].ToString() +
            digits[1].ToString() + digits[3].ToString();

        //printing the result formated in an apropriate way.
        Console.WriteLine("Number\tSum of digits\tReversed\tLast digit in front\tSecond and third digits exchanged\r\n" +
            "{0,-6}\t{1,-13}\t{2,-8}\t{3,-19}\t{4,-33}", digits, sum, reversed, lastInFront, secondAndThirdExchanged);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}