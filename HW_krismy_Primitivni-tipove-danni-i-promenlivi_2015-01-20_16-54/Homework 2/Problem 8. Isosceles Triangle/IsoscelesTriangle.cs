using System;

class CopyrightTriangle
{
    static void Main()
    {
        int code = 169;
        char copyright = (char)code;
       
        Console.WriteLine("   {0}\n\n", copyright);
        Console.WriteLine("  {0} {0}\n\n", copyright);
        Console.WriteLine(" {0}   {0}\n\n", copyright);
        Console.WriteLine("{0} {0} {0} {0}\n", copyright);
    }
}
