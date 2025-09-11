using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual.Figures
{
    internal class FiguresMenu : Menu
    {
        private List<Shape> shapes;

        public FiguresMenu()
        {
            shapes = new List<Shape>();
        }

        public override void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción:");
                Console.WriteLine("1. Añadir rectángulo");
                Console.WriteLine("2. Añadir cuadrado");
                Console.WriteLine("3. Añadir círculo");
                Console.WriteLine("4. Añadir triángulo");
                Console.WriteLine("5. Mostrar las figuras");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddRectangle();
                        break;
                    case "2":
                        AddSquare();
                        break;
                    case "3":
                        AddCircle();
                        break;
                    case "4":
                        AddTriangle();
                        break;
                    case "5":
                        ShowAllShapes();
                        break;
                    case "0":
                        continueFlag = false;
                        break;

                }

            }
        }

        private void AddRectangle()
        {
            Console.WriteLine("Introduce el nombre del rectángulo:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la base del rectángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectángulo:");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name, b, h));
        }

        private void AddSquare()
        {
            Console.WriteLine("Introduce el nombre del cuadrado:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el lado del cuadrado:");
            float s = float.Parse(Console.ReadLine());
            shapes.Add(new Square(name, s));
        }

        private void AddCircle()
        {
            Console.WriteLine("Introduce el nombre del círculo:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce el radio del círculo:");
            float radius = float.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, radius));
        }

        private void AddTriangle()
        {
            Console.WriteLine("Introduce el nombre del triángulo:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la base del triángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo:");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Triangle(name, b, h));
        }

        private void ShowAllShapes()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"{i}. {shapes[i].Name} - {shapes[i].GetArea()}");
            }
        }

    }
}
