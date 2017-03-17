// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: ClippedIntegerMemory.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using Timmethy.Core.Helpers;

namespace Timmethy.Core.Memory {
    /// <summary>
    ///     Holds, provides and manages random access memory cells.
    /// </summary>
    [Serializable]
    public class ClippedIntegerMemory : Memory<int> {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ClippedIntegerMemory" /> class.
        /// </summary>
        /// <param name="size">The fixed memory size.</param>
        /// <param name="valueMax">The maximum a cell's value can raise to.</param>
        public ClippedIntegerMemory(int size, int valueMax) : base(size) {
            ValueMaximum = valueMax;
        }

        /// <summary>
        ///     The maximum a cell's value can raise to.
        /// </summary>
        public int ValueMaximum { get; }

        /// <summary>
        ///     Sets the cell to a specific value and clips it to the value range.
        /// </summary>
        public override void SetCell(int index, int cell) {
            base.SetCell(index, cell.ClipIn(0, ValueMaximum));
        }
    }
}