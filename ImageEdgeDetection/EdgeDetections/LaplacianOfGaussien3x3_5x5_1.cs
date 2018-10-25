using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.EdgeDetections
{
    public class LaplacianOfGaussien3x3_5x5_1 : EdgeDetectionAbstract
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ExtBitmap.Laplacian3x3OfGaussian5x5Filter1(bitmap);
         
        }

        
    }
}
