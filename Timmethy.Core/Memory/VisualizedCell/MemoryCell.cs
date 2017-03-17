// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MemoryCell.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     This is the base for all visualizer cell types which cover extra information that has to be
    ///     displayed by a <see cref="System.Windows.Forms.DataGridView" /> for instance.
    /// </summary>
    /// <typeparam name="T">The specified cell type</typeparam>
    [Serializable]
    public class MemoryCell<T> : PropertyChangedNotifier where T : struct {
        private T? _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MemoryCell{T}" /> class.
        /// </summary>
        /// <param name="cellContainer">A cell container which contains this cell.</param>
        /// <param name="cellIndex">The index of the specific cell to visualize.</param>
        public MemoryCell(IMemoryCellInfoProvider<T> cellContainer, int cellIndex) {
            //Throw error when cellContainer is null
            if (cellContainer == null)
                throw new ArgumentNullException(nameof(cellContainer));
            //Assign CellContainer and Address properties
            CellContainer = new WeakReference(cellContainer);
            //Subscribe RelatedMemoryUpdated event -> reset value
            cellContainer.RelatedMemoryUpdated += (sender, e) => _value = null;
            Address = cellIndex;
        }

        protected WeakReference CellContainer { get; }

        /// <summary>
        ///     Gets the cell's address
        /// </summary>
        public int Address { get; }

        /// <summary>
        ///     Gets or sets the cell value.
        /// </summary>
        public T Value {
            get {
                if (_value != null) return _value.Value;
                var container = (IMemoryCellInfoProvider<T>)CellContainer.Target;
                if (container == null) return default(T);
                _value = container.RelatedMemory.GetCell(Address);
                return _value.Value;
            }
            set {
                if (_value.Equals(value)) return;
                var container = (IMemoryCellInfoProvider<T>)CellContainer.Target;
                T cellValue = container?.RelatedMemory.GetCell(Address) ?? default(T);
                if (cellValue.Equals(value))
                {
                    _value = cellValue;
                    OnValueChanged();
                }
                container?.RelatedMemory.SetCell(Address, value);
            }
        }

        ~MemoryCell() {
            var container = (IMemoryCellDereferencer)CellContainer.Target;
            container?.DereferenceCell(Address);
        }

        #region ValueChanged Support

        protected virtual void OnValueChanged() {
            RaisePropertyChanged(nameof(Value));
        }

        #endregion
    }
}