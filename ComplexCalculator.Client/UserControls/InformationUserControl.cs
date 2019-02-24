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
        public InformationUserControl() : base()
        {
            InitializeComponent();
        }

        public InformationUserControl(string startInput) : this()
        {
            txtComplexNumber.Text = startInput;
        }

        private void TxtComplexNumberTextChangedEvent(object sender, EventArgs e)
        {
            ComplexNumber number = ComplexNumber.Parse(txtComplexNumber.Text);
            if (number == null)
            {
                ResetLabels();
                return;
            }

            lblCartesianForm.Text = number.ToString(NumberFormat.CARTESIAN);
            lblPolarForm.Text = number.ToString(NumberFormat.POLAR);
            lblExpForm.Text = number.ToString(NumberFormat.EXPONENTIAL);

            lblRealpart.Text = Math.Round(number.Real, 3).ToString();
            lblImaginarypart.Text = Math.Round(number.Imaginary).ToString();
            lblAmount.Text = Math.Round(number.Amount, 5).ToString();
            lblAngle.Text = Math.Round(number.Angle, 5).ToString() + "°";
            lblConjugatedComplex.Text = (!number).ToString(NumberFormat.CARTESIAN);
        }

        private void ResetLabels()
        {
            lblCartesianForm.Text = string.Empty;
            lblPolarForm.Text = string.Empty;
            lblExpForm.Text = string.Empty;

            lblRealpart.Text = string.Empty;
            lblImaginarypart.Text = string.Empty;
            lblAmount.Text = string.Empty;
            lblAngle.Text = string.Empty;
            lblConjugatedComplex.Text = string.Empty;
        }
    }
}
