using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine("The value of a is {0}, and b is {1}!", a, b);

            var c = a;
            a = b;
            b = c;

            Console.WriteLine("Now the value of a is {0}, and b is {1}!", a, b);
        }
    }
