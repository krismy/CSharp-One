using System;
using System.Text;

    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number;
                        
            for(number = 0; number < 256; number ++)
            {
                char symbol = (char)number;
                char output = symbol;

               if (output == ' ')
                {
                    return;
                }
               else
                {
                    Console.Write("{0}, ", symbol);
                }
            }
            Console.WriteLine("\n");
        }
    }
