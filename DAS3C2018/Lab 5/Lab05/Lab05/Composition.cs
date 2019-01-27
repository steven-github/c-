using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class StudentC
    {
        //Person person = new Person();

        //Person person;

        //public StudentC(Person person)
        //{
        //    this.person = person;
        //}

        //public string FormatNameAndId(string name, int id)
        //{
        //    return person.FormatNameAndId(name, id);
        //}

        IFormatIdName formatter;
        IDataAccess da;

        public StudentC(IFormatIdName format, IDataAccess da)
        {
            this.formatter = format;
            this.da = da;
        }

        public string FormatNameAndId(string name, int id)
        {
            return formatter.FormatNameAndId(name, id);
        }

        public void Add(string value)
        {
            da.Save(value);
        }
    }
}
