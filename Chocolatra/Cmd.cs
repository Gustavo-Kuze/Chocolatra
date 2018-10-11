using System.Diagnostics;

namespace Chocolatra
{
    internal static class Cmd
    {

        public static void RunAndWait(string command, bool exit = true, ProcessWindowStyle consoleWindowStyle = ProcessWindowStyle.Hidden)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = consoleWindowStyle;
            psi.Arguments = "cmd.exe "+ ((exit) ? " /c " : " /k ") + " " + command + ((exit)?" && exit" : "");
            psi.Verb = "runas";
            try
            {
                Process.Start(psi).WaitForExit();
            }
            catch
            {
            }
        }


        public static string RunAndWaitWithOutput(string command, ProcessWindowStyle consoleWindowStyle = ProcessWindowStyle.Hidden)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WindowStyle = consoleWindowStyle;
            p.StartInfo.Arguments = "cmd.exe /c " + command + "";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }


    }
}

