// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: HighLowValueCell.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using Timmethy.Core.Helpers;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Adds two properties 'Hi' and 'Lo' which are implemented for visualization purposes.
    /// </summary>
    [Serializable]
    public class HighLowValueCell : MemoryCell<int> {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HighLowValueCell" /> class.
        /// </summary>
        /// <param name="cellContainer">Container which contains this cell.</param>
        /// <param name="cellIndex">The index of the cell.</param>
        public HighLowValueCell(IMemoryCellInfoProvider<int> cellContainer, int cellIndex)
            : base(cellContainer, cellIndex) {
        }

        /// <summary>
        ///     Gets or sets the High-Code of the memory cell.
        /// </summary>
        public int Hi {
            get { return Value.GetHiCode(); }
            set { Value = value*1000 + Lo; }
        }

        /// <summary>
        ///     Gets or sets the Low-Code of the memory cell.
        /// </summary>
        public int Lo {
            get { return Value.GetLoCode(); }
            set { Value = Hi*1000 + value; }
        }

        #region ValueChanged Support

        protected override void OnValueChanged() {
            base.OnValueChanged();
            RaisePropertyChanged(nameof(Hi), nameof(Lo));
        }

        #endregion
    }
}