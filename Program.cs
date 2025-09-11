using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3D252Virtual.Figures;

namespace Taller3D252Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new FiguresMenu();
            menu.Execute();
        }
    }
}
