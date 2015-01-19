/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.
*/

using System;

class Employee
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Employee Data";

        string firstName = "Johnnie";
        string secondName = "Walker";
        byte age=67;
        char gender = 'm';
        long personalIDNumber = 8306112507L;
        int uniqueEmployeeNumber = 27569000;

        Console.WriteLine
           ("First name:             {0,10}\r\n" +
            "Second name:            {1,10}\r\n" +
            "age:                    {2,10}\r\n" +
            "gender:                 {3,10}\r\n" +
            "Personal ID number:     {4,10}\r\n" +
            "Unique employee number: {5,10}",
            firstName, secondName, age, gender, personalIDNumber, uniqueEmployeeNumber);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}