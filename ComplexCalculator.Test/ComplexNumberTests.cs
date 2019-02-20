using ComplexCalculator.Number;
using NUnit.Framework;
using System;

namespace ComplexCalculator.Test
{
    class ComplexNumberTests
    {
        [Test]
        [TestCase(1, 2, ExpectedResult = "1 + 2 • i")]
        [TestCase(1, -2, ExpectedResult = "1 - 2 • i")]
        [TestCase(-1, 2, ExpectedResult = "-1 + 2 • i")]
        [TestCase(-1, -2, ExpectedResult = "-1 - 2 • i")]
        public string CartesianToStringTests(int real, int imaginary)
        {
            ComplexNumber number = new ComplexNumber(real: real, imaginary: imaginary);

            return number.ToString(NumberFormat.CARTESIAN);
        }

        [Test]
        [TestCase(5, 45, ExpectedResult = "| 5 | • (cos(45) + sin(45) • i)")]
        [TestCase(-5, 45, ExpectedResult = "| 5 | • (cos(45) + sin(45) • i)")]
        [TestCase(5, -45, ExpectedResult = "| 5 | • (cos(-45) + sin(-45) • i)")]
        [TestCase(-5, -45, ExpectedResult = "| 5 | • (cos(-45) + sin(-45) • i)")]
        public string PolarToStringTests(int amount, int angle)
        {
            ComplexNumber number = new ComplexNumber(amount: amount, angle: angle);
            
            return number.ToString(NumberFormat.POLAR);
        }

        [Test]
        [TestCase(5, 45, ExpectedResult = "| 5 | • e ^ (45°)")]
        [TestCase(-5, 45, ExpectedResult = "| 5 | • e ^ (45°)")]
        [TestCase(5, -45, ExpectedResult = "| 5 | • e ^ (-45°)")]
        [TestCase(-5, -45, ExpectedResult = "| 5 | • e ^ (-45°)")]
        public string ExponentialToStringTest(int amount, int angle)
        {
            ComplexNumber number = new ComplexNumber(amount: amount, angle: angle);

            return number.ToString(NumberFormat.EXPONENTIAL);
        }

        [Test]
        public void FailToStringTest()
        {
            ComplexNumber number = new ComplexNumber(real: 10, imaginary: 5);

            Assert.AreEqual(string.Empty, number.ToString((NumberFormat)10));
        }

        [Test]
        public void FailConstructorTest()
        {
            Assert.Throws<InvalidOperationException>(delegate
            {
                ComplexNumber number = new ComplexNumber();
            });
        }
    }
}
