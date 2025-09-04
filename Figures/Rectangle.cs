using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual.Figures
{
    internal class Rectangle : Shape
    {
        protected float b;
        protected float h;

        public Rectangle(float b, float h)
        {
            this.b = b;
            this.h = h;
            name = "Rectangle";
        }

        public override float GetArea()
        {
            return b * h;
        }

        public string GetData()
        {
            return $"Base: {b}, Height: {h}, Area: {GetArea()}";
        }
    }
}
