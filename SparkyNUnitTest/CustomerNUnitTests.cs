using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange
            var customer = new Customer();

            //Act
            string fullName = customer.GreetAndCombineNames("Ben", "Spark");

            //Assert
            Assert.AreEqual(fullName, "Hello, Ben Spark");
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase);
            Assert.That(fullName, Does.StartWith("Hello,"));
            Assert.That(fullName, Does.EndWith("Spark"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }
    }
}
