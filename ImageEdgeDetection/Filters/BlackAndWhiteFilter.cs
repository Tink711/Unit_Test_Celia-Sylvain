using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Filters
{
    public class BlackAndWhiteFilter : AbstractFilter
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ImageFilters.BlackWhite(new Bitmap(bitmap));
        }
    }
}
