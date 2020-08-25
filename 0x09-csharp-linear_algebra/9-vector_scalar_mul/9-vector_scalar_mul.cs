using System;

class VectorMath
{
    /// <summary>
    /// Function to multiply a vector by a scalar value
    /// </summary>
    /// <param name="vector">The 2D or 3D vector to multiply </param>
    /// <param name="scalar">The double, scalar value to multiply by</param>
    /// <returns>-1 or the resulting vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {

        if (vector.Length <= 3 && vector.Length >= 2)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= scalar;
            return (vector);
        }
        return (new double[1]{-1});
    }
}
