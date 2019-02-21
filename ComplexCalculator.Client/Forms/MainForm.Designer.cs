namespace ComplexCalculator.Client.Forms
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.buttonMinimize = new ComplexCalculator.Client.Util.FixedButton();
            this.buttonExit = new ComplexCalculator.Client.Util.FixedButton();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonInformation = new ComplexCalculator.Client.Util.FixedButton();
            this.panelNavigationBorder = new System.Windows.Forms.Panel();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.panelHead.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHead.Controls.Add(this.labelHeadline);
            this.panelHead.Controls.Add(this.buttonMinimize);
            this.panelHead.Controls.Add(this.buttonExit);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(800, 50);
            this.panelHead.TabIndex = 0;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeadMouseDownEvent);
            // 
            // labelHeadline
            // 
            this.labelHeadline.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHeadline.Location = new System.Drawing.Point(0, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(201, 50);
            this.labelHeadline.TabIndex = 2;
            this.labelHeadline.Text = "ComplexCalculator ";
            this.labelHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMinimize.Location = new System.Drawing.Point(700, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 50);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtomMinimizeClickEvent);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExit.Location = new System.Drawing.Point(750, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClickEvent);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelNavigation.Controls.Add(this.buttonInformation);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 50);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 400);
            this.panelNavigation.TabIndex = 1;
            // 
            // buttonInformation
            // 
            this.buttonInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInformation.FlatAppearance.BorderSize = 0;
            this.buttonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformation.Location = new System.Drawing.Point(0, 0);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(200, 50);
            this.buttonInformation.TabIndex = 0;
            this.buttonInformation.Text = "Informationen";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.ButtonInformationClickEvent);
            // 
            // panelNavigationBorder
            // 
            this.panelNavigationBorder.BackColor = System.Drawing.SystemColors.Control;
            this.panelNavigationBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigationBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigationBorder.Location = new System.Drawing.Point(200, 50);
            this.panelNavigationBorder.Name = "panelNavigationBorder";
            this.panelNavigationBorder.Size = new System.Drawing.Size(1, 400);
            this.panelNavigationBorder.TabIndex = 2;
            // 
            // panelUserControl
            // 
            this.panelUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserControl.Location = new System.Drawing.Point(201, 50);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(599, 400);
            this.panelUserControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUserControl);
            this.Controls.Add(this.panelNavigationBorder);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelHead.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private Util.FixedButton buttonExit;
        private Util.FixedButton buttonMinimize;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelNavigationBorder;
        private System.Windows.Forms.Label labelHeadline;
        private Util.FixedButton buttonInformation;
        private System.Windows.Forms.Panel panelUserControl;
    }
}

