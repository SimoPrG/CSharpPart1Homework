/*Problem 11. Bank Account Data

    A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
    bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types
    and descriptive names.
*/

using System;

class BankAccount
{
    static void Main()
    {
        //Giving a title to the console.
        Console.Title = "Bank Account Data";

        string firstName = "Johnnie";
        string middleName = "Bravo";
        string lastName = "Bravissiomo";
        decimal balance = 1000000000.01m;
        string bankName = "Corporate Commersial Bank AD";
        string iban = "BG06KORP92203481113001";
        long firstCard = 3479414556233035;
        long secondCard = 5541382122300905;
        long thirdCard = 4532562235885876;

        Console.WriteLine
            ("First name:  {0}\r\n" +
             "Middle name: {1}\r\n" +
             "Last name:   {2}\r\n" +
             "Balance:     {3:C}\r\n" +
             "Bank name:   {4}\r\n" +
             "IBAN:        {5}\r\n" +
             "First card:  {6}\r\n" +
             "Second card: {7}\r\n" +
             "Third card:  {8}",
             firstName, middleName, lastName, balance, bankName, iban, firstCard, secondCard, thirdCard);

        //Hiding the "Press any key to continue..." message.
        Console.ReadKey();
    }
}