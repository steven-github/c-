using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La01.Logic
{
    public class Person:ILogger
    {
        /*
         * Constructor comun y corriente:
         * - Tiene el mismo nombre de la clase
         * - No tiene valor de retorno
         */
        public Person()
        {


        }

        /*
         * Constructor comun y corriente:
         * - Tiene el mismo nombre de la clase
         * - No tiene valor de retorno
         */
        public Person(int id, string name, string lastName)
        {

            Id = id;
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public void Log(string log)
        {
            System.Console.WriteLine(log);
        }
    }
}
