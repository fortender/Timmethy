// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: RandomAccessMemoryCell.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Extends the <see cref="HighLowValueCell" /> by a <see cref="MacroName" /> and <see cref="Operand" /> property
    ///     due to visualization purposes.
    /// </summary>
    [Serializable]
    public class RandomAccessMemoryCell : HighLowValueCell {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RandomAccessMemoryCell" /> class.
        /// </summary>
        /// <param name="cellContainer">Provider for all needed information.</param>
        /// <param name="cellIndex">The index of the cell to visualize.</param>
        public RandomAccessMemoryCell(RandomAccessMemoryCellContainer cellContainer, int cellIndex)
            : base(cellContainer, cellIndex) {
        }

        /// <summary>
        ///     Gets the macro name.
        /// </summary>
        public string MacroName {
            get {
                var container = (RandomAccessMemoryCellContainer)CellContainer.Target;
                return container != null && Hi > 0 ? container.RelatedMicroProgramMemory.GetCell(Hi*10).MacroName : null;
            }
        }

        /// <summary>
        ///     Gets a formatted version of the Low-Code which acts as an operand.
        /// </summary>
        public string Operand => Hi > 0 ? Lo.ToString("000") : null;

        #region ValueChanged Support

        protected override void OnValueChanged() {
            base.OnValueChanged();
            RaisePropertyChanged(nameof(MacroName), nameof(Operand));
        }

        #endregion
    }
}