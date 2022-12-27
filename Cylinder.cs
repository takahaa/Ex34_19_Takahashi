using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Cylinder:Column
    {
        public Cylinder(float radius, float height):base(new Circle(radius), height)
        {
            this.height = height;
        }

        static public float GetVolume(float radius, float height)
        {
            return (float)(new Cylinder(radius, height).Volume);
        }
        static public float GetSurface(float radius, float height)
        {
            return (float)(new Cylinder(radius, height).Surface);
        }
    }
}
