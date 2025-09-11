using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual.Figures
{
    internal class Circle : Shape
    {
        protected float radius;
        protected float pi = 3.1416f;

        public Circle(string name, float radius) : base(name)
        {
            this.radius = radius;
        }

        public override float GetArea()
        {
            return pi * radius * radius;
        }

    }
}
