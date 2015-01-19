/*Problem 15.* Age after 10 Years

    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthday;
        string birthdayString;
        bool isBirthdayPassed = false;

        Console.Write("Enter your birthday: ");
        birthdayString = Console.ReadLine();
        birthday = DateTime.Parse(birthdayString);
        // The following code checks if this year you already had a birthday.
        // We compare the months and the days if necessary.
        // If we just compare .DayOfYear properties, this will lead to bugs
        // when the year you are born xor the current year is a leap-year.
        if (DateTime.Now.Month - birthday.Month < 0)
        {
            isBirthdayPassed = false;
        }
        else if (DateTime.Now.Month - birthday.Month == 0)
        {
            if (DateTime.Now.Day - birthday.Day < 0)
            {
                isBirthdayPassed = false;
            }
            else
            {
                isBirthdayPassed = true;
            }
        }
        else if (DateTime.Now.Month - birthday.Month > 0)
        {
            isBirthdayPassed = true;
        }
        // This code prints how old you are now and how old you will be after 10 years.
        if (isBirthdayPassed)
        {
            Console.WriteLine("Now you are {0} years old.", DateTime.Now.Year - birthday.Year);
            Console.WriteLine("After 10 years you will be {0} years old.", DateTime.Now.Year - birthday.Year + 10);
        }
        else
        {
            Console.WriteLine("Now you are {0} years old.", DateTime.Now.Year - birthday.Year - 1);
            Console.WriteLine("After 10 years you will be {0} years old.", DateTime.Now.Year - birthday.Year + 9);
        }
    }
}