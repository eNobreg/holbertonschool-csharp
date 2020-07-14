using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        for (counter = 0; counter <= 98; counter++) {
            Console.Write("{0:D} = 0x{0:x}\n", counter);
        }
    }
}
