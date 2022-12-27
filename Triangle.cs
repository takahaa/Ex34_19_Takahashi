using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ShapeSolid
{
    internal struct Triangle : IShape
    {
        readonly public float length0;
        readonly public float length1;
        readonly public float length2;
        public float Height
        {
            get {
                return (float)((double)Surface / Width * 2.0);
            }
        }
        public float Width
        {
            get
            {
                return length0 > length1
                    ? (length0 > length2 ? length0 : length2)
                    : (length1 > length2 ? length1 : length2);
            }
        }

        public Triangle(float length0 = 0, float length1 = 0, float length2 = 0)
        {
            this.length0 = length0;
            this.length1 = length1;
            this.length2 = length2;
        }
        public float Surface
        {
            get{
                float s = (length0 + length1 + length2) / 2;
                return (float)(Math.Sqrt(s * (s - length0) * (s - length1) * (s - length2)));
            }
        }
        public float Circumference
        {
            get { return length0 + length1 + length2; }
            
        }
        public void GetBounds(out float width, out float height)
        {
            width = Width;
            height= Height;
            return;
        }
    }

}
