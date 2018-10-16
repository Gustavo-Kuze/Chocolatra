using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolatra
{
    internal class Choco
    {

        /// <summary>
        /// Run chocolatey command using command prompt
        /// </summary>
        /// <param name="package">The name of the package to be passed as argument to Choco</param>
        /// <param name="command">What should the Choco tool do with the given package</param>
        public static void RunChoco(string package, string command, bool showConsole = true)
        {
            ProcessWindowStyle style = (showConsole) ?  ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            Cmd.RunAndWait("choco " + command + " " + package + " -y", true, style);
        }


    }
}
