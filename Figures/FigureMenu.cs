using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual.Figures
{
    internal class FigureMenu : Menu
    {
        private List<Shape> shapes;
        public override void Execute()
        {
            Console.WriteLine("Menu de figuras");
            shapes = new List<Shape>();
            shapes.Add(new Triangle(10, 20));
            shapes.Add(new Rectangle(5, 5));
            shapes.Add(new Triangle(6, 6));
            shapes.Add(new Rectangle(8, 8));

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"{s.Name} - {s.GetArea()}");                      
            }
        }



    }
}
