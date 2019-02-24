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

namespace ComplexCalculator.Client.UserControls
{
    public partial class UserControlBase : UserControl
    {
        protected MainForm MainForm { get; private set; }

        public UserControlBase()
        {
            InitializeComponent();

            this.Width = 599;
            this.Height = 400;

            this.Load += UserControlBase_Load;
        }

        private void UserControlBase_Load(object sender, EventArgs e)
        {
            this.MainForm = Parent.Parent as MainForm;
        }
    }
}
