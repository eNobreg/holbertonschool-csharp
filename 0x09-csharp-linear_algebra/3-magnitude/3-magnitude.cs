using System;

class VectorMath 
{
    public static double Magnitude(double[] vector)
    {
        double total = 0;
        if (vector.Length <= 3 && vector.Length > 1)
        {
            foreach (double entry in vector)
                total += Math.Pow(entry, 2);
        }
        return(Math.Round(Math.Sqrt(total), 2));
    }
}
