// -----------------------------------------------------------------------
// <copyright file="Constants.cs" company="Camilo Martin">
//     Licensed under the GNU GPL v3. 
// </copyright>
// -----------------------------------------------------------------------

namespace Msile
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Holds common constants.
    /// </summary>
    /// <remarks>
    /// Warnings about the naming of the constants in this class can be safely suppressed if they pertain to the Windows API.
    /// For FxCop code analysis, right-click and "suppress message" in the "project suppression file" (GlobalSuppressions.cs).
    /// For StyleCop, the SuppressMessage attribute will take care of it.
    /// </remarks>
    [SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", 
        Justification = "WinAPI constants. See this discussion: http://stackoverflow.com/questions/9917942/.")]
    public static class Constants
    {
        /// <summary>
        /// With this style turned on for your form, Windows does double-buffering on the form and all its child controls.
        /// </summary>
        public const int WS_EX_COMPOSITED = 0x02000000;
    }
}
