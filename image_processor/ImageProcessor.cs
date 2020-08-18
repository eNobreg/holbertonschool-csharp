using System;
using System.IO;
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
        Parallel.ForEach (filenames, file =>
        {
			invert_image(file);
        });
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
        extension = Path.GetExtension(file);
        filename = Path.GetFileNameWithoutExtension(file);

        for (int y = 0; y < img_height; y++)
        {
            for (int x = 0; x < img_width; x++)
            {
                Color inv = bmp.GetPixel(x, y);
				inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                bmp.SetPixel(x, y, inv);
            }
        }
        bmp.Save(filename + "_inverse" + extension);
    }
}
