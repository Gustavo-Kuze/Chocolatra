using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatra.Utils
{
    internal class GUI
    {
        Form father = new Form();
        public GUI(Form parent)
        {
            father = parent;
        }

        public void TogglePanelsEnabled(Panel[] panels, bool enable = true)
        {
            father.Invoke(new MethodInvoker(() =>
            {
                foreach (Panel pane in panels)
                {
                    pane.Enabled = enable;
                }
            }));
        }

    }
}
