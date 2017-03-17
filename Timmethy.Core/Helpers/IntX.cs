// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: IntX.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

namespace Timmethy.Core.Helpers {
    /// <summary>
    ///     A <see cref="int" /> extension class.
    /// </summary>
    public static class IntX {
        /// <summary>
        ///     Clips a given value to the specified minimum and maximum.
        /// </summary>
        /// <param name="value">The value to clip.</param>
        /// <param name="min">The minimum of the value.</param>
        /// <param name="max">The maximum of the value.</param>
        /// <returns>The clipped result.</returns>
        public static int ClipIn(this int value, int min, int max) {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
}