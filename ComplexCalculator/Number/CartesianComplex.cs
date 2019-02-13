using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Number
{
    public class CartesianComplex : IComplex
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public CartesianComplex(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public double Amount()
        {
            return Math.Sqrt(Math.Pow(this.RealPart, 2) + Math.Pow(this.ImaginaryPart, 2));
        }

        public override string ToString()
        {
            string toReturn = RealPart.ToString();
            if (ImaginaryPart == 0) return toReturn;
            if (ImaginaryPart < 0)
            {
                toReturn += " - ";
            }
            else
            {
                toReturn += " + ";
            }

            toReturn += Math.Abs(ImaginaryPart) + "i";

            return toReturn;
        }
    }
}
