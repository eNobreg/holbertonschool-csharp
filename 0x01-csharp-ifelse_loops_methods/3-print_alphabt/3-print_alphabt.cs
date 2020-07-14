using System;

class Program
{
    static void Main(string[] args)
    {
        char start_letter = 'a';
        for (start_letter = 'a'; start_letter <= 'z'; start_letter++) {
            if (start_letter != 'q' && start_letter != 'e') {
                Console.Write(start_letter); 
            }
        }
    }
}
