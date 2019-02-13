using ComplexCalculator.Number;
using NUnit.Framework;

namespace ComplexCalculator.Test
{
    public class CartesianComplexTests
    {
        [Test]
        [TestCase(2, 5, "2 + 5i")]
        [TestCase(-1, 4, "-1 + 4i")]
        [TestCase(3, -5, "3 - 5i")]
        [TestCase(-4, -8, "-4 - 8i")]
        public void ToStringTests(double realPart, double imaginaryPart, string expected)
        {
            CartesianComplex number = new CartesianComplex(realPart, imaginaryPart);

            Assert.AreEqual(expected, number.ToString());
        }

        [Test]
        [TestCase(2, 5, 5.3851)]
        [TestCase(-1, 4, 4.1231)]
        [TestCase(3, -5, 5.8309)]
        [TestCase(-4, -8, 8.9442)]
        public void AmountTests(double realPart, double imaginaryPart, double amount)
        {
            CartesianComplex number = new CartesianComplex(realPart, imaginaryPart);

            Assert.AreEqual(amount, number.Amount(), 0.0001);
        }
    }
}