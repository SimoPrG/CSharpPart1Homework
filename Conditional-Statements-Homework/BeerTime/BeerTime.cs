/*Problem 10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and
    AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the
    time cannot be parsed. Note: You may need to learn how to parse dates and times.

Examples:
time 	    result
1:00 PM 	beer time
4:30 PM 	beer time
10:57 PM 	beer time
8:30 AM 	non-beer time
02:59 AM 	beer time
03:00 AM 	non-beer time
03:26 AM 	non-beer time
*/

using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.Title = "Beer Time"; // Changing the title of the console.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US"); // Setting the culture to en-US

        Console.Write("Please, enter a time in format “hh:mm tt”: ");
        string userInput = Console.ReadLine();

        DateTime nonBeerTime; // We will parse the userInput in this DateTime variable.
        if (DateTime.TryParse(userInput, out nonBeerTime))
        {
            TimeSpan nonBeerStart = TimeSpan.FromHours(3); // We set a time span for the beginning of the non-beer time.
            TimeSpan nonBeerEnd = TimeSpan.FromHours(13); // We set a time span for the end of the non-beer time.
            if ((nonBeerTime.TimeOfDay >= nonBeerStart)&&(nonBeerTime.TimeOfDay < nonBeerEnd))
            {// If the time is between the start and the end of the non-beer time it is non-beer time
                Console.WriteLine("\r\nThe time {0:t} is a non-beer time", nonBeerTime);
            }
            else
            {
                Console.WriteLine("\r\nThe time {0:t} is a beer time", nonBeerTime);
            }
        }
        else // If the userInput is invalid DateTime format this "else" will be executed.
        {
            Console.WriteLine("\r\nInvalid time!");
        }

        Console.ReadKey(); // Keeping the console opened.
    }
}