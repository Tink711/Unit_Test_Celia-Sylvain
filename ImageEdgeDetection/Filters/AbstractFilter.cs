using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageEdgeDetection.Filters
{
    public abstract class AbstractFilter
    {

        public abstract Bitmap Apply(Bitmap bitmap);
    }
}
