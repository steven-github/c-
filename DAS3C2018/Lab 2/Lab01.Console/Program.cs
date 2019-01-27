using La01.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namespace.Clase.Metodo
            System.Console.WriteLine("Person");

            //Formas de crear instancias de una clase:

            //1 - Usando constructor publico sin parametros
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Juan";
            //person.LastName = "Perez";

            //2 - Usando constructor publico con parametros
            //Person person = new Person(1, "Juan", "Perez");

            //3 - Usando constructor anonimo
            Person person = new Person {
                Id = 1,
                Name = "Juan",
                LastName = "Perez"
            };

            //Implementando interfaces
            //ILogger logger = new Person();
            ILogger logger = person;

            //for (int i = 0; i < 10; i++)
            //{
            //    System.Console.WriteLine(i);
            //}

            //Heap -- Variables(almacena variables que van muriendo)
            //Stack -- Metodos(el stack se limpia al terminar la ejecucion del programa)

            string personString = string.Format("Id:{0}, Name:{1}, LastName:{2}", person.Id, person.Name, person.LastName);
            System.Console.WriteLine(personString);
            logger.Log("Hello World");

            System.Console.ReadKey();
        }
    }
}
