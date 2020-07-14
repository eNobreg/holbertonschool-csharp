using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (counter = 1; counter <= 100; counter++) {
                if (counter % 3 == 0 && counter % 5 == 0)
                    Console.Write("FizzBuzz");
                else if (counter % 5 == 0) {
                    Console.Write("Buzz");
                }
                else if (counter % 3 == 0) {
                    Console.Write("Fizz");
                }
                else
                {
                    Console.Write(counter);
                }
                if (counter != 100) {
                    Console.Write(" ");
                }
                else {
                    Console.Write("\n");
                }
            }
        }
    }
}
