using System;
using System.Collections.Generic;
using System.Text;
using ExceptionControlTest;

namespace ExceptionControlTest
{
    public class Register
    {
        
        public void RegisterPeople()
        {
            Console.WriteLine("How much people do you want register?");

            int NPeople = Handling.NSelecter();
            List<People> Peoples = new List<People>();
            
            try
            {
                for (int i = 0; i < NPeople; i++)
                {
                    People people = new People();
                    Console.WriteLine("Employee {0} Name",i+1);
                    people.Name = Console.ReadLine();
                    Console.WriteLine("Employee {0} Age", i + 1);
                    people.Age = Console.ReadLine();
                    Console.WriteLine("Employee {0} Job", i + 1);
                    people.Job = Console.ReadLine();
                    Console.WriteLine("Employee {0} Phone", i + 1);
                    people.Phone = Console.ReadLine();
                    Peoples.Insert(i, people);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("El espacio asignado a el valor proporcionado no existe");
            }

            Console.WriteLine("Deseas ver los empleados registrados? Yes/No ");
            if (Console.ReadLine().Substring(0)=="y"|| Console.ReadLine().Substring(0) == "Y")
            {
                ViewPeople(Peoples);
            }
            else if (Console.ReadLine().Substring(0) == "n" || Console.ReadLine().Substring(0) == "N")
            {
                return;
            }
            Console.WriteLine("Gracias por los datos ingresados");
            Console.ReadKey();
        }
        public void ViewPeople(List<People> Peoples)
        {
            foreach (People item in Peoples)
            {
                Console.WriteLine(item.Name+" "+item.Age+" "+item.Job+" "+item.Phone);
            }
        }
    }
}
