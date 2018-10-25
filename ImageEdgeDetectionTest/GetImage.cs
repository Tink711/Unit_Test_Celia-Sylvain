using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ImageEdgeDetectionTest
{
    public class GetImage
    {

        public static Bitmap GetOriginalBitmap()
        {
            return GetBitmapFromFile("Monarch_In_May.jpg");
        }
        public static Bitmap GetBitmapFromFile(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            return (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
        }

        public static bool Equals(Bitmap bmp1, Bitmap bmp2)
        {
            if (!bmp1.Size.Equals(bmp2.Size))
            {
                return false;
            }
            for (int x = 0; x < bmp1.Width; ++x)
            {
                for (int y = 0; y < bmp1.Height; ++y)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }
}
