using System;
using BusinessLogic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab07.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void APersonIsCreated()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person() {
                Id = 1,
                Name = "John Smith",
                BirthDate = DateTime.Now
            };

            //Act
            logic.Create(person);
            Person saved = logic.GetById(1);

            //Assert
            Assert.IsNotNull(saved, "Person should have not been null after inserted.");
        }

        [TestMethod]
        public void APersonMustHaveAName()
        {
            //Arrange
            PersonBL logic = new PersonBL();
            Person person = new Person()
            {
                Id = 1,
                Name = "",
                BirthDate = DateTime.Now
            };

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => logic.Create(person));
        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {
            //Arrange
            Person person = new Person()
            {
                Id = 1,
                Name = "Steven S.",
                BirthDate = new DateTime(1999, 1, 1)
            };

            //Act & Assert
            Assert.AreEqual(19, person.Age, "Age is being calculated correctly!");
        }
        //Visual C# > Test > Unit Test Project (.NET Framework)
        //.NET Framework 4.6.1
    }
}
