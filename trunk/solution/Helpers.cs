// -----------------------------------------------------------------------
// <copyright file="Helpers.cs" company="Camilo Martin">
//     Licensed under the GNU GPL v3. 
// </copyright>
// -----------------------------------------------------------------------

namespace Msile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class contains helpers.
    /// </summary>
    /// <remarks>
    /// It is not good to have a lot of helpers. 
    /// As soon as there are some helpers with related functionality, 
    /// it is desireable to move them to a dedicated class.
    /// </remarks>
    public static class Helpers
    {
        /// <summary>
        /// Checks if a generic object is null, throws an exception if it is, and returns it if it's not.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <param name="input">The object to check.</param>
        /// <remarks>
        /// This is useful to bypass CA1062 in cases where you know it's not null, such as overriden control event handlers.
        /// </remarks>
        /// <returns>The unaltered input, if not null.</returns>
        public static T ThrowExceptionIfNull<T>(T input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            return input;
        }
    }
}
