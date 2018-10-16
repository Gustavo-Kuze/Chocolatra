using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolatra.Utils
{
    internal class Internet
    {
        /// <summary>
        /// Checks for an active internet connection
        /// </summary>
        /// <returns>Retusn true if the webclient is able to reach the request</returns>
        public static bool IsActive()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
