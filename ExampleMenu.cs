using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D252Virtual
{
    internal class ExampleMenu : Menu
    {
        private Student student;

        public override void Execute()
        {

            Console.WriteLine("Bienvenido al programa");
            student = new Student(GetName());
            student.SetAge(GetAge());

            Console.WriteLine($"Te llamas {student.Name} y tienes {student.Age} años.");
            ShowMenu();
        }

        private string GetName()
        {
            string name = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Introduce tu nombre:");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío");
                }
                else
                {
                    isValid = true;
                }
            }
            return name;
        }

        private int GetAge()
        {
            int age = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Ahora dime tu edad:");
                age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    Console.WriteLine("La edad no puede ser negativa");
                }
                else
                {
                    isValid = true;
                }
            }
            return age;
        }

        private void ShowMenu()
        {
            bool canContinue = true;
            while(canContinue)
            {
                string option = "";
                Console.WriteLine("Introduce una opción:");
                Console.WriteLine("1. Mostrar cuántos años tendré cuando me gradúe");
                Console.WriteLine("2. Mostrar en cuántos años me jubilaré");
                Console.WriteLine("0. Salir");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowYearsToGraduate();
                        break;
                    case "2":
                        ShowYearsToRetire();
                        break;
                    case "0":
                        canContinue = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void ShowYearsToGraduate()
        {
            int yearsToGraduate = 3;
            int ageAtGraduation = student.Age + yearsToGraduate;
            Console.WriteLine($"Cuando te gradúes tendrás {ageAtGraduation} años.");
        }

        private void ShowYearsToRetire()
        {
            int retirementAge = 65;
            int yearsToRetire = retirementAge - student.Age;
            if (student.Age > retirementAge)
            {
                Console.WriteLine("Ya deberías estar jubilado.");
            }
            else
            {
                Console.WriteLine($"Te jubilarás en {yearsToRetire} años.");
            }
        }
    }
}
