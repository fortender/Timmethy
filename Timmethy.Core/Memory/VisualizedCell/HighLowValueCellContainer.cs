// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: HighLowValueCellContainer.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    /// </summary>
    public class HighLowValueCellContainer : MemoryCellContainer<int, HighLowValueCell> {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HighLowValueCellContainer" /> class.
        /// </summary>
        /// <param name="memory">The underlying <see cref="Memory{T}" /> instance.</param>
        public HighLowValueCellContainer(Memory<int> memory) : base(memory) {
        }

        protected override HighLowValueCell CreateVisualizedCellFrom(int index) {
            return new HighLowValueCell(this, index);
        }
    }
}