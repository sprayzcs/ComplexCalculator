using ComplexCalculator.Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator.Client.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonExitClickEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtomMinimizeClickEvent(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SetUserControl<T>() where T : UserControl
        {
            T instance = Activator.CreateInstance<T>() as T;
            this.panelUserControl.Controls.Clear();
            this.panelUserControl.Controls.Add(instance);

            (instance as UserControl).Dock = DockStyle.Fill;
        }

        private void ButtonInformationClickEvent(object sender, EventArgs e)
        {
            SetUserControl<InformationUserControl>();
        }

        #region Move Window
        private void PanelHeadMouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
    }
}
