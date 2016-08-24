/*
Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Valentin";
        string middleName = "Georgiev";
        string lastName = "Makaveev";
        double balance = 200.20;
        string bankName = "Unicredit";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long firstCard = 5610591081018250;
        long secondCard = 30569309025904;
        long thirdCard = 3566002020360505;
    }
}

