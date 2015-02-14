using System;

    //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
//3 credit card numbers associated with the account.
    //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middlename = "Ivanov";
            string lastName = "Geshev";
            decimal bankBalance = 1234567677.99M;
            string bankName = "My own BANK";
            long cardOne = 4444444444444444;
            long cardTwo = 3333333333333333;
            long cardThree = 1111111111111111;            
        }
    }