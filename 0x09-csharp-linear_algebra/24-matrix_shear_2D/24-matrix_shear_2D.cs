﻿using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double [,] shearMatrix = new double[,] {{1, 0}, {0, 1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,]{{-1}});

        if (direction == 'x')
            shearMatrix[1, 0] = factor;
        else if (direction == 'y')
            shearMatrix[0, 1] = factor;
        else
            return (new double[,]{{-1}});
        

        double[,] results = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                double save = 0;
                for (int k = 0; k < 2; k++)
                    save += matrix[i, k] * shearMatrix[k, j];
                results[i, j] = Math.Round(save, 2);
            }
        }
        return (results);
    }
}
