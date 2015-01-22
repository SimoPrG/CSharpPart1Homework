/*Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

Examples:
numbers 	number as words
0 	    Zero
9 	    Nine
10 	    Ten
12 	    Twelve
19 	    Nineteen
25 	    Twenty five
98 	    Ninety eight
98 	    Ninety eight
273 	Two hundred and seventy three
400 	Four hundred
501 	Five hundred and one
617 	Six hundred and seventeen
711 	Seven hundred and eleven
999 	Nine hundred and ninety nine
*/

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Title = "Number as Words"; //Changing the title of the console.

        Console.Write("Please, enter a number (0-999): ");
        string userInput = Console.ReadLine();
        ushort number;
        string numberAsWords = null;

        if (ushort.TryParse(userInput, out number))
        {
            if (number > 999)
            {
                Console.Write("\r\nnumber\tnumber as words\r\n{0}\tInvalid number", userInput);
                Console.ReadKey(); // Keeping the console opened.
                return;
            }

            byte hundreds = (byte)((number / 100) % 10);
            byte tenths = (byte)((number / 10) % 10);
            byte units = (byte)(number % 10);

            switch (hundreds)
            {
                case 1: numberAsWords += "one hundred"; break;
                case 2: numberAsWords += "two hundred"; break;
                case 3: numberAsWords += "three hundred"; break;
                case 4: numberAsWords += "four hundred"; break;
                case 5: numberAsWords += "five hundred"; break;
                case 6: numberAsWords += "six hundred"; break;
                case 7: numberAsWords += "seven hundred"; break;
                case 8: numberAsWords += "eight hundred"; break;
                case 9: numberAsWords += "nine hundred"; break;
                default:
                    break;
            }
            if (hundreds != 0 && (tenths != 0 || units != 0))
            {
                numberAsWords += " and ";
            }
            switch (tenths)
            {
                case 1: switch (units)
                    {
                        case 0: numberAsWords += "ten"; break;
                        case 1: numberAsWords += "eleven"; break;
                        case 2: numberAsWords += "twelve"; break;
                        case 3: numberAsWords += "thirteen"; break;
                        case 4: numberAsWords += "fourteen"; break;
                        case 5: numberAsWords += "fifteen"; break;
                        case 6: numberAsWords += "sixteen"; break;
                        case 7: numberAsWords += "seventeen"; break;
                        case 8: numberAsWords += "eighteen"; break;
                        case 9: numberAsWords += "nineteen"; break;
                        default:
                            break;
                    }
                    break;
                case 2: numberAsWords += "twenty"; break;
                case 3: numberAsWords += "thirty"; break;
                case 4: numberAsWords += "forty"; break;
                case 5: numberAsWords += "fifty"; break;
                case 6: numberAsWords += "sixty"; break;
                case 7: numberAsWords += "seventy"; break;
                case 8: numberAsWords += "eighty"; break;
                case 9: numberAsWords += "ninety"; break;
                default:
                    break;
            }
            if (tenths != 0 && tenths != 1 && units != 0) numberAsWords += " ";
            if (tenths != 1)
            {
                switch (units)
                {
                    case 0: if ((hundreds == 0) && (tenths == 0)) numberAsWords = "zero"; break;
                    case 1: numberAsWords += "one"; break;
                    case 2: numberAsWords += "two"; break;
                    case 3: numberAsWords += "three"; break;
                    case 4: numberAsWords += "four"; break;
                    case 5: numberAsWords += "five"; break;
                    case 6: numberAsWords += "six"; break;
                    case 7: numberAsWords += "seven"; break;
                    case 8: numberAsWords += "eight"; break;
                    case 9: numberAsWords += "nine"; break;
                    default:
                        break;
                }
            }
            numberAsWords = char.ToUpper(numberAsWords[0]) + numberAsWords.Substring(1);
            Console.Write("\r\nnumber\tnumber as words\r\n{0}\t{1}", userInput, numberAsWords);
        }
        else
        {
            Console.Write("\r\nnumber\tnumber as words\r\n{0}\tInvalid number", userInput);
        }


        Console.ReadKey(); // Keeping the console opened.
    }
}