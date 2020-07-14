using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        for (counter = 0; counter <= 99; counter++) {
            if (counter != 99)
                Console.Write("{0:00}, ", counter);
            else
                Console.Write("{0:00}\n", counter);
        }
    }
}
