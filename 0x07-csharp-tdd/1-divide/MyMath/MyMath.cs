using System;

namespace MyMath
{
    /// <summary>
    /// Class for operations dealing with a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide a matrix by the number given
        /// </summary>
        /// <param name="matrix"> The matrix to divide</param>
        /// <param name="num">Number to divide the matrix by</param>
        /// <returns>The matrix with it's element divided</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
                return (null);
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] / num;
                }

            }
            return (matrix); 
        }
    }
}
