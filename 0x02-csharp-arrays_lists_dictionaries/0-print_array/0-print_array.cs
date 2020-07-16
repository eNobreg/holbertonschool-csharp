using System;
using System.Linq;
class Array
{
	public static int[] CreatePrint(int size)
	{
        if (size < 0) 
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

		int[] new_array = Enumerable.Range(0, size).ToArray();

        foreach(int number in new_array) {
			Console.Write(number);
            if (number != size - 1)
				Console.Write(" ");
		}
		Console.WriteLine("");
		return (new_array);
	}
}
