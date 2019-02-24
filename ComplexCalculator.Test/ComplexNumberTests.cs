using ComplexCalculator.Number;
using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ComplexCalculator.Test
{
    [ExcludeFromCodeCoverage]
    class ComplexNumberTests
    {
        [Test]
        [TestCase(1, 2, ExpectedResult = "1 + 2 • i")]
        [TestCase(1, -2, ExpectedResult = "1 - 2 • i")]
        [TestCase(-1, 2, ExpectedResult = "-1 + 2 • i")]
        [TestCase(-1, -2, ExpectedResult = "-1 - 2 • i")]
        [TestCase(1, 0, ExpectedResult = "1")]
        [TestCase(-1, 0, ExpectedResult = "-1")]
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
        [TestCase(5, 45, ExpectedResult = "| 5 | • e ^ (45° • i)")]
        [TestCase(-5, 45, ExpectedResult = "| 5 | • e ^ (45° • i)")]
        [TestCase(5, -45, ExpectedResult = "| 5 | • e ^ (-45° • i)")]
        [TestCase(-5, -45, ExpectedResult = "| 5 | • e ^ (-45° • i)")]
        public string ExponentialToStringTest(int amount, int angle)
        {
            ComplexNumber number = new ComplexNumber(amount: amount, angle: angle);

            return number.ToString(NumberFormat.EXPONENTIAL);
        }

        [Test]
        [TestCase(3, 5, 4, 8, 7, 13)]
        [TestCase(-5, 4, 1, 2, -4, 6)]
        [TestCase(-2, -6, 7, 3, 5, -3)]
        public void AddTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1.Add(number2);

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(3, 5, 4, 8, 7, 13)]
        [TestCase(-5, 4, 1, 2, -4, 6)]
        [TestCase(-2, -6, 7, 3, 5, -3)]
        public void AddOperatorTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1 + number2;

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(3, 5, 4, 8, -1, -3)]
        [TestCase(-5, 4, 1, 2, -6, 2)]
        [TestCase(-2, -6, 7, 3, -9, -9)]
        public void SubtractTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1.Subtract(number2);

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(3, 5, 4, 8, -1, -3)]
        [TestCase(-5, 4, 1, 2, -6, 2)]
        [TestCase(-2, -6, 7, 3, -9, -9)]
        public void SubtractOperatorTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1 - number2;

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(-3, 5, 7, 2, -31, 29)]
        public void MultiplyTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1.Multiply(number2);

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(-3, 5, 7, 2, -31, 29)]
        public void MultiplyOperatorTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1 * number2;

            Assert.AreEqual(realExpected, numberResultGiven.Real);
            Assert.AreEqual(imaginaryExpected, numberResultGiven.Imaginary);
        }

        [Test]
        [TestCase(2, 5, 3, 10, 0.514, -0.046)]
        public void DivideTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1.Divide(number2);

            Assert.AreEqual(realExpected, Math.Round(numberResultGiven.Real, 3));
            Assert.AreEqual(imaginaryExpected, Math.Round(numberResultGiven.Imaginary, 3));
        }

        [Test]
        [TestCase(2, 5, 3, 10, 0.514, -0.046)]
        public void DivideOperatorTest(double real1, double imaginary1, double real2, double imaginary2, double realExpected, double imaginaryExpected)
        {
            ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber numberResultGiven = number1 / number2;

            Assert.AreEqual(realExpected, Math.Round(numberResultGiven.Real, 3));
            Assert.AreEqual(imaginaryExpected, Math.Round(numberResultGiven.Imaginary, 3));
        }

        [Test]
        [TestCase(1, 4)]
        [TestCase(1, -4)]
        public void ConjugateOperatorTest(double real, double imaginary)
        {
            ComplexNumber number = new ComplexNumber(real, imaginary);
            ComplexNumber conjugatedComplex = !number;

            Assert.AreEqual(imaginary, number.Imaginary);
            Assert.AreEqual(real, conjugatedComplex.Real);
            Assert.AreEqual(imaginary * -1, conjugatedComplex.Imaginary);
        }

        [Test]
        [TestCase("2+5i", 2, 5)]
        [TestCase("-5+3i", -5, 3)]
        [TestCase("5-8i", 5, -8)]
        [TestCase("-8-3i", -8, -3)]
        public void ParseCartesianTest(string input, double real, double imaginary)
        {
            ComplexNumber number = ComplexNumber.Parse(input);

            Assert.AreEqual(real, number.Real);
            Assert.AreEqual(imaginary, number.Imaginary);
        }

        [Test]
        [TestCase("10*(cos(45)+sin(45))", 10, 45)]
        [TestCase("-10*(cos(-45)+sin(-45))", -10, -45)]
        [TestCase("-10*(cos(-45)-sin(-45))", -10, -45)]
        public void ParsePolarTest(string input, double amount, double angle)
        {
            ComplexNumber number = ComplexNumber.Parse(input);
            Assert.AreEqual(amount, number.Amount);
            Assert.AreEqual(angle, number.Angle);
        }

        [Test]
        [TestCase("5*e^30i", 5, 30)]
        [TestCase("-5*e^-30i", -5, -30)]
        public void ParseExponentialTest(string input, double amount, double angle)
        {
            ComplexNumber number = ComplexNumber.Parse(input);
            Assert.AreEqual(amount, number.Amount);
            Assert.AreEqual(angle, number.Angle);
        }

        [Test]
        [TestCase("10*(cos(40)+sin(30))")]
        public void ParsePolarInequalAngleTest(string input)
        {
            Assert.Null(ComplexNumber.Parse(input));
        }

        [Test]
        [TestCase("")]
        public void ParseWrongInput(string input)
        {
            Assert.AreEqual(null, ComplexNumber.Parse(input));
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
            bool didThrow = false;

            try
            { 
                new ComplexNumber();
            }
            catch(InvalidOperationException)
            {
                didThrow = true;
            }

            Assert.AreEqual(true, didThrow);
        }
    }
}
