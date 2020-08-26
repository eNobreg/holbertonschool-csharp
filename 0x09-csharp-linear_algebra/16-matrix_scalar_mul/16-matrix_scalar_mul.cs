using System;

class MatrixMath
{
    /// <summary>
    ///  Mulitply a 2D or 3D matrix by a sclar value
    /// </summary>
    /// <param name="matrix"> Matrix to mutliple </param>
    /// <param name="scalar">The value to multiple the matrix by</param>
    /// <returns>The resulting matrix, or -1 on error</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {

        if (matrix.GetLength(0) >= 2 && matrix.GetLength(0) <= 3)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] *= scalar;
            return (matrix);
        }
        return (new double[,]{{-1}});
    }
}
