using System;

class VectorMath
{
    /// <summary>
    ///  Add two 2D or 3D vectors together
    /// </summary>
    /// <param name="vector1">First double vector to add together</param>
    /// <param name="vector2">Second double vector to add together</param>
    /// <returns>-1 in an array, or an array representing the result vector</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        
        int vectorLength = vector1.Length;
        double[] final = new double[vectorLength];

        if (vector1.Length == vector2.Length && vectorLength <= 3 && vectorLength >= 2)
        {
            for (int i = 0; i < vectorLength; i++)
                final[i] = vector1[i] + vector2[i];
            return (final);
        }
        return (new double[1]{-1});
    }
}
