using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Hexagon : IShape
    {
        private float width;

        public Hexagon(float width)
        {
            this.width = width;
        }

        public float Width { get { return this.Width; } }
        public float Height { get { return this.Height; } }
        public float Surface { get { return GetSurface(width); } }
        public float Circumference { get { return width * 6; } }

        static public float GetSurface(float width)
        {
            //ここで底面積を計算
            return (float)(width * width * 3 * Math.Sqrt(3) / 2);
        }
    }
}
