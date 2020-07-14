using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        string currentNum = "0";

        for (counter = 0; counter <= 99; counter++) {
            currentNum = counter.ToString("00");
            if (counter != 89)
            {
                if (currentNum[0] - '0' < currentNum[1] - '0')
                    Console.Write("{0:00}, ", counter);
            }
            else
                Console.WriteLine("{0:00}", counter);
        }
    }
}
