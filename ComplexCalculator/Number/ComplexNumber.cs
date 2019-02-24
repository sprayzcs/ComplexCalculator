using System;
using System.Text.RegularExpressions;

namespace ComplexCalculator.Number
{
    public class ComplexNumber : ICloneable
    {
        /// <summary>
        /// The real part of an complex number
        /// </summary>
        public double Real { get; private set; }

        /// <summary>
        /// The imaginary part of an complex number
        /// </summary>
        public double Imaginary { get; private set; }

        /// <summary>
        /// The angle of an complex number (often called phi)
        /// </summary>
        public double Angle { get; private set; }

        /// <summary>
        /// The amount of an complex number
        /// </summary>
        public double Amount { get; private set; }

        private bool _calculated;

        /// <summary>
        /// Constructor that takes all four parameters of an complex number.
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        /// <param name="angle"></param>
        /// <param name="amount"></param>
        public ComplexNumber(double? real = null, double? imaginary = null, double? angle = null, double? amount = null)
        {
            Calculate(real, imaginary, angle, amount);
        }

        private void Calculate(double? real, double? imaginary, double? angle, double? amount)
        {
            if (!_calculated)
            {
                if (real != null && imaginary != null)
                {
                    Real = real.Value;
                    Imaginary = imaginary.Value;

                    Amount = Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
                    Angle = Math.Atan(Imaginary / Real) * (360 / (2 * Math.PI));
                }
                else if (amount != null && angle != null)
                {
                    Amount = amount.Value;
                    Angle = angle.Value;

                    Real = Math.Abs(Amount) * Math.Cos(Angle);
                    Imaginary = Math.Abs(Amount) * Math.Sin(Angle);
                }
                else throw new InvalidOperationException("you must give at least (Real and Imaginary) or (Amount and Angle)");

                _calculated = true;
            }
        }

        /// <summary>
        /// Adds two complex numbers
        /// </summary>
        /// <param name="toAdd"><see cref="ComplexNumber"/> to add</param>
        /// <returns></returns>
        public ComplexNumber Add(ComplexNumber toAdd)
        {
            double newReal = this.Real + toAdd.Real;
            double newImaginary = this.Imaginary + toAdd.Imaginary;
            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

        /// <summary>
        /// Subtracts two complex numbers
        /// </summary>
        /// <param name="toSubtract"><see cref="ComplexNumber"/> to subtract</param>
        /// <returns></returns>
        public ComplexNumber Subtract(ComplexNumber toSubtract)
        {
            double newReal = this.Real - toSubtract.Real;
            double newImaginary = this.Imaginary - toSubtract.Imaginary;
            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

        /// <summary>
        /// Multiplies two complex numbers
        /// </summary>
        /// <param name="toMultiply"><see cref="ComplexNumber"/> to multiply</param>
        /// <returns></returns>
        public ComplexNumber Multiply(ComplexNumber toMultiply)
        {
            double a = this.Real;
            double c = toMultiply.Real;

            double b = this.Imaginary;
            double d = toMultiply.Imaginary;

            double newReal = a * c - b * d;
            double newImaginary = a * d + c * b;

            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

        /// <summary>
        /// Divides two complex numbers
        /// </summary>
        /// <param name="toDivide"><see cref="ComplexNumber"/> to divide</param>
        /// <returns></returns>
        public ComplexNumber Divide(ComplexNumber toDivide)
        {
            double a = this.Real;
            double c = toDivide.Real;

            double b = this.Imaginary;
            double d = toDivide.Imaginary;

            double newReal = (a * c + b * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));
            double newImaginary = (b * c - a * d) / (Math.Pow(c, 2) + Math.Pow(d, 2));

            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

        public static ComplexNumber operator +(ComplexNumber toAdd1, ComplexNumber toAdd2)
        {
            return toAdd1.Add(toAdd2);
        }

        public static ComplexNumber operator -(ComplexNumber toAdd1, ComplexNumber toAdd2)
        {
            return toAdd1.Subtract(toAdd2);
        }

        public static ComplexNumber operator *(ComplexNumber toAdd1, ComplexNumber toAdd2)
        {
            return toAdd1.Multiply(toAdd2);
        }

        public static ComplexNumber operator /(ComplexNumber toAdd1, ComplexNumber toAdd2)
        {
            return toAdd1.Divide(toAdd2);
        }

        public static ComplexNumber operator !(ComplexNumber toConjugate)
        {
            ComplexNumber complexNumber = toConjugate.Clone() as ComplexNumber;
            complexNumber.Imaginary *= -1;
            return complexNumber;
        }

        /// <summary>
        /// Formats complex number to a specific format
        /// </summary>
        /// <param name="format">Format for the complex number</param>
        /// <returns></returns>
        public string ToString(NumberFormat format)
        {
            switch(format)
            {
                case NumberFormat.CARTESIAN:
                    {
                        string returnString = Math.Round(Real, 3).ToString();

                        if (Imaginary == 0) return returnString;

                        returnString += " " + (Imaginary < 0 ? "-" : "+") + " " + Math.Round(Math.Abs(Imaginary), 3) + " • i";

                        return returnString;
                    }
                case NumberFormat.POLAR:
                    {
                        string returnString = $"| {Math.Round(Math.Abs(Amount), 3).ToString()} | • ";

                        returnString += $"(cos({Math.Round(Angle, 3)}) + sin({Math.Round(Angle, 3)}) • i)";

                        return returnString;
                    }
                case NumberFormat.EXPONENTIAL:
                    {
                        string returnString = $"| {Math.Round(Math.Abs(Amount), 3).ToString()} | • ";

                        returnString += $"e ^ ({Math.Round(Angle, 3)}° • i)";

                        return returnString;
                    }
            }

            return string.Empty;
        }

        /// <summary>
        /// Parses an input string for a complex number; checks for cartesian, polar and exponential form
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static ComplexNumber Parse(string input)
        {
            string cartesianPattern = @"^(?<real>-?[0-9.,]+)(?<imaginary>([-+])[0-9.,]+)i$";
            string polarPattern = @"(?<amount>[0-9.,]+)\*\(cos\((?<phi1>-?[0-9.,]+)\)(?<operator>[+-])sin\((?<phi2>-?[0-9.,]+)\)\)";
            string exponentialPattern = @"(?<amount>[0-9.,]+)\*e\^(?<angle>-?[0-9.,]+)i";

            if (Regex.IsMatch(input, cartesianPattern)) // Cartesian form
            {
                Match match = Regex.Match(input, cartesianPattern);

                GroupCollection matches = match.Groups;

                double real = double.Parse(matches["real"].Value);
                double imaginary = double.Parse(matches["imaginary"].Value);

                return new ComplexNumber(real: real, imaginary: imaginary);
            }
            else if(Regex.IsMatch(input, polarPattern)) // Polar form
            {
                Match match = Regex.Match(input, polarPattern);

                GroupCollection matches = match.Groups;

                double phi1 = double.Parse(matches["phi1"].Value);
                double phi2 = double.Parse(matches["phi2"].Value);
                double amount = double.Parse(matches["amount"].Value);

                if(phi1 != phi2)
                {
                    return null;
                }

                return new ComplexNumber(angle: phi1, amount: amount);
            }
            else if(Regex.IsMatch(input, exponentialPattern))
            {
                Match match = Regex.Match(input, exponentialPattern);

                GroupCollection matches = match.Groups;

                double amount = double.Parse(matches["amount"].Value);
                double angle = double.Parse(matches["angle"].Value);

                return new ComplexNumber(angle: angle, amount: amount);
            }

            return null;
        }

        public object Clone()
        {
            return new ComplexNumber(Real, Imaginary, Angle, Amount);
        }
    }
}
