using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.IO;
using ImageEdgeDetection;
using ImageEdgeDetection.Filters;

namespace ImageEdgeDetectionTest
{
    [TestClass]
    public class ImageFiltersTest
    {
      
        [TestMethod]
        public void TestHellFilter()
        {
            Bitmap or = GetImage.GetOriginalBitmap();

            Bitmap whawewant = GetImage.GetBitmapFromFile("HellFilter.jpg");

            HellFilter hf = new HellFilter();

            Bitmap filtered = hf.Apply(or);

            Assert.IsTrue(GetImage.Equals(filtered, whawewant));
        }
    }
}
