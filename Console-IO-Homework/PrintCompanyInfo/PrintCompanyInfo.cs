/* Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. The manager has first name,
    last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

Example input:
program 	            user
Company name: 	        Telerik Academy
Company address: 	    31 Al. Malinov, Sofia
Phone number: 	        +359 888 55 55 555
Fax number: 	        2
Web site: 	            http://telerikacademy.com/
Manager first name: 	Nikolay
Manager last name: 	    Kostov
Manager age: 	        25
Manager phone: 	        +359 2 981 981

Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
*/

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Title = "Print Company Information"; //Changes the title of the console.

        Console.Clear(); //Clears the console.
        Console.Write
            ("Please, enter the following information:\r\n" +
             "Company name.........:\r\n" +
             "Company address......:\r\n" +
             "Phone number.........:\r\n" +
             "Fax number...........:\r\n" +
             "Web site.............:\r\n" +
             "Manager first name...:\r\n" +
             "Manager last name....:\r\n" +
             "Manager age..........:\r\n" +
             "Manager phone........:");
        Console.SetCursorPosition(23, 1);
        string companyName = Console.ReadLine();
        Console.SetCursorPosition(23, 2);
        string companyAddress = Console.ReadLine();
        Console.SetCursorPosition(23, 3);
        string companyPhone = Console.ReadLine();
        Console.SetCursorPosition(23, 4);
        string companyFax = Console.ReadLine();
        Console.SetCursorPosition(23, 5);
        string companyWeb = Console.ReadLine();
        Console.SetCursorPosition(23, 6);
        string managerName = Console.ReadLine();
        Console.SetCursorPosition(23, 7);
        string managerFamily = Console.ReadLine();
        Console.SetCursorPosition(23, 8);
        string managerAge = Console.ReadLine();
        Console.SetCursorPosition(23, 9);
        string managerPhone = Console.ReadLine();

        Console.Clear();
        Console.WriteLine(String.IsNullOrWhiteSpace(companyName) ? "(no company name)" : companyName);
        Console.WriteLine("Address: {0}", String.IsNullOrWhiteSpace(companyAddress) ? "(no address)" : companyAddress);
        Console.WriteLine("Tel. {0}", String.IsNullOrWhiteSpace(companyPhone) ? "(no number)" : companyPhone);
        Console.WriteLine("Fax: {0}", String.IsNullOrWhiteSpace(companyFax) ? "(no fax)" : companyFax);
        Console.WriteLine("Web site: {0}", String.IsNullOrWhiteSpace(companyWeb) ? "(no web site)" : companyWeb);
        Console.Write("Manager: {0}", String.IsNullOrWhiteSpace(managerName) ? "unknown" : managerName);
        Console.Write(" {0} ", String.IsNullOrWhiteSpace(managerFamily) ? "unknown" : managerFamily);
        Console.Write("(age: {0}, ", String.IsNullOrWhiteSpace(managerAge) ? "unknown" : managerAge);
        Console.Write("tel. {0})\r\n", String.IsNullOrWhiteSpace(managerPhone) ? "unknown" : managerPhone);

        Console.ReadKey(); // Keeping the console opened.
    }
}