using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ShapeSolid
{
    internal struct RightTriangle : IShape
    {
        readonly float width;
        readonly float height;
        public RightTriangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public float Width
        {
            get { return width; }
        }
        public float Height
        {
            get { return height; }
        }
        public float Surface
        {
            get { return GetSurface(width,height); }
        }
        public float Circumference
        {
            get
            {
                return (float)(width + height + Math.Sqrt(width * width + height + height));
            }
        }
        static public float GetSurface(float width, float height)
        {
            return width / 2 * height;
        }
    }
}
