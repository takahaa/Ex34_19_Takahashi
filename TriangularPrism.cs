using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class TriangularPrism
    {
        private float width;
        private float depth;
        private float height;
        private float bottom;
        private float side;

        private static float GetBottom(float width, float depth)
        {
            return width * depth / 2;
        }
        private static float GetBottom(float l1, float l2, float l3)
        {
            var s = (l1 + l2 + l3) / 2;
            return (float)Math.Sqrt(s * (s - l1) * (s - l2) * (s - l3));
        }
        private static float GetSide(float width, float depth, float height)
        {
            return height * (width + depth + MathF.Sqrt(width * width + depth * depth));
        }
        private static float GetSide(float l1, float l2, float l3, float height)
        {
            return (l1 + l2 + l3) * height;
        }

        public TriangularPrism(float width, float depth, float height)
        {
            this.width = width;
            this.depth = depth;
            this.height = height;
            bottom = GetBottom(width, depth);
            side = GetSide(width, depth, height);
        }
        public TriangularPrism(float l1, float l2, float l3, float height)
        {
            this.height = height;
            bottom = GetBottom(l1, l2, l3);
            side = GetSide(l1, l2, l3, height);
        }

        public float GetVolume()
        {
            return bottom * height;
        }
        public static float GetVolume(float width, float depth, float height)
        {
            return GetBottom(width, depth) * height;
        }
        public static float GetVolume(float l1, float l2, float l3, float height)
        {
            return GetBottom(l1, l2, l3) * height;
        }
        public float GetSurface()
        {
            return side + bottom * 2;
        }
        public static float GetSurface(float width, float depth, float height)
        {
            return GetSide(width, depth, height) + GetBottom(width, depth) * 2;
        }
        public static float GetSurface(float l1, float l2, float l3, float height)
        {
            return GetSide(l1, l2, l3, height) + GetBottom(l1, l2, l3) * 2;
        }
    }
}
