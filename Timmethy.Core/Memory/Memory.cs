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
        public IEnumerator<T> GetEnumerator() => new GenericEnumerator<T>(_cells);

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
    
    /// <summary>
    ///     Is needed for the implementation of the <see cref="IEnumerable{T}" /> interface to enable accessors to iterate
    ///     through an array.
    /// </summary>
    /// <typeparam name="T">The array type</typeparam>
    public class GenericEnumerator<T> : IEnumerator<T> {
        private readonly T[] _cells;
        private int _position = -1;

        /// <summary>
        ///     Initializes a new instance of the <see cref="GenericEnumerator{T}" /> class.
        /// </summary>
        /// <param name="cells"></param>
        public GenericEnumerator(T[] cells) {
            _cells = cells;
        }

        /// <summary>
        ///     Gets the cell at the current position.
        /// </summary>
        public T Current {
            get {
                try
                {
                    return _cells[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        ///     Gets object at the current position
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        ///     Releases all managed and unmanaged resources and notifies the <see cref="GC" />.
        ///     Not needed here.
        /// </summary>
        public void Dispose() {
        }

        /// <summary>
        ///     Increments the position and moves to the next array element.
        /// </summary>
        /// <returns>
        ///     True, if the position is valid and less than the array's length. False, if the position fell out of bounds.
        ///     (end-of-array)
        /// </returns>
        public bool MoveNext() {
            _position++;
            return _position < _cells.Length;
        }

        /// <summary>
        ///     Resets the position.
        /// </summary>
        public void Reset() {
            _position = -1;
        }
    }
}