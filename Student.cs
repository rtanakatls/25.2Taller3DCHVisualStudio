using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual
{
    internal class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public Student(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

    }
}
