using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;
using System.IO;


namespace ImageEdgeDetectionTest
{
    [TestClass]
    public class ExtBitmapTest
    {
       
        [TestMethod]
        public void TestKirschFilter()
        {
            Bitmap or = GetImage.GetOriginalBitmap();

            Bitmap whawewant = GetImage.GetBitmapFromFile("Kirsch.jpg");
            
            Bitmap filtered = ExtBitmap.KirschFilter(or, false);
           
            Assert.IsTrue(GetImage.Equals(filtered, whawewant));
           
        }

        [TestMethod]
        public void TestKirschFilterGrayScale()
        {
            Bitmap or = GetImage.GetOriginalBitmap();
            
            Bitmap whawewant_but_in_gray = GetImage.GetBitmapFromFile("KirschGrayscale.jpg");
            
            Bitmap filtered_but_in_gray = ExtBitmap.KirschFilter(or, true);
            
            Assert.IsTrue(GetImage.Equals(filtered_but_in_gray, whawewant_but_in_gray));
        }

        [TestMethod]
        public void TestPrewittFilter()
        {
            Bitmap or = GetImage.GetOriginalBitmap();

            Bitmap whawewant = GetImage.GetBitmapFromFile("Prewitt.jpg");

            Bitmap filtered = ExtBitmap.PrewittFilter(or, false);

            Assert.IsTrue(GetImage.Equals(filtered, whawewant));
        }



        [TestMethod]
        public void TestLaplacian_5x5()
        {
            Bitmap or = GetImage.GetOriginalBitmap();

            Bitmap whawewant = GetImage.GetBitmapFromFile("Laplacian_5x5.jpg");

            Bitmap filtered = ExtBitmap.Laplacian5x5Filter(or, false);

            Assert.IsTrue(GetImage.Equals(filtered, whawewant));
        }


       
    }
}
