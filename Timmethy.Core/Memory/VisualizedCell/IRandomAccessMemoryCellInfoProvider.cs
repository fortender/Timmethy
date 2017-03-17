// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: IRandomAccessMemoryCellInfoProvider.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Adds information used by a <see cref="RandomAccessMemoryCell" /> to resolve a macro name from an identifer.
    /// </summary>
    public interface IRandomAccessMemoryCellInfoProvider : IMemoryCellInfoProvider<int> {
        /// <summary>
        ///     Gets the related micro program memory as it is usually needed to resolve macros from there Ids.
        /// </summary>
        Memory<MicroOperationCell> RelatedMicroProgramMemory { get; }

        /// <summary>
        /// Occurs when the related micro program memory has changed.
        /// </summary>
        event EventHandler RelatedMicroProgramMemoryChanged;
    }
}