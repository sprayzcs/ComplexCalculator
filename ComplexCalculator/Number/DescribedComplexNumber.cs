using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexCalculator.Number
{
    public class DescribedComplexNumber : ComplexNumber
    {
        private static int _id = 1;

        public int Id { get; set; }
        public string Description { get; set; }

        public DescribedComplexNumber(double? real = null, double? imaginary = null, double? angle = null, double? amount = null) : base(real, imaginary, angle, amount)
        {
            this.Id = _id;
            _id++;
        }

        public DescribedComplexNumber(string description, double? real = null, double? imaginary = null, double? angle = null, double? amount = null) : this(real, imaginary, angle, amount)
        {
            this.Description = description;
        }
    }
}
