using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionControlTest
{
    public class Handling
    { 
        public int Select { get; set; }
        public int SelectV { get; set; }

        public void StartApp()
        {
            Menu();
        }

        public void Menu()
        {
            Register register = new Register();
            Console.WriteLine("Employee register");
            register.RegisterPeople();
        }

        public static int NSelecter()
        {
            int number;
            int numberA = 0;
            bool loop = true;
            while (loop)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= 1)
                    {
                        numberA = number;
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato ingresado no es soportado, utiliza numeros mayores a 1");
                }
            }
            return numberA;
        }

    }
}
