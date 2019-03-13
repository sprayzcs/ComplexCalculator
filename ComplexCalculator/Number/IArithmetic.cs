using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexCalculator.Number
{
    public interface IArithmetic<T>
    {
        T Add(T toAdd);
        T Subtract(T toSubtract);
        T Multiply(T toMultiply);
        T Divide(T toDivide);
    }
}
