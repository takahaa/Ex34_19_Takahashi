using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal interface IShape
    {
        public float Width { get; }
        public float Height { get; }
        public float Surface { get; }
        public float Circumference { get; }
    }
}
