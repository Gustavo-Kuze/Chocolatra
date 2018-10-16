using System.Diagnostics;

namespace Chocolatra
{
    internal static class Cmd
    {
        /// <summary>
        /// Opens CMD Window and wait for Its execution to be finished
        /// </summary>
        /// <param name="command">Commands You want to execute with cmd</param>
        /// <param name="exit">Should CMD be closed after command execution is over?</param>
        /// <param name="consoleWindowStyle">The state of CMD's window</param>
        public static void RunAndWait(string command, bool exit = true, ProcessWindowStyle consoleWindowStyle = ProcessWindowStyle.Hidden)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = consoleWindowStyle;
            psi.Arguments = "cmd.exe " + ((exit) ? " /c " : " /k ") + " " + command + ((exit) ? " && exit" : "");
            psi.Verb = "runas";
            try
            {
                Process.Start(psi).WaitForExit();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Opens CMD Window and wait for Its execution to be finished.
        /// </summary>
        /// <param name="command">Commands You want to execute with cmd</param>
        /// <param name="consoleWindowStyle">The state of CMD's window</param>
        /// <returns>CMD's output</returns>
        public static string RunAndWaitWithOutput(string command, ProcessWindowStyle consoleWindowStyle = ProcessWindowStyle.Hidden)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WindowStyle = consoleWindowStyle;
            p.StartInfo.Arguments = "cmd.exe /c " + command + "";
            string output = "";
            try
            {
                p.Start();
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                return output;
            }
            catch
            {
            }
            return output;
        }
    }
}

