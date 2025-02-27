namespace WebApplication.Tests
{
    [TestClass]
    public sealed class PersonTests:Person
    {
        [TestMethod]
        public void FirstName_ShouldBeSetAndRetrievedCorrectly()
        {
            // Arrange
            var person = new Person
            {
                // Act
                FirstName = "John"
            };

            // Assert
            Assert.AreEqual("John", person.FirstName);
        }

        [TestMethod]
        public void LastName_ShouldBeSetAndRetrievedCorrectly()
        {
            // Arrange
            var person = new Person
            {
                // Act
                LastName = "Doe"
            };

            // Assert
            Assert.AreEqual("Doe", person.LastName);
        }

        [TestMethod]
        public void Person_ShouldAllowEmptyFirstName()
        {
            // Arrange
            var person = new Person
            {
                // Act
                FirstName = ""
            };

            // Assert
            Assert.AreEqual("", person.FirstName);
        }

        [TestMethod]
        public void Person_ShouldAllowEmptyLastName()
        {
            // Arrange
            var person = new Person
            {
                // Act
                LastName = ""
            };

            // Assert
            Assert.AreEqual("", person.LastName);
        }

        [TestMethod]
        public void Person_ShouldInitializeWithDefaultValues()
        {
            // Act
            var person = new Person();

            // Assert
            Assert.IsNull(person.FirstName);
            Assert.IsNull(person.LastName);
        }
    }
}
