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
        public void ToStringTests(double realPart, double imaginaryPart, string amount)
        {
            CartesianComplex number = new CartesianComplex(realPart, imaginaryPart);

            Assert.AreEqual(number.ToString(), amount);
        }
    }
}