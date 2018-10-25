using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Filters
{
    public class ZenFilter : AbstractFilter
    {
        public override Bitmap Apply(Bitmap bitmap)
        {
            return ImageFilters.ApplyFilter(new Bitmap(bitmap), 1, 10, 1, 1);
        }
    }
}
