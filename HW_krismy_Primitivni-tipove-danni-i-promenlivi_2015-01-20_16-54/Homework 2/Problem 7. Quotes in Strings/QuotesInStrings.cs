using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string firstMethod = @"The ""use"" of quotations causes difficulties.";
            string secondMethod = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(firstMethod);
            Console.WriteLine(secondMethod);
        }
    }
