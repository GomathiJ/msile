//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Camilo Martin">
//     Licensed under the GNU GPL v3. 
// </copyright>
//-----------------------------------------------------------------------

[assembly: System.CLSCompliant(true)]

namespace Msile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Container for the application's entry point.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PackageManagerForm());
        }
    }
}
