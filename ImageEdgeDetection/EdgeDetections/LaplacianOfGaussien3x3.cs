using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.EdgeDetections
{
    public class LaplacianOfGaussian3x3 : EdgeDetectionAbstract
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ExtBitmap.Laplacian3x3OfGaussian3x3Filter(bitmap);
         
        }
        
    }
}
