using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Class for image processing methods
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Invert images based on filenames
    /// </summary>
    /// <param name="filenames">List of str filenames to invert</param>
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Thread t = new Thread(ImageProcessor.invert_image);
            t.Start(file);
        }
    }

    /// <summary>
    /// Invert single image passed by Inverse function
    /// </summary>
    /// <param name="data">Single file to invert</param>

    public static void invert_image(object data)
    {        
        string file = data.ToString();
        int img_width;
        int img_height;
        string filename = "";
        string extension = "";

        Bitmap bmp = new Bitmap(file);
        img_width = bmp.Width;
        img_height = bmp.Height;
        filename = file.Substring(7, file.Length - 11);
        extension = file.Substring(file.Length - 4, 4);
        Console.WriteLine(extension);
        Console.WriteLine(filename);

        for (int y = 0; y < img_height; y++)
        {
            for (int x = 0; x < img_width; x++)
            {
                Color p = bmp.GetPixel(x, y);

                int r = 255 - p.R;
                int g = 255 - p.G;
                int b = 255 - p.B;
                int a = p.A;

                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
            }
        }
        bmp.Save(filename + "_inverse" + extension);
        Console.WriteLine($"{filename} done");
    }
}
