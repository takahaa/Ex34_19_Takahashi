using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Column : ISolid
    {
        protected float height;
        protected IShape shape;
        public Column(IShape shape, float height)
        {
            this.shape = shape;
            this.height = height;
        }
        public float Volume
        {
            get => shape.Surface * this.height;
        }
        public float Surface
        {
            get => shape.Surface * 2 + shape.Circumference * this.height;
        }


    }

    //ジェネリック化
    internal class Column<Type> : ISolid
        where Type : IShape
    {
        protected float height;
        protected Type shape;
        public Column(Type shape, float height)
        {
            this.shape = shape;
            this.height = height;
        }
        public float Volume
        {
            get => shape.Surface * this.height;
        }
        public float Surface
        {
            get => shape.Surface * 2 + shape.Circumference * this.height;
        }


    }
}
