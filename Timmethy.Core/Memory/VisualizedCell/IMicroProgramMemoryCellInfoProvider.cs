// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: IMicroProgramMemoryCellInfoProvider.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System.Collections.ObjectModel;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Adds an <see cref="InstructionSet" /> and an <see cref="Executer" /> used by a
    ///     <see cref="MicroProgramMemoryCell" />.
    /// </summary>
    public interface IMicroProgramMemoryCellInfoProvider : IMemoryCellInfoProvider<MicroOperationCell> {
        /// <summary>
        ///     Gets the underlying instruction set.
        /// </summary>
        ReadOnlyCollection<MicroOperation> InstructionSet { get; }

        /// <summary>
        ///     Gets the underlying instruction executer used to execute instructions, macros and even programs.
        /// </summary>
        InstructionExecuter Executer { get; }
    }
}