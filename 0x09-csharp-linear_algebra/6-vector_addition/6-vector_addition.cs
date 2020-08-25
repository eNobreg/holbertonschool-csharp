using System;

class VectorMath
{
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
