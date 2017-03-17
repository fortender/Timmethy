// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MicroProgramMemoryCellContainer.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System.Collections.ObjectModel;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Creates the visualizer memory cells from a given <see cref="Memory{MicroOperationCell}" /> instance and
    ///     provides important information for them.
    /// </summary>
    public class MicroProgramMemoryCellContainer : MemoryCellContainer<MicroOperationCell, MicroProgramMemoryCell>,
        IMicroProgramMemoryCellInfoProvider {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MemoryCellContainer{TRawCell,TVisualizedCell}" /> class.
        /// </summary>
        /// <param name="memory">The related memory instance.</param>
        /// <param name="instructionSet">The related instruction set.</param>
        public MicroProgramMemoryCellContainer(Memory<MicroOperationCell> memory,
            ReadOnlyCollection<MicroOperation> instructionSet) : base(memory) {
            InstructionSet = instructionSet;
            Executer = new InstructionExecuter(this);
        }

        /// <summary>
        ///     Gets the related instruction set needed to resolve instructions cells are pointing at.
        /// </summary>
        public ReadOnlyCollection<MicroOperation> InstructionSet { get; }

        /// <summary>
        ///     Gets the instruction executer which provides functions to execute instructions, macros and programs.
        /// </summary>
        public InstructionExecuter Executer { get; }

        protected override MicroProgramMemoryCell CreateVisualizedCellFrom(int index) {
            return new MicroProgramMemoryCell(this, index);
        }
    }
}