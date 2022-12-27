using Interface_ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class RightTriangularPrism : Column
    {
        public RightTriangularPrism(float w, float h, float d) : base(new RightTriangle(w, d), h)
        {
        
        }
    }
}
