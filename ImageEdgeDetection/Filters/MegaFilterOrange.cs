using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Filters
{
    public class MegaFilterOrange : AbstractFilter
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            Color c = Color.Orange;
           return ImageFilters.ApplyFilterMega(new Bitmap(bitmap), 230, 110, c);
        }
    }
}
