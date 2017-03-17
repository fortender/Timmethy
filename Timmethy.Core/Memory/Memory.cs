// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: Memory.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Timmethy.Core.Memory {
    /// <summary>
    ///     Holds, provides and manages memory cells.
    /// </summary>
    /// <typeparam name="T">The specific cell type.</typeparam>
    [Serializable]
    public class Memory<T> : IMemory<T> where T : struct {
        private readonly T[] _cells;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Memory{T}" /> class.
        /// </summary>
        /// <param name="size">The fixed memory size.</param>
        public Memory(int size) {
            if (size < 0) throw new ArgumentException(nameof(size));
            _cells = new T[size];
        }

        /// <summary>
        ///     Gets or sets the cell at the specified position.
        /// </summary>
        /// <param name="index">Points at the specific cell in memory.</param>
        /// <returns></returns>
        public T this[int index] {
            get { return GetCell(index); }
            set { SetCell(index, value); }
        }

        /// <summary>
        ///     Gets the memory length.
        /// </summary>
        public int Length => _cells.Length;

        /// <summary>
        ///     Gets the memory length as a signed 64 bit integer.
        /// </summary>
        public long LongLength => _cells.LongLength;

        /// <summary>
        ///     Sets the cell at the specified position.
        /// </summary>
        /// <param name="index">Points at the specific cell in memory.</param>
        /// <param name="cell">The new cell value.</param>
        public virtual void SetCell(int index, T cell) {
            if (_cells[index].Equals(cell)) return;
            _cells[index] = cell;
            OnCellChanged(index);
        }

        /// <summary>
        ///     Gets the cell at the specified position.
        /// </summary>
        /// <param name="index">Points at the specific cell in memory.</param>
        /// <returns></returns>
        public T GetCell(int index) => _cells[index];

        /// <summary>
        ///     Gets an enumerator which enables to iterate through the memory.
        /// </summary>
        /// <returns>The <see cref="IEnumerator{T}" /> to iterate through the memory.</returns>
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>) _cells).GetEnumerator();

        /// <summary>
        ///     Gets an enumerator which enables to iterate through the memory.
        /// </summary>
        /// <returns>The <see cref="IEnumerator" /> to iterate through the memory.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #region CellChanged Support

        /// <summary>
        ///     Occurs when a cell has changed.
        /// </summary>
        [field: NonSerialized]
        public event EventHandler<CellChangedEventArgs> CellChanged;

        protected virtual void OnCellChanged(int index) {
            CellChanged?.Invoke(this, new CellChangedEventArgs(index));
        }

        #endregion
    }
}