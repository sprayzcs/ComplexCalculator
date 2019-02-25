namespace ComplexCalculator.Client.UserControls
{
    partial class InformationUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplexNumber = new System.Windows.Forms.TextBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblConjugatedComplex = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblImaginarypart = new System.Windows.Forms.Label();
            this.lblConjugatedComplexInfo = new System.Windows.Forms.Label();
            this.lblAngleInfo = new System.Windows.Forms.Label();
            this.lblAmountInfo = new System.Windows.Forms.Label();
            this.lblImaginarypartInfo = new System.Windows.Forms.Label();
            this.lblRealpart = new System.Windows.Forms.Label();
            this.lblRealpartInfo = new System.Windows.Forms.Label();
            this.lblExpForm = new System.Windows.Forms.Label();
            this.lblExpFormInfo = new System.Windows.Forms.Label();
            this.lblPolarForm = new System.Windows.Forms.Label();
            this.lblPolarFormInfo = new System.Windows.Forms.Label();
            this.lblCartesianForm = new System.Windows.Forms.Label();
            this.lblCartesianFormInfo = new System.Windows.Forms.Label();
            this.lblAngleNotice = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z = ";
            // 
            // txtComplexNumber
            // 
            this.txtComplexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplexNumber.Location = new System.Drawing.Point(139, 53);
            this.txtComplexNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplexNumber.Name = "txtComplexNumber";
            this.txtComplexNumber.Size = new System.Drawing.Size(552, 34);
            this.txtComplexNumber.TabIndex = 1;
            this.txtComplexNumber.TextChanged += new System.EventHandler(this.TxtComplexNumberTextChangedEvent);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblConjugatedComplex);
            this.panelInfo.Controls.Add(this.lblAngle);
            this.panelInfo.Controls.Add(this.lblAmount);
            this.panelInfo.Controls.Add(this.lblImaginarypart);
            this.panelInfo.Controls.Add(this.lblConjugatedComplexInfo);
            this.panelInfo.Controls.Add(this.lblAngleInfo);
            this.panelInfo.Controls.Add(this.lblAmountInfo);
            this.panelInfo.Controls.Add(this.lblImaginarypartInfo);
            this.panelInfo.Controls.Add(this.lblRealpart);
            this.panelInfo.Controls.Add(this.lblRealpartInfo);
            this.panelInfo.Controls.Add(this.lblExpForm);
            this.panelInfo.Controls.Add(this.lblExpFormInfo);
            this.panelInfo.Controls.Add(this.lblPolarForm);
            this.panelInfo.Controls.Add(this.lblPolarFormInfo);
            this.panelInfo.Controls.Add(this.lblCartesianForm);
            this.panelInfo.Controls.Add(this.lblCartesianFormInfo);
            this.panelInfo.Location = new System.Drawing.Point(92, 133);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(707, 347);
            this.panelInfo.TabIndex = 2;
            // 
            // lblConjugatedComplex
            // 
            this.lblConjugatedComplex.AutoSize = true;
            this.lblConjugatedComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConjugatedComplex.Location = new System.Drawing.Point(251, 222);
            this.lblConjugatedComplex.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblConjugatedComplex.Name = "lblConjugatedComplex";
            this.lblConjugatedComplex.Size = new System.Drawing.Size(0, 25);
            this.lblConjugatedComplex.TabIndex = 9;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.Location = new System.Drawing.Point(251, 191);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(0, 25);
            this.lblAngle.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(251, 160);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 25);
            this.lblAmount.TabIndex = 9;
            // 
            // lblImaginarypart
            // 
            this.lblImaginarypart.AutoSize = true;
            this.lblImaginarypart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImaginarypart.Location = new System.Drawing.Point(251, 129);
            this.lblImaginarypart.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblImaginarypart.Name = "lblImaginarypart";
            this.lblImaginarypart.Size = new System.Drawing.Size(0, 25);
            this.lblImaginarypart.TabIndex = 9;
            // 
            // lblConjugatedComplexInfo
            // 
            this.lblConjugatedComplexInfo.AutoSize = true;
            this.lblConjugatedComplexInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConjugatedComplexInfo.Location = new System.Drawing.Point(0, 222);
            this.lblConjugatedComplexInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblConjugatedComplexInfo.Name = "lblConjugatedComplexInfo";
            this.lblConjugatedComplexInfo.Size = new System.Drawing.Size(178, 25);
            this.lblConjugatedComplexInfo.TabIndex = 8;
            this.lblConjugatedComplexInfo.Text = "Konjugiert komplex";
            // 
            // lblAngleInfo
            // 
            this.lblAngleInfo.AutoSize = true;
            this.lblAngleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngleInfo.Location = new System.Drawing.Point(0, 191);
            this.lblAngleInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAngleInfo.Name = "lblAngleInfo";
            this.lblAngleInfo.Size = new System.Drawing.Size(130, 25);
            this.lblAngleInfo.TabIndex = 8;
            this.lblAngleInfo.Text = "Argument (φ)";
            // 
            // lblAmountInfo
            // 
            this.lblAmountInfo.AutoSize = true;
            this.lblAmountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInfo.Location = new System.Drawing.Point(0, 160);
            this.lblAmountInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAmountInfo.Name = "lblAmountInfo";
            this.lblAmountInfo.Size = new System.Drawing.Size(69, 25);
            this.lblAmountInfo.TabIndex = 8;
            this.lblAmountInfo.Text = "Betrag";
            // 
            // lblImaginarypartInfo
            // 
            this.lblImaginarypartInfo.AutoSize = true;
            this.lblImaginarypartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImaginarypartInfo.Location = new System.Drawing.Point(0, 129);
            this.lblImaginarypartInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblImaginarypartInfo.Name = "lblImaginarypartInfo";
            this.lblImaginarypartInfo.Size = new System.Drawing.Size(111, 25);
            this.lblImaginarypartInfo.TabIndex = 8;
            this.lblImaginarypartInfo.Text = "Imaginärteil";
            // 
            // lblRealpart
            // 
            this.lblRealpart.AutoSize = true;
            this.lblRealpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealpart.Location = new System.Drawing.Point(251, 98);
            this.lblRealpart.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblRealpart.Name = "lblRealpart";
            this.lblRealpart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRealpart.Size = new System.Drawing.Size(0, 25);
            this.lblRealpart.TabIndex = 7;
            // 
            // lblRealpartInfo
            // 
            this.lblRealpartInfo.AutoSize = true;
            this.lblRealpartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealpartInfo.Location = new System.Drawing.Point(0, 98);
            this.lblRealpartInfo.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblRealpartInfo.Name = "lblRealpartInfo";
            this.lblRealpartInfo.Size = new System.Drawing.Size(75, 25);
            this.lblRealpartInfo.TabIndex = 6;
            this.lblRealpartInfo.Text = "Realteil";
            // 
            // lblExpForm
            // 
            this.lblExpForm.AutoSize = true;
            this.lblExpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpForm.Location = new System.Drawing.Point(251, 62);
            this.lblExpForm.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblExpForm.Name = "lblExpForm";
            this.lblExpForm.Size = new System.Drawing.Size(0, 25);
            this.lblExpForm.TabIndex = 5;
            // 
            // lblExpFormInfo
            // 
            this.lblExpFormInfo.AutoSize = true;
            this.lblExpFormInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpFormInfo.Location = new System.Drawing.Point(0, 62);
            this.lblExpFormInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblExpFormInfo.Name = "lblExpFormInfo";
            this.lblExpFormInfo.Size = new System.Drawing.Size(152, 25);
            this.lblExpFormInfo.TabIndex = 4;
            this.lblExpFormInfo.Text = "Exponentialform";
            // 
            // lblPolarForm
            // 
            this.lblPolarForm.AutoSize = true;
            this.lblPolarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolarForm.Location = new System.Drawing.Point(251, 31);
            this.lblPolarForm.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblPolarForm.Name = "lblPolarForm";
            this.lblPolarForm.Size = new System.Drawing.Size(0, 25);
            this.lblPolarForm.TabIndex = 3;
            // 
            // lblPolarFormInfo
            // 
            this.lblPolarFormInfo.AutoSize = true;
            this.lblPolarFormInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolarFormInfo.Location = new System.Drawing.Point(0, 31);
            this.lblPolarFormInfo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblPolarFormInfo.Name = "lblPolarFormInfo";
            this.lblPolarFormInfo.Size = new System.Drawing.Size(95, 25);
            this.lblPolarFormInfo.TabIndex = 2;
            this.lblPolarFormInfo.Text = "Polarform";
            // 
            // lblCartesianForm
            // 
            this.lblCartesianForm.AutoSize = true;
            this.lblCartesianForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartesianForm.Location = new System.Drawing.Point(251, 0);
            this.lblCartesianForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartesianForm.Name = "lblCartesianForm";
            this.lblCartesianForm.Size = new System.Drawing.Size(0, 25);
            this.lblCartesianForm.TabIndex = 1;
            // 
            // lblCartesianFormInfo
            // 
            this.lblCartesianFormInfo.AutoSize = true;
            this.lblCartesianFormInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartesianFormInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCartesianFormInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCartesianFormInfo.Name = "lblCartesianFormInfo";
            this.lblCartesianFormInfo.Size = new System.Drawing.Size(155, 25);
            this.lblCartesianFormInfo.TabIndex = 0;
            this.lblCartesianFormInfo.Text = "Kartesiche Form";
            // 
            // lblAngleNotice
            // 
            this.lblAngleNotice.AutoSize = true;
            this.lblAngleNotice.Location = new System.Drawing.Point(135, 33);
            this.lblAngleNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngleNotice.Name = "lblAngleNotice";
            this.lblAngleNotice.Size = new System.Drawing.Size(254, 17);
            this.lblAngleNotice.TabIndex = 3;
            this.lblAngleNotice.Text = "HINWEIS: Winkel in Gradmaß angeben";
            // 
            // InformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAngleNotice);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.txtComplexNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InformationUserControl";
            this.Size = new System.Drawing.Size(799, 492);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComplexNumber;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCartesianFormInfo;
        private System.Windows.Forms.Label lblCartesianForm;
        private System.Windows.Forms.Label lblConjugatedComplex;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblImaginarypart;
        private System.Windows.Forms.Label lblConjugatedComplexInfo;
        private System.Windows.Forms.Label lblAngleInfo;
        private System.Windows.Forms.Label lblAmountInfo;
        private System.Windows.Forms.Label lblImaginarypartInfo;
        private System.Windows.Forms.Label lblRealpart;
        private System.Windows.Forms.Label lblRealpartInfo;
        private System.Windows.Forms.Label lblExpForm;
        private System.Windows.Forms.Label lblExpFormInfo;
        private System.Windows.Forms.Label lblPolarForm;
        private System.Windows.Forms.Label lblPolarFormInfo;
        private System.Windows.Forms.Label lblAngleNotice;
    }
}
