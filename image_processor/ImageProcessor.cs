using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
    public static void invert_image(object data)
    {        
        string file = data.ToString();
        string filename = "";
        string extension = "";

        Bitmap bmp = new Bitmap(file);
        extension = Path.GetExtension(file);
        filename = Path.GetFileNameWithoutExtension(file);
        // Lock the bitmap's bits.  
        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

        IntPtr ptr = bmpData.Scan0;

        int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
        byte[] rgbValues = new byte[bytes];

        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

        // Set every third value to 255. A 24bpp bitmap will look red.  
        for (int i = 0; i < rgbValues.Length; i++)
            rgbValues[i] = (byte)(255 - rgbValues[i]);
        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
	
        bmp.UnlockBits(bmpData);
        bmp.Save(filename + "_inverse" + extension);
    }
}
