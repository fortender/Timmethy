// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: RandomAccessMemoryCellContainer.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Memory.VisualizedCell {
    /// <summary>
    ///     Creates the visualizer random access memory cells from a given <see cref="ClippedIntegerMemory" />
    ///     instance and provides important information for them.
    /// </summary>
    public class RandomAccessMemoryCellContainer : MemoryCellContainer<int, RandomAccessMemoryCell>,
        IRandomAccessMemoryCellInfoProvider {
        private Memory<MicroOperationCell> _relatedMicroProgramMemory;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RandomAccessMemoryCellContainer" /> class.
        /// </summary>
        /// <param name="memory">The related memory instance.</param>
        /// <param name="relatedMicroProgramMemory">The related micro program memory instance.</param>
        public RandomAccessMemoryCellContainer(ClippedIntegerMemory memory,
            Memory<MicroOperationCell> relatedMicroProgramMemory) : base(memory) {
            _relatedMicroProgramMemory = relatedMicroProgramMemory;
        }

        /// <summary>
        ///     Gets or sets the related micro program memory instance.
        /// </summary>
        public Memory<MicroOperationCell> RelatedMicroProgramMemory {
            get { return _relatedMicroProgramMemory; }
            set {
                if (_relatedMicroProgramMemory == value) return;
                _relatedMicroProgramMemory = value;
                OnRelatedMicroProgramMemoryChanged();
            }
        }

        #region RelatedMicroProgramMemoryChanged Event

        public event EventHandler RelatedMicroProgramMemoryChanged;

        protected virtual void OnRelatedMicroProgramMemoryChanged() {
            RelatedMicroProgramMemoryChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        protected override RandomAccessMemoryCell CreateVisualizedCellFrom(int index) {
            return new RandomAccessMemoryCell(this, index);
        }
    }
}