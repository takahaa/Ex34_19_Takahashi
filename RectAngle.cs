using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct RectAngle : IShape, IComparable<RectAngle>
    {
        public readonly float width;
        public readonly float height;
        public RectAngle(float width = 0, float height = 0)
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
            get { return GetSurface( width,height); }
        }
        public float Circumference
        {
            get
            {
                return (width + height) * 2.0f;
            }
        }
         static public float GetSurface(float width,float height)
        {
            return width * height;
        }

        public void GetBounds(out float width, out float height)
        {
            width = Width;
            height = Height;
        }

        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }
        int IComparable<RectAngle>.CompareTo(RectAngle other)
        {
            if (other.Surface > this.Surface)
                return -1;
            else if (other.Surface == this.Surface)
                return 0;
            else
                return 1;
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            RectAngle ans = new RectAngle(float.MaxValue, float.MaxValue);
            List<RectAngle> candidates = new List<RectAngle>()
            {
                Plus(rectAngle1.width,rectAngle2.width, rectAngle1.height,rectAngle2.height),
                Plus(rectAngle1.width, rectAngle2.height, rectAngle1.height, rectAngle2.width),
                Plus(rectAngle1.height, rectAngle2.width, rectAngle1.width, rectAngle2.height),
                Plus(rectAngle1.height, rectAngle2.height, rectAngle1.width, rectAngle2.width)
            };
            ans = candidates.Min();

            return ans;
        }
        private static RectAngle Plus(float l1, float l2, float l3, float l4)
        {
            return new RectAngle(l1 + l2, (l3 > l4) ? l3 : l4);
        }

        public override bool Equals(object obj)
        {
            return this == (RectAngle)obj;
        }
    }
}
