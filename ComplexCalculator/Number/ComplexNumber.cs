using System;
using System.Text.RegularExpressions;

namespace ComplexCalculator.Number
{
    public class ComplexNumber : ICloneable, IEquatable<ComplexNumber>
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }
        public double Angle { get; private set; }
        public double Amount { get; private set; }

        private bool _calculated;

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
                    Real = real ?? 0;
                    Imaginary = imaginary ?? 0;

                    Amount = Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
                    Angle = Math.Atan(Imaginary / Real);
                }
                else if (amount != null && angle != null)
                {
                    Amount = amount ?? 0;
                    Angle = angle ?? 0;

                    Real = Math.Abs(Amount) * Math.Cos(Angle);
                    Imaginary = Math.Abs(Amount) * Math.Sin(Angle);
                }
                else throw new InvalidOperationException("you must give at least (Real and Imaginary) or (Amount and Angle)");

                _calculated = true;
            }
        }

        public ComplexNumber Add(ComplexNumber toAdd)
        {
            double newReal = this.Real + toAdd.Real;
            double newImaginary = this.Imaginary + toAdd.Imaginary;
            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

        public ComplexNumber Subtract(ComplexNumber toSubtract)
        {
            double newReal = this.Real - toSubtract.Real;
            double newImaginary = this.Imaginary - toSubtract.Imaginary;
            return new ComplexNumber(real: newReal, imaginary: newImaginary);
        }

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

        public string ToString(NumberFormat format)
        {
            switch(format)
            {
                case NumberFormat.CARTESIAN:
                    {
                        string returnString = Real.ToString();

                        if (Imaginary == 0) return returnString;

                        returnString += " " + (Imaginary < 0 ? "-" : "+") + " " + Math.Abs(Imaginary) + " • i";

                        return returnString;
                    }
                case NumberFormat.POLAR:
                    {
                        string returnString = $"| {Math.Abs(Amount).ToString()} | • ";

                        returnString += $"(cos({Angle}) + sin({Angle}) • i)";

                        return returnString;
                    }
                case NumberFormat.EXPONENTIAL:
                    {
                        string returnString = $"| {Math.Abs(Amount).ToString()} | • ";

                        returnString += $"e ^ ({Angle}°)";

                        return returnString;
                    }
            }

            return string.Empty;
        }

        public static ComplexNumber Parse(string input)
        {
            string cartesianPattern = @"(?<real>-?[0-9.,]+)(?<imaginary>([-+])[0-9.,]+)i";
            string polarPattern = @"(?<amount>-?[0-9.,]+)\*\(cos\((?<phi1>-?[0-9.,]+)\)(?<operator>[+-])sin\((?<phi2>-?[0-9.,]+)\)\)";
            string exponentialPattern = @"(?<amount>-?[0-9.,]+)\*e\^(?<angle>-?[0-9.,]+)i";

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
                    throw new ArgumentException("phi1 is not equal to phi2");
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

        public bool Equals(ComplexNumber other)
        {
            return other.Real == this.Real && other.Imaginary == this.Imaginary;
        }
    }
}
