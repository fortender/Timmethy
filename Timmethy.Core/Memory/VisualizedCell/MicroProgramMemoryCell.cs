// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MicroProgramMemoryCell.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using Timmethy.Core.Helpers;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Extends the <see cref="MemoryCell{MicroOperationCell}" /> by a <see cref="MacroName" /> and
    ///     <see cref="InstructionName" /> property
    ///     due to visualization purposes.
    /// </summary>
    [Serializable]
    public class MicroProgramMemoryCell : MemoryCell<MicroOperationCell> {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MicroProgramMemoryCell" /> class.
        /// </summary>
        /// <param name="cellContainer">A cell container which contains this cell.</param>
        /// <param name="cellIndex">The index of the specific cell to visualize.</param>
        public MicroProgramMemoryCell(IMicroProgramMemoryCellInfoProvider cellContainer, int cellIndex)
            : base(cellContainer, cellIndex) {
        }

        /// <summary>
        ///     Gets the macro name.
        /// </summary>
        public string MacroName => Value.MacroName;

        /// <summary>
        ///     Gets the name of the underlying instruction.
        /// </summary>
        public string InstructionName => Value.Operation.Name.IsNullOrWhiteSpace() ? "---" : Value.Operation.Name;

        #region ValueChanged Support

        protected override void OnValueChanged() {
            base.OnValueChanged();
            RaisePropertyChanged(nameof(MacroName), nameof(InstructionName));
        }

        #endregion
    }
}