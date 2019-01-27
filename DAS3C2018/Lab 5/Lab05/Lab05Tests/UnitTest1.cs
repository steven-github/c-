using Lab05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab05Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FormatNameAndIdWithEmptyNameReturnsNull()
        {
            //StudentC student = new StudentC(new PersonFake());
            //StudentC student = new StudentC(new MyFake());
            //string formatted = student.FormatNameAndId("", 1);
            //Assert.IsNull(formatted);

            MyFake fake = new MyFake();
            fake.DataBase = new List<string>();

            StudentC student = new StudentC(fake, fake);

            student.Add("1");
            student.Add("2");

            Assert.AreEqual(fake.DataBase.Count, 2);
        }

        class PersonFake : Person {
            public override string FormatNameAndId(string name, int id)
            {
                return base.FormatNameAndId(name, id);
            }
        }

        //class MyFake : IFormatIdName
        //{
        //    public string FormatNameAndId(string name, int id)
        //    {
        //        return null;
        //    }
        //}

        class MyFake : IFormatIdName, IDataAccess
        {
            public List<string> DataBase { get; set; }
            public string FormatNameAndId(string name, int id)
            {
                return null;
            }

            public void Save(string data)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
