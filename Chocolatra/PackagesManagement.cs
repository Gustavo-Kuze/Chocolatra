using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chocolatra
{
    internal class PackagesManagement
    {
        /// <summary>
        /// If the packages File is not found on the executing directory, It'll be created.
        /// </summary>
        public PackagesManagement()
        {
            if (!File.Exists(Application.StartupPath + "\\packages"))
            {
                File.WriteAllText(Application.StartupPath + "\\packages", "", Encoding.UTF8);
            }
        }

        /// <summary>
        /// Appends the passed package name to the packages file.
        /// </summary>
        /// <param name="packages">A string with only the name of the Chocolatey package to be added</param>
        internal void add(string[] packages)
        {
            var lines = File.ReadAllLines(Application.StartupPath + "\\packages").ToList();
            foreach (string package in packages)
            {
                if (!lines.Select(x=>x.ToLower()).Contains(package.ToLower())) //case insensitive check
                {
                    File.AppendAllLines(Application.StartupPath + "\\packages", new string[] { package }, Encoding.UTF8);
                }
            }
        }

        /// <summary>
        /// Remove the given package name from the File
        /// </summary>
        /// <param name="package">Name of the package to remove</param>
        internal void remove(string package)
        {
            var lines = File.ReadAllLines(Application.StartupPath + "\\packages").ToList();
            if (lines.Contains(package))
            {
                lines.Remove(package);
            }
            File.WriteAllLines(Application.StartupPath + "\\packages", lines, Encoding.UTF8);
        }

        /// <summary>
        /// Get all saved packages in the packages file.
        /// </summary>
        /// <returns>A string array with all lines saved on the packages file</returns>
        internal string[] load()
        {
            return File.ReadLines(Application.StartupPath + "\\packages", Encoding.UTF8).ToArray();
        }

    }
}
