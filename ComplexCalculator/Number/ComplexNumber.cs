using System;
using System.Text.RegularExpressions;

namespace ComplexCalculator.Number
{
    public class ComplexNumber : IArithmetic<ComplexNumber>, ICloneable
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

                    if (Real == 0 && Imaginary < 0) Angle = -(Math.PI / 2);
                    else if (Real == 0 && Imaginary > 0) Angle = Math.PI / 2;
                    else if (Real < 0 && Imaginary < 0) Angle = Math.Atan(Imaginary / Real) - Math.PI;
                    else if (Real < 0 && Imaginary >= 0) Angle = Math.Atan(Imaginary / Real) + Math.PI;
                    else if (Real > 0) Angle = Math.Atan(Imaginary / Real);
                    else Angle = 0;

                    Angle *= (360 / (2 * Math.PI));
                    if (Angle < 0) Angle += 360;
                }
                else if (amount != null && angle != null)
                {
                    Amount = amount.Value;
                    Angle = angle.Value;

                    Real = Math.Abs(Amount) * Math.Cos(Angle * (Math.PI / 180));
                    Imaginary = Math.Abs(Amount) * Math.Sin(Angle * (Math.PI / 180));
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
            double newAmount = this.Amount * toMultiply.Amount;
            double newAngle = this.Angle + toMultiply.Angle;

            return new ComplexNumber(amount: newAmount, angle: newAngle);
        }

        /// <summary>
        /// Divides two complex numbers
        /// </summary>
        /// <param name="toDivide"><see cref="ComplexNumber"/> to divide</param>
        /// <returns></returns>
        public ComplexNumber Divide(ComplexNumber toDivide)
        {
            double newAmount = this.Amount / toDivide.Amount;
            double newAngle = this.Angle - toDivide.Angle;

            return new ComplexNumber(amount: newAmount, angle: newAngle);
        }

        public static ComplexNumber operator +(ComplexNumber toAdd1, ComplexNumber toAdd2)
        {
            return toAdd1.Add(toAdd2);
        }

        public static ComplexNumber operator -(ComplexNumber toSub1, ComplexNumber toSub2)
        {
            return toSub1.Subtract(toSub2);
        }

        public static ComplexNumber operator *(ComplexNumber toMul1, ComplexNumber toMul2)
        {
            return toMul1.Multiply(toMul2);
        }

        public static ComplexNumber operator /(ComplexNumber toDiv1, ComplexNumber toDiv2)
        {
            return toDiv1.Divide(toDiv2);
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
                case NumberFormat.INPUT:
                    {
                        string returnString = Math.Round(Real, 3).ToString();

                        if (Imaginary == 0) return returnString;

                        returnString += (Imaginary < 0 ? "-" : "+") +  Math.Round(Math.Abs(Imaginary), 3) + "i";

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
            input = input.Replace(" ", "");

            string cartesianPattern = @"^(?<real>-?(\d+([,]\d+)?))(?<imaginary>([-+])(\d+([,]\d+)?))i$";
            string polarPattern = @"(?<amount>(\d+([,]\d+)?))\*\(cos\((?<phi1>-?(\d+([,]\d+)?))\)(?<operator>[+-])sin\((?<phi2>-?(\d+([,]\d+)?))\)\)";
            string exponentialPattern = @"(?<amount>-?(\d+([,]\d+)?))\*e\^(?<angle>-?(\d+([,]\d+)?))i";

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
                double amount = Math.Abs(double.Parse(matches["amount"].Value));

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

                double amount = Math.Abs(double.Parse(matches["amount"].Value));
                double angle = double.Parse(matches["angle"].Value);

                return new ComplexNumber(angle: angle, amount: amount);
            }

            return null;
        }

        public static bool TryParse(string input, out ComplexNumber number)
        {
            return (number = Parse(input)) != null;
        }

        public object Clone()
        {
            return new ComplexNumber(Real, Imaginary, Angle, Amount);
        }
    }
}
