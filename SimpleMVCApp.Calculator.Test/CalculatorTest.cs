using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleMVCApp.Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Initilize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Sum()
        {
            // Arrage
            var x = 2;
            var y = 2;

            // Act
            var result = _calculator.Sum(x, y);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Subtract()
        {
            // Arrage
            var x = 2;
            var y = 2;

            // Act
            var result = _calculator.Subtract(x, y);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
