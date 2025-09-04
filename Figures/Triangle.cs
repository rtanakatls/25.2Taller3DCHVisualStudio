using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual.Figures
{
    internal class Triangle : Shape
    {
        protected float b;
        protected float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
            name = "Triangle";
        }

        public override float GetArea()
        {
            return (b * h) / 2;
        }
    }
}
