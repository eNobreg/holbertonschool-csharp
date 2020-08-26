using System;

class VectorMath
{
    /// <summary>
    /// Function to calculate the dot product of two vectors
    /// 2D or 3D vectors are accepted
    /// </summary>
    /// <param name="vector1">A 3D or 2D array of doubles representing a vector</param>
    /// <param name="vector2">A 3D or 2D array of doubles representing another vector</param>
    /// <returns>-1 or the scalar dot product</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dot_prod = 0;

        if (vector1.Length == vector2.Length && vector1.Length <= 3 && vector1.Length >= 2)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] *= vector2[i];
                dot_prod += vector1[i];
            }
            return (dot_prod);
        }
        return (-1);
    }
}