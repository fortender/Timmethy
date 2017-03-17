// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: CellChangedEventArgs.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

#region FileHeader

#if false
Custom event arguments that cover the index of the changed cell
#endif
//Usings
using System;

#endregion

namespace Timmethy.Core.Memory {
    /// <summary>
    ///     Is passed when the <see cref="Memory{T}.CellChanged" /> event raises
    ///     with information about the cell that has changed.
    /// </summary>
    public class CellChangedEventArgs : EventArgs {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CellChangedEventArgs" /> class.
        /// </summary>
        /// <param name="cellIndex">The index of the cell that has changed.</param>
        public CellChangedEventArgs(int cellIndex) {
            CellIndex = cellIndex;
        }

        /// <summary>
        ///     Index of the changed cell.
        /// </summary>
        public int CellIndex { private set; get; }
    }
}