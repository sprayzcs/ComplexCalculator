using System;

namespace ComplexCalculator.Number
{
    public class ComplexNumber
    {
        public double? Real { get; private set; }
        public double? Imaginary { get; private set; }
        public double? Angle { get; private set; }
        public double? Amount { get; private set; }

        private bool _calculated;

        public ComplexNumber(double? real = null, double? imaginary = null, double? angle = null, double? amount = null)
        {
            Real = real;
            Imaginary = imaginary;
            Angle = angle;
            Amount = amount;

            Calculate();
        }

        private void Calculate()
        {
            if (_calculated) return;

            if (Real != null && Imaginary != null)
            {
                Amount = Math.Sqrt(Math.Pow(Real ?? 0, 2) + Math.Pow(Imaginary ?? 0, 2));
                Angle = Math.Atan(Imaginary ?? 0 / Real ?? 0);
            }
            else if (Amount != null && Angle != null)
            {
                Real = Math.Abs(Amount ?? 0) * Math.Cos(Angle ?? 0);
                Real = Math.Abs(Amount ?? 0) * Math.Sin(Angle ?? 0);
            }
            else throw new InvalidOperationException("you must give at least (Real and Imaginary) or (Amount and Angle)");

            _calculated = true;
        }

        public string ToString(NumberFormat format)
        {
            switch(format)
            {
                case NumberFormat.CARTESIAN:
                    {
                        string returnString = Real.ToString();

                        if (Imaginary == 0) return returnString;

                        returnString += " " + (Imaginary < 0 ? "-" : "+") + " " + Math.Abs(Imaginary ?? 0) + " • i";

                        return returnString;
                    }
                case NumberFormat.POLAR:
                    {
                        string returnString = $"| {Math.Abs(Amount ?? 0).ToString()} | • ";

                        returnString += $"(cos({Angle}) + sin({Angle}) • i)";

                        return returnString;
                    }
                case NumberFormat.EXPONENTIAL:
                    {
                        string returnString = $"| {Math.Abs(Amount ?? 0).ToString()} | • ";

                        returnString += $"e ^ ({Angle}°)";

                        return returnString;
                    }
            }

            return string.Empty;
        }
    }
}
