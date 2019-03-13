using ComplexCalculator.Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Client.Util
{
    class CalculationHistory
    {
        internal ComplexNumber ComplexNumber1 { get; }
        internal ComplexNumber ComplexNumber2{ get; }

        internal CalculationHistory(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            ComplexNumber1 = complexNumber1;
            ComplexNumber2 = complexNumber2;
        }


    }
}
