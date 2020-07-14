using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_digit = number % 10;
        string message = "The last digit of";
        if (last_digit > 5)
            Console.WriteLine("{0} {1} is {2} and is greater than 5", message, number, last_digit);
        else if (last_digit == 0)
            Console.WriteLine("{0} {1} is {2} and is 0", message, number, last_digit);
        else
            Console.WriteLine("{0} {1} is {2} and is less than 6 and not 0", message, number, last_digit);
    }
}