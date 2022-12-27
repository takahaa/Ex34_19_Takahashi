using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal interface ISolid
    {
        public float Volume { get; }
        public float Surface { get; }
    }
}
