using System;
/* 
    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
*/ 

    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Enter 1, 2 or 3: \n1 --> Int \n2 --> Double \n3 --> String");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNumber + 1);
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNumber+1);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string enteredString = Console.ReadLine();
                    Console.WriteLine(enteredString + "*");
                    break;
                default:
                    Console.WriteLine("Unexpected input!");
                    break;
            }
        }
    }
