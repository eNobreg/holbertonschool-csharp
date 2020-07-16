using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int counter = 0;

        if (array != null)
            for (counter = array.Length - 1; counter >= 0; counter--)
            {
                Console.Write(array[counter]);
                if (counter != 0) {
                    Console.Write(" ");
                }
            }
        Console.WriteLine("");
    }
}
