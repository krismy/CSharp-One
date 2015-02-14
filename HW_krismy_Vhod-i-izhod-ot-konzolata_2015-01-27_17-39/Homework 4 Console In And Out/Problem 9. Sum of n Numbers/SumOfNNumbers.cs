using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("A program that enters a number n and after that enters more n numbers and calculates and prints their sum.");
            Console.Write("Enter number n: ");
            int enteredN = int.Parse(Console.ReadLine());
            double sumN = 0;
            Console.WriteLine("Entere values for those {0} numbers:", enteredN);
            for (int i = 1; i <= enteredN; i++ )
                {
                    sumN += double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Result is: " + sumN);
        }
    }