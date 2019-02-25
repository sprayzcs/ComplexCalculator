using ComplexCalculator.Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private UserControlBase _activeInstance;
        private List<UserControlBase> _savedInstances = new List<UserControlBase>();

        public  MainForm()
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

        private void SetUserControl<T>(params object[] args) where T : UserControlBase
        {
            UserControlBase savedInstance = _savedInstances.Where(i => i.GetType() == typeof(T)).FirstOrDefault();

            UserControlBase instance = null;

            if(args.Length != 0)
            {
                _savedInstances.Remove(savedInstance);
                savedInstance = null;
            }

            instance = savedInstance ?? Activator.CreateInstance(typeof(T), args: args) as UserControlBase;

            if (savedInstance == null) _savedInstances.Add(instance);

            if (instance.GetType() == _activeInstance?.GetType()) return;
            _activeInstance = instance;

            this.panelUserControl.Controls.Clear();
            this.panelUserControl.Controls.Add(instance);

            (instance as UserControl).Dock = DockStyle.Fill;
        }

        private void ButtonInformationClickEvent(object sender, EventArgs e)
        {
            SetUserControl<InformationUserControl>();
        }

        private void ButtonCalculationClickEvent(object sender, EventArgs e)
        {
            SetUserControl<CalculationUserControl>();
        }

        public void OpenInformationUserControl(string input)
        {
            SetUserControl<InformationUserControl>(input);
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
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        #endregion
    }
}
