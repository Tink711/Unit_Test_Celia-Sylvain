using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.EdgeDetections
{
    public class Kirsch_grayscale : EdgeDetectionAbstract
    {

        public override Bitmap Apply(Bitmap bitmap)
        {
            return ExtBitmap.KirschFilter(bitmap,true);
        }

    }
}
