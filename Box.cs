using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Box:Column
    {
        public Box(float w, float h, float d):base(new RectAngle(w,d),h)
        {

        }
        public Box(float w = 1):base(new RectAngle(w,w),w)
        {

        }
    }

}
