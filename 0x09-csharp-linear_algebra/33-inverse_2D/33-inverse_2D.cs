using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(0) != matrix.GetLength(1))
            return (-1);

        double temp = matrix[1, 1];

        matrix[1, 1] = matrix[0, 0];
        matrix[0, 0] = temp;
        matrix[0, 1] *= -1;
        matrix[1, 0] *= -1;

        double determinate = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        if (determinate != 0)
        {
            matrix[0, 0] /= determinate;
            matrix[0, 1] /= determinate;
            matrix[1, 1] /= determinate;
            matrix[1, 0] /= determinate;
            return (matrix);
        }
        return (-1);
    }
}