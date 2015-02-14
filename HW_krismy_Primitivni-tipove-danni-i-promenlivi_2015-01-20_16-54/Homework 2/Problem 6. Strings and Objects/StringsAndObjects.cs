using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string stringOne = "Hello";
            string stringTwo = "Word";
            object objectOne = stringOne + " " + stringTwo;
            string stringThree = (string)objectOne;

            Console.WriteLine(stringThree);
        }
    }