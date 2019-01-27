using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PersonBL
    {
        List<Person> persons = new List<Person>();

        public void Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            persons.Add(person);
        }

        /// <summary>
        /// Finds the item with the right id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetById(int id)
        {
            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }

            return null;
        }

        public int GetAge(int id)
        {
            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    int age = DateTime.Now.Year - person.BirthDate.Year;
                    return age;
                }
            }

            return 0;
        }
    }
    //Visual C# > Windows Classic desktop > Class Library (.NET Framework)
    //.NET Framework 4.6.1
}
