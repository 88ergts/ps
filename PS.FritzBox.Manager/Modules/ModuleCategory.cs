using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.FritzBox.Manager.Modules
{
    /// <summary>
    /// enum for module categories
    /// </summary>
    public enum ModuleCategory
    {
        /// <summary>
        /// category unknown
        /// </summary>
        Unknown = 5,
        /// <summary>
        /// internet category
        /// </summary>
        Internet = 0,
        /// <summary>
        /// Home network
        /// </summary>
        HomeNetwork = 1,
        /// <summary>
        /// wlan
        /// </summary>
        WLAN = 2,
        /// <summary>
        /// system category
        /// </summary>
        System = 3,
    }
}
