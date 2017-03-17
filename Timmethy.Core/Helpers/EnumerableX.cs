// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: EnumerableX.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Timmethy.Core.Helpers {
    /// <summary>
    ///     <see cref="IEnumerable{T}" /> extension class.
    /// </summary>
    public static class EnumerableX {
        /// <summary>
        ///     Runs a specific action for all elements.
        /// </summary>
        /// <typeparam name="T">The <see cref="IEnumerable{T}" /> type.</typeparam>
        /// <param name="enumerable">An object that implements <see cref="IEnumerable{T}" /> interface.</param>
        /// <param name="action">The action to run for all elements.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            foreach (T element in enumerable)
                action(element);
        }
    }
}