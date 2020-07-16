using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        array[2, 2] = 1;
        PrintArray(array);
    }
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
