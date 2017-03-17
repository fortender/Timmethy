// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: StringX.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System.Linq;

namespace Timmethy.Core.Helpers {
    /// <summary>
    ///     Extends the <see cref="string" /> class.
    /// </summary>
    public static class StringX {
        /// <summary>
        ///     Checks if the given <see cref="string" /> is null, empty or whitespace.
        /// </summary>
        /// <param name="s">Source</param>
        /// <returns>True, if the source is null, empty or whitespace. False, if the source is not.</returns>
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrEmpty(s) || s.All(char.IsWhiteSpace);
    }
}