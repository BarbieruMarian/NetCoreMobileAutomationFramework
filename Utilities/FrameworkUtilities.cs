using AppiumFramework.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AppiumFramework.Utilities
{
    public class FrameworkUtilities
    {
        public static void Sleep(int miliseconds)
        {
            Thread.Sleep(miliseconds * Settings.ThreadSleepMultiplicator);
        }

        public static void ExecuteProcess(string filePath, string argument)
        {
            Process p = new Process();
            p.StartInfo.FileName = filePath;
            p.StartInfo.Arguments = argument;
            p.Start();
            p.WaitForExit();
        }

        public static float ImageBrightness(byte[] imageData)
        {
            var bitmap = ConvertToBitmap(imageData);
            var colors = new List<Color>();
            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    colors.Add(bitmap.GetPixel(x, y));
                }
            }

            float imageBrightness = colors.Average(color => color.GetBrightness());
            return imageBrightness;
        }

        private static Bitmap ConvertToBitmap(byte[] imageData)
        {
            Bitmap bmp;
            using (var ms = new MemoryStream(imageData))
            {
                bmp = new Bitmap(ms);
            }
            return bmp;
        }
    }
}
