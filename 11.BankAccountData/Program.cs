using System;
/*
    Problem 11. Bank Account Data
    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */
class BankAccountData
{
    static void Main()
    {
        string firstName = "Stoyan";
        string middleName = "Zahariev";
        string lastName = "Stoyanov";
        string fullName = firstName + " " + middleName + " " + lastName;
        decimal balance = 123.43M;
        string bankName = "DSK";
        string IBAN = "BG45STA93000048569355";
        long creditCardNumber1 = 6295586693774855L;
        long creditCardNumber2 = 6295586672994775L;
        long creditCardNumber3 = 6295586688888577L;

        Console.WriteLine(@"Name: {0}
Balance: {1}
Bank name: {2}
IBAN: {3}
First credit card number: {4}
Second credit card number: {5}
Third credit card number: {6}", fullName, balance, bankName, IBAN, creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}
