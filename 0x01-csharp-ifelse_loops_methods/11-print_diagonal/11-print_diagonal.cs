using System;

class Line 
{
    public static void PrintDiagonal(int length)
    { 
        string line = "";
        int counter = 0;
        if (length > 0) {
            for (counter = 1; counter <= length; counter++) {
                line = new String(' ', counter - 1);
                Console.WriteLine("{0}\\", line);
            }
        }
        Console.Write("\n");
    }
}