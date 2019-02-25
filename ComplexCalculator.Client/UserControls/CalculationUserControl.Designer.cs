namespace ComplexCalculator.Client.UserControls
{
    partial class CalculationUserControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAngleNotice = new System.Windows.Forms.Label();
            this.txtComplexNumberOne = new System.Windows.Forms.TextBox();
            this.lblComplexNumberOne = new System.Windows.Forms.Label();
            this.lblComplexNumberOneIndex = new ComplexCalculator.Client.Util.TransparentLabel();
            this.lblComplexNumberTwoIndex = new ComplexCalculator.Client.Util.TransparentLabel();
            this.txtComplexNumberTwo = new System.Windows.Forms.TextBox();
            this.lblComplexNumberTwo = new System.Windows.Forms.Label();
            this.panelOperationButtons = new System.Windows.Forms.Panel();
            this.buttonDivideOperation = new System.Windows.Forms.Button();
            this.buttonMultiplyOperation = new System.Windows.Forms.Button();
            this.buttonSubtractOperation = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.lblComplexNumberEqualsIndex = new ComplexCalculator.Client.Util.TransparentLabel();
            this.txtComplexNumberEquals = new System.Windows.Forms.TextBox();
            this.lblComplexNumberEquals = new System.Windows.Forms.Label();
            this.lblComplexNumberOneValidation = new System.Windows.Forms.Label();
            this.lblComplexNumberTwoValidation = new System.Windows.Forms.Label();
            this.buttonEqualToInformation = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelOperationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAngleNotice
            // 
            this.lblAngleNotice.AutoSize = true;
            this.lblAngleNotice.Location = new System.Drawing.Point(101, 27);
            this.lblAngleNotice.Name = "lblAngleNotice";
            this.lblAngleNotice.Size = new System.Drawing.Size(195, 13);
            this.lblAngleNotice.TabIndex = 6;
            this.lblAngleNotice.Text = "HINWEIS: Winkel in Gradmaß angeben";
            // 
            // txtComplexNumberOne
            // 
            this.txtComplexNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplexNumberOne.Location = new System.Drawing.Point(104, 43);
            this.txtComplexNumberOne.Name = "txtComplexNumberOne";
            this.txtComplexNumberOne.Size = new System.Drawing.Size(415, 29);
            this.txtComplexNumberOne.TabIndex = 5;
            this.txtComplexNumberOne.TextChanged += new System.EventHandler(this.TextBoxComplexNumberTextChanged);
            // 
            // lblComplexNumberOne
            // 
            this.lblComplexNumberOne.AutoSize = true;
            this.lblComplexNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplexNumberOne.Location = new System.Drawing.Point(62, 46);
            this.lblComplexNumberOne.Name = "lblComplexNumberOne";
            this.lblComplexNumberOne.Size = new System.Drawing.Size(48, 24);
            this.lblComplexNumberOne.TabIndex = 4;
            this.lblComplexNumberOne.Text = "Z  = ";
            // 
            // lblComplexNumberOneIndex
            // 
            this.lblComplexNumberOneIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComplexNumberOneIndex.Location = new System.Drawing.Point(78, 59);
            this.lblComplexNumberOneIndex.Name = "lblComplexNumberOneIndex";
            this.lblComplexNumberOneIndex.Size = new System.Drawing.Size(13, 13);
            this.lblComplexNumberOneIndex.TabIndex = 7;
            this.lblComplexNumberOneIndex.TabStop = false;
            this.lblComplexNumberOneIndex.Text = "1";
            this.lblComplexNumberOneIndex.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblComplexNumberTwoIndex
            // 
            this.lblComplexNumberTwoIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComplexNumberTwoIndex.Location = new System.Drawing.Point(79, 97);
            this.lblComplexNumberTwoIndex.Margin = new System.Windows.Forms.Padding(0);
            this.lblComplexNumberTwoIndex.Name = "lblComplexNumberTwoIndex";
            this.lblComplexNumberTwoIndex.Size = new System.Drawing.Size(13, 13);
            this.lblComplexNumberTwoIndex.TabIndex = 10;
            this.lblComplexNumberTwoIndex.TabStop = false;
            this.lblComplexNumberTwoIndex.Text = "2";
            this.lblComplexNumberTwoIndex.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtComplexNumberTwo
            // 
            this.txtComplexNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplexNumberTwo.Location = new System.Drawing.Point(105, 81);
            this.txtComplexNumberTwo.Name = "txtComplexNumberTwo";
            this.txtComplexNumberTwo.Size = new System.Drawing.Size(415, 29);
            this.txtComplexNumberTwo.TabIndex = 9;
            this.txtComplexNumberTwo.TextChanged += new System.EventHandler(this.TextBoxComplexNumberTextChanged);
            // 
            // lblComplexNumberTwo
            // 
            this.lblComplexNumberTwo.AutoSize = true;
            this.lblComplexNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplexNumberTwo.Location = new System.Drawing.Point(63, 84);
            this.lblComplexNumberTwo.Name = "lblComplexNumberTwo";
            this.lblComplexNumberTwo.Size = new System.Drawing.Size(48, 24);
            this.lblComplexNumberTwo.TabIndex = 8;
            this.lblComplexNumberTwo.Text = "Z  = ";
            // 
            // panelOperationButtons
            // 
            this.panelOperationButtons.Controls.Add(this.buttonDivideOperation);
            this.panelOperationButtons.Controls.Add(this.buttonMultiplyOperation);
            this.panelOperationButtons.Controls.Add(this.buttonSubtractOperation);
            this.panelOperationButtons.Controls.Add(this.buttonAddOperation);
            this.panelOperationButtons.Location = new System.Drawing.Point(104, 127);
            this.panelOperationButtons.Name = "panelOperationButtons";
            this.panelOperationButtons.Size = new System.Drawing.Size(416, 50);
            this.panelOperationButtons.TabIndex = 11;
            // 
            // buttonDivideOperation
            // 
            this.buttonDivideOperation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDivideOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDivideOperation.FlatAppearance.BorderSize = 0;
            this.buttonDivideOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivideOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivideOperation.Location = new System.Drawing.Point(312, 0);
            this.buttonDivideOperation.Name = "buttonDivideOperation";
            this.buttonDivideOperation.Size = new System.Drawing.Size(104, 50);
            this.buttonDivideOperation.TabIndex = 3;
            this.buttonDivideOperation.Text = "/";
            this.buttonDivideOperation.UseVisualStyleBackColor = false;
            this.buttonDivideOperation.Click += new System.EventHandler(this.OperationButtonClickHandler);
            // 
            // buttonMultiplyOperation
            // 
            this.buttonMultiplyOperation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMultiplyOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMultiplyOperation.FlatAppearance.BorderSize = 0;
            this.buttonMultiplyOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplyOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplyOperation.Location = new System.Drawing.Point(208, 0);
            this.buttonMultiplyOperation.Name = "buttonMultiplyOperation";
            this.buttonMultiplyOperation.Size = new System.Drawing.Size(104, 50);
            this.buttonMultiplyOperation.TabIndex = 2;
            this.buttonMultiplyOperation.Text = "•";
            this.buttonMultiplyOperation.UseVisualStyleBackColor = false;
            this.buttonMultiplyOperation.Click += new System.EventHandler(this.OperationButtonClickHandler);
            // 
            // buttonSubtractOperation
            // 
            this.buttonSubtractOperation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSubtractOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSubtractOperation.FlatAppearance.BorderSize = 0;
            this.buttonSubtractOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtractOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtractOperation.Location = new System.Drawing.Point(104, 0);
            this.buttonSubtractOperation.Name = "buttonSubtractOperation";
            this.buttonSubtractOperation.Size = new System.Drawing.Size(104, 50);
            this.buttonSubtractOperation.TabIndex = 1;
            this.buttonSubtractOperation.Text = "-";
            this.buttonSubtractOperation.UseVisualStyleBackColor = false;
            this.buttonSubtractOperation.Click += new System.EventHandler(this.OperationButtonClickHandler);
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddOperation.FlatAppearance.BorderSize = 0;
            this.buttonAddOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOperation.Location = new System.Drawing.Point(0, 0);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(104, 50);
            this.buttonAddOperation.TabIndex = 0;
            this.buttonAddOperation.Text = "+";
            this.buttonAddOperation.UseVisualStyleBackColor = false;
            this.buttonAddOperation.Click += new System.EventHandler(this.OperationButtonClickHandler);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Enabled = false;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.Location = new System.Drawing.Point(105, 183);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(415, 50);
            this.buttonEquals.TabIndex = 12;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.ButtonEqualsClickEvent);
            // 
            // lblComplexNumberEqualsIndex
            // 
            this.lblComplexNumberEqualsIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComplexNumberEqualsIndex.Location = new System.Drawing.Point(79, 273);
            this.lblComplexNumberEqualsIndex.Name = "lblComplexNumberEqualsIndex";
            this.lblComplexNumberEqualsIndex.Size = new System.Drawing.Size(13, 13);
            this.lblComplexNumberEqualsIndex.TabIndex = 15;
            this.lblComplexNumberEqualsIndex.TabStop = false;
            this.lblComplexNumberEqualsIndex.Text = "E";
            this.lblComplexNumberEqualsIndex.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtComplexNumberEquals
            // 
            this.txtComplexNumberEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplexNumberEquals.Location = new System.Drawing.Point(105, 257);
            this.txtComplexNumberEquals.Name = "txtComplexNumberEquals";
            this.txtComplexNumberEquals.ReadOnly = true;
            this.txtComplexNumberEquals.Size = new System.Drawing.Size(415, 29);
            this.txtComplexNumberEquals.TabIndex = 14;
            // 
            // lblComplexNumberEquals
            // 
            this.lblComplexNumberEquals.AutoSize = true;
            this.lblComplexNumberEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplexNumberEquals.Location = new System.Drawing.Point(63, 260);
            this.lblComplexNumberEquals.Name = "lblComplexNumberEquals";
            this.lblComplexNumberEquals.Size = new System.Drawing.Size(48, 24);
            this.lblComplexNumberEquals.TabIndex = 13;
            this.lblComplexNumberEquals.Text = "Z  = ";
            // 
            // lblComplexNumberOneValidation
            // 
            this.lblComplexNumberOneValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplexNumberOneValidation.Location = new System.Drawing.Point(520, 39);
            this.lblComplexNumberOneValidation.Name = "lblComplexNumberOneValidation";
            this.lblComplexNumberOneValidation.Size = new System.Drawing.Size(29, 29);
            this.lblComplexNumberOneValidation.TabIndex = 16;
            // 
            // lblComplexNumberTwoValidation
            // 
            this.lblComplexNumberTwoValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplexNumberTwoValidation.Location = new System.Drawing.Point(521, 77);
            this.lblComplexNumberTwoValidation.Name = "lblComplexNumberTwoValidation";
            this.lblComplexNumberTwoValidation.Size = new System.Drawing.Size(29, 29);
            this.lblComplexNumberTwoValidation.TabIndex = 17;
            // 
            // buttonEqualToInformation
            // 
            this.buttonEqualToInformation.Enabled = false;
            this.buttonEqualToInformation.Location = new System.Drawing.Point(525, 257);
            this.buttonEqualToInformation.Name = "buttonEqualToInformation";
            this.buttonEqualToInformation.Size = new System.Drawing.Size(29, 29);
            this.buttonEqualToInformation.TabIndex = 18;
            this.buttonEqualToInformation.Text = "?";
            this.buttonEqualToInformation.UseVisualStyleBackColor = true;
            this.buttonEqualToInformation.Click += new System.EventHandler(this.ButtonEqualToInformationClickEvent);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(527, 183);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClickEvent);
            // 
            // CalculationUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEqualToInformation);
            this.Controls.Add(this.lblComplexNumberTwoValidation);
            this.Controls.Add(this.lblComplexNumberOneValidation);
            this.Controls.Add(this.lblComplexNumberEqualsIndex);
            this.Controls.Add(this.txtComplexNumberEquals);
            this.Controls.Add(this.lblComplexNumberEquals);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.panelOperationButtons);
            this.Controls.Add(this.lblComplexNumberTwoIndex);
            this.Controls.Add(this.txtComplexNumberTwo);
            this.Controls.Add(this.lblComplexNumberTwo);
            this.Controls.Add(this.lblComplexNumberOneIndex);
            this.Controls.Add(this.lblAngleNotice);
            this.Controls.Add(this.txtComplexNumberOne);
            this.Controls.Add(this.lblComplexNumberOne);
            this.Name = "CalculationUserControl";
            this.panelOperationButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAngleNotice;
        private System.Windows.Forms.TextBox txtComplexNumberOne;
        private System.Windows.Forms.Label lblComplexNumberOne;
        private Util.TransparentLabel lblComplexNumberOneIndex;
        private Util.TransparentLabel lblComplexNumberTwoIndex;
        private System.Windows.Forms.TextBox txtComplexNumberTwo;
        private System.Windows.Forms.Label lblComplexNumberTwo;
        private System.Windows.Forms.Panel panelOperationButtons;
        private System.Windows.Forms.Button buttonDivideOperation;
        private System.Windows.Forms.Button buttonMultiplyOperation;
        private System.Windows.Forms.Button buttonSubtractOperation;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.Button buttonEquals;
        private Util.TransparentLabel lblComplexNumberEqualsIndex;
        private System.Windows.Forms.TextBox txtComplexNumberEquals;
        private System.Windows.Forms.Label lblComplexNumberEquals;
        private System.Windows.Forms.Label lblComplexNumberOneValidation;
        private System.Windows.Forms.Label lblComplexNumberTwoValidation;
        private System.Windows.Forms.Button buttonEqualToInformation;
        private System.Windows.Forms.Button buttonClear;
    }
}
