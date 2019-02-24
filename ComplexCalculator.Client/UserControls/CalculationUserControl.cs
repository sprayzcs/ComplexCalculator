using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexCalculator.Number;

namespace ComplexCalculator.Client.UserControls
{
    public partial class CalculationUserControl : UserControlBase
    {
        private const string ICON_VALID = "✔";
        private const string ICON_INVALID = "✘";

        private List<Button> operationButtons = new List<Button>();
        private string activeOperation = string.Empty;
        private ComplexNumber equalsNumber;

        public CalculationUserControl()
        {
            InitializeComponent();

            operationButtons.AddRange(new[] {
                this.buttonAddOperation,
                this.buttonSubtractOperation,
                this.buttonMultiplyOperation,
                this.buttonDivideOperation
            });
        }

        private void OperationButtonClickHandler(object sender, EventArgs e)
        {
            if (!(sender is Button button)) return;

            buttonEquals.Enabled = true;

            operationButtons.ForEach(b =>
            {
                if (b == button)
                {
                    b.FlatAppearance.BorderSize = 1;
                    this.activeOperation = b.Text;
                }
                else b.FlatAppearance.BorderSize = 0;
            });

            CheckEqualsButton();
        }

        private void ButtonEqualsClickEvent(object sender, EventArgs e)
        {
            if(
                   !ComplexNumber.TryParse(txtComplexNumberOne.Text, out ComplexNumber numberOne)
                || !ComplexNumber.TryParse(txtComplexNumberTwo.Text, out ComplexNumber numberTwo))
            {
                MessageBox.Show("Die komplexen Zahlen sind nicht korrekt.", "Fehler bei der Berechnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(activeOperation == string.Empty)
            {
                MessageBox.Show("Es wurde kein Operator ausgewählt.", "Fehler bei der Berechnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch(activeOperation)
            {
                case "+":
                    equalsNumber = numberOne + numberTwo;
                    break;
                case "-":
                    equalsNumber = numberOne - numberTwo;
                    break;
                case "•":
                    equalsNumber = numberOne * numberTwo;
                    break;
                case "/":
                    equalsNumber = numberOne / numberTwo;
                    break;
            }

            txtComplexNumberEquals.Text = equalsNumber.ToString(NumberFormat.CARTESIAN);
            buttonEqualToInformation.Enabled = true;
        }

        private void TextBoxComplexNumberTextChanged(object sender, EventArgs e)
        {
            Label validationLabel;

            if (sender == txtComplexNumberOne) validationLabel = lblComplexNumberOneValidation;
            else if (sender == txtComplexNumberTwo) validationLabel = lblComplexNumberTwoValidation;
            else return;

            string text = string.Empty;
            Color color;

            bool canParse = ComplexNumber.TryParse((sender as TextBox).Text, out ComplexNumber number);

            if (canParse)
            {
                text = ICON_VALID;
                color = Color.Green;
            }
            else
            {
                text = ICON_INVALID;
                color = Color.Red;
            }

            validationLabel.Text = text;
            validationLabel.ForeColor = color;

            CheckEqualsButton();
        }

        private void CheckEqualsButton()
        {
            string complexOneStr = txtComplexNumberOne.Text;
            string complexTwoStr = txtComplexNumberTwo.Text;

            bool canParseComplexOne = ComplexNumber.TryParse(complexOneStr, out ComplexNumber complexNumberOne);
            bool canParseComplexTwo = ComplexNumber.TryParse(complexTwoStr, out ComplexNumber complexNumberTwo);

            bool operationSelected = activeOperation != string.Empty;

            buttonEquals.Enabled = canParseComplexOne && canParseComplexTwo && operationSelected;
        }

        private void ButtonEqualToInformationClickEvent(object sender, EventArgs e)
        {
            MainForm.OpenInformationUserControl(equalsNumber.ToString(NumberFormat.INPUT));
        }
    }
}
