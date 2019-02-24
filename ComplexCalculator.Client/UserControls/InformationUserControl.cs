using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexCalculator.Client.Forms;
using ComplexCalculator.Number;

namespace ComplexCalculator.Client.UserControls
{
    public partial class InformationUserControl : UserControlBase
    {
        public InformationUserControl()
        {
            InitializeComponent();
        }

        private void TxtComplexNumberTextChangedEvent(object sender, EventArgs e)
        {
            ComplexNumber number = ComplexNumber.Parse(txtComplexNumber.Text);
            if (number == null) return;

            lblCartesianForm.Text = number.ToString(NumberFormat.CARTESIAN);
            lblPolarForm.Text = number.ToString(NumberFormat.POLAR);
            lblExpForm.Text = number.ToString(NumberFormat.EXPONENTIAL);

            lblRealpart.Text = Math.Round(number.Real, 3).ToString();
            lblImaginarypart.Text = Math.Round(number.Imaginary).ToString();
            lblAmount.Text = Math.Round(number.Amount, 5).ToString();
            lblAngle.Text = Math.Round(number.Angle, 5).ToString() + "°";
            lblConjugatedComplex.Text = (!number).ToString(NumberFormat.CARTESIAN);
        }
    }
}
