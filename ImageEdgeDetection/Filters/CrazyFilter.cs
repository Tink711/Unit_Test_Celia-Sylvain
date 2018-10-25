using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Filters
{
    public class CrazyFilter : AbstractFilter
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ImageFilters.ApplyFilterSwapDivide(new Bitmap(bitmap), 1, 1, 2, 1);
        }
    }
}
