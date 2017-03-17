// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: IMemoryCellInfoProvider.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Provides basic information for each <see cref="MemoryCell{T}" />.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMemoryCellInfoProvider<T> where T : struct {
        /// <summary>
        ///     Gets the related <see cref="Memory{T}" /> object.
        /// </summary>
        Memory<T> RelatedMemory { get; }

        /// <summary>
        ///     Occurs when the related <see cref="Memory{T}" /> object has updated.
        /// </summary>
        event EventHandler RelatedMemoryUpdated;
    }
}