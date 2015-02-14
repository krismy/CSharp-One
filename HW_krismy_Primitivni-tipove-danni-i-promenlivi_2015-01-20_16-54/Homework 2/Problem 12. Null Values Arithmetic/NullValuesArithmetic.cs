using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            //Assigning null values to variables
            int? nullInt = null;
            double? nullDouble = null;

            Console.WriteLine("Integer null value: {0}. Double null value: {1}.", nullInt, nullDouble);
            // assigning number to these variables
            nullInt = 4;
            nullDouble = 3.0;
            Console.WriteLine("Integer not null value: {0}. Double not null value: {1}.", nullInt, nullDouble);
        }
    }