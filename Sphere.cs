using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Sphere : ISolid
    {
        private float radius;
        public Sphere(float radius)
        {
            this.radius = radius;
        }
        public float Volume
        {
            get { return GetVolume(radius); }
        }
        public float Surface
        {
            get { return GetSurface(radius); }
        }
        public static float GetVolume(float radius)
        {
            return (float)(4 * Math.PI * radius * radius * radius / 3);
        }
        public float GetSurface()
        {
            return GetSurface(radius);
        }
        public static float GetSurface(float radius)
        {
            return (float)(4 * Math.PI * radius * radius);
        }
    }
}
