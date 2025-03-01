using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication.Test
{
    [TestClass]
    public sealed class PersonTests : Person
    {
        [TestMethod]
        public void Attributes_ShouldBeSetAndRetrievedCorrectly()
        {
            // Arrange
            var person = new Person
            {
                // Act
                FirstName = "John",
                LastName = "Doe",
                Title = "Mr."
            };

            // Assert
            Assert.AreEqual("John", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual("Mr.", person.Title);
        }
    }
}
