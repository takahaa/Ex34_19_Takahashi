using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{    class Hexagon : IShape
    {
        public float Width { get { return this.Width; } }
        public float Height { get { return this.Height; } }
        public float Surface { get { return this.Surface; } }
        public float Circumference { get { return this.Circumference; } }

        public Hexagon(float width)
        {
            //ここで底面積を計算
        }
    }

    /*
    internal class Hexagon<Type> : ISolid
        where Type : IShape
    {
    }
    */

}
