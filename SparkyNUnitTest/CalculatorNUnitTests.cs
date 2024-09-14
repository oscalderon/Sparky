using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTowInt_GetCorrectAddition()
        {
            // Arrange
            var cal = new Calculator();

            //Act
            int result = cal.AddNumbers(10,20);

            //Assert
            Assert.That(result,Is.EqualTo(30));
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            var calc = new Calculator();

            bool isOdd = calc.IsOddNumber(10);

            Assert.IsFalse(isOdd);       
        }

        [Test]
        public void IsOddChecker_InputOffNumber_ReturnTrue()
        {
            var calc = new Calculator();

            bool isOdd = calc.IsOddNumber(11);

            Assert.IsTrue(isOdd);
        }
    }
}
