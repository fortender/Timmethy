// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MemoryCellContainer.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Creates the visualizer memory cells from a given <see cref="Memory{T}" /> instance and
    ///     provides important information for them.
    /// </summary>
    /// <typeparam name="TRawCell">The raw cell type.</typeparam>
    /// <typeparam name="TVisualizedCell">The visualized cell type.</typeparam>
    public abstract class MemoryCellContainer<TRawCell, TVisualizedCell> : IEnumerable<TVisualizedCell>, IMemoryCellInfoProvider<TRawCell>, IMemoryCellDereferencer where TRawCell : struct
        where TVisualizedCell : MemoryCell<TRawCell> {
        private EventHandler<CellChangedEventArgs> _cellChangedEventHandler;
        private Memory<TRawCell> _relatedMemory;
        private readonly Dictionary<int, WeakReference> _visualizedCellReferences;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MemoryCellContainer{TRawCell,TVisualizedCell}" /> class.
        /// </summary>
        /// <param name="memory">The related memory instance.</param>
        protected MemoryCellContainer(Memory<TRawCell> memory) {
            //Throw error when parameter is null
            if (memory == null)
                throw new ArgumentNullException(nameof(memory));
            _relatedMemory = memory;
            _visualizedCellReferences = new Dictionary<int, WeakReference>(memory.Length);
            //Create and assign the event handler for the CellChangedEvent
            _cellChangedEventHandler = delegate(object sender, CellChangedEventArgs e) {
                lock (_visualizedCellReferences)
                {
                    if (!_visualizedCellReferences.ContainsKey(e.CellIndex)) return;
                    var cell = (TVisualizedCell) _visualizedCellReferences[e.CellIndex].Target;
                    if (cell == null) return;
                    cell.Value = RelatedMemory.GetCell(e.CellIndex);
                }
            };
            _relatedMemory.CellChanged += _cellChangedEventHandler;
        }

        /// <summary>
        ///     Occurs when the related memory instance has changed.
        /// </summary>
        public event EventHandler RelatedMemoryUpdated;

        /// <summary>
        ///     Gets or sets the related memory instance.
        /// </summary>
        public Memory<TRawCell> RelatedMemory {
            get { return _relatedMemory; }
            set {
                if (_relatedMemory == value) return;
                UpdateRelatedMemory(value);
            }
        }

        void IMemoryCellDereferencer.DereferenceCell(int index) {
            lock (_visualizedCellReferences)
            {
                // TODO: Check if ignoring an inexistent index can cause wrong disposing
                _visualizedCellReferences.Remove(index);
                //Debug.Print("cell:{0} removed!", index);
            }
        }

        public TVisualizedCell this[int index] {
            get {
                if (index < 0 || index >= _relatedMemory.Length)
                    throw new IndexOutOfRangeException(nameof(index));
                lock (_visualizedCellReferences)
                {
                    if (_visualizedCellReferences.ContainsKey(index))
                        return (TVisualizedCell) _visualizedCellReferences[index].Target;
                    TVisualizedCell cell = CreateVisualizedCellFrom(index);
                    _visualizedCellReferences.Add(index, new WeakReference(cell));
                    return cell;
                }
            }
        }

        protected virtual void UpdateRelatedMemory(Memory<TRawCell> newRelatedMemory) {
            //Unsubscribe the old's CellChanged event
            _relatedMemory.CellChanged -= _cellChangedEventHandler;
            _cellChangedEventHandler = delegate (object sender, CellChangedEventArgs e) {
                lock (_visualizedCellReferences) {
                    if (!_visualizedCellReferences.ContainsKey(e.CellIndex)) return;
                    var cell = (TVisualizedCell)_visualizedCellReferences[e.CellIndex].Target;
                    if (cell == null) return;
                    cell.Value = RelatedMemory.GetCell(e.CellIndex);
                }
            };
            //Assign the new memory and subscribe to its CellChanged event
            newRelatedMemory.CellChanged += _cellChangedEventHandler;
            _relatedMemory = newRelatedMemory;
            RelatedMemoryUpdated?.Invoke(this, EventArgs.Empty);
        }

        protected abstract TVisualizedCell CreateVisualizedCellFrom(int index);

        public IEnumerator<TVisualizedCell> GetEnumerator() => _relatedMemory.Select((cell, i) => CreateVisualizedCellFrom(i)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}