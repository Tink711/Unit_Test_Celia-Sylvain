using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.EdgeDetections
{
    public class LaplacianOfGaussien5x5_5x5_1 : EdgeDetectionAbstract
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ExtBitmap.Laplacian5x5OfGaussian5x5Filter1(bitmap);
         
        }
        
    }
}
