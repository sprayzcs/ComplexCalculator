using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator.Client.Util
{
    /// <summary>
    /// Button that fixes a weird bug when focusing it and switching active windows
    /// </summary>
    class FixedButton : Button
    {
        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }
    }
}
