using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct Circle : IShape
    {
        private float radius;
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float Radius { get { return radius; } }
        public float Width { get { return radius; } }
        public float Height { get { return radius; } }
        public float Surface { get { return (float)(Math.PI * radius * radius); } }
        public float Circumference { get { return (float)(Math.PI * radius * 2); } }
    }
}
