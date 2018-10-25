using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.EdgeDetections
{
    public class Laplacian5x5_grayscale : EdgeDetectionAbstract
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ExtBitmap.Laplacian5x5Filter(bitmap, true);
        }

    }
}
