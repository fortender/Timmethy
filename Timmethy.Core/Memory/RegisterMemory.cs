// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: RegisterMemory.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using Timmethy.Core.Helpers;
using Timmethy.Core.Register;
using Type = Timmethy.Core.Register.Type;

namespace Timmethy.Core.Memory {
    /// <summary>
    ///     Contains registers in form of integer cells and manages their values by the given
    ///     <see cref="Timmethy.Core.Register.Type" />.
    /// </summary>
    public class RegisterMemory : Memory<int> {
        private readonly int _dataValueMaximum;
        private readonly ValueRangeType[] _registerTypes;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegisterMemory" /> class.
        /// </summary>
        /// <param name="dataValueMax">The maximum value for the data <see cref="ValueRangeType" />.</param>
        /// <param name="regTypes">
        ///     A list of <see cref="ValueRangeType" /> needed for the <see cref="RegisterMemory" /> to clip the
        ///     cell value correctly.
        /// </param>
        public RegisterMemory(int dataValueMax, ValueRangeType[] regTypes) : base(regTypes.Length) {
            if (regTypes == null) throw new ArgumentNullException(nameof(regTypes));
            if (dataValueMax < 0) throw new ArgumentException(nameof(dataValueMax));
            _dataValueMaximum = dataValueMax;
            _registerTypes = regTypes;
        }

        public int this[Type index] {
            get { return GetCell(index); }
            set { SetCell(index, value); }
        }

        /// <summary>
        ///     Sets the cell with the specified index to a specific value.
        /// </summary>
        /// <param name="index">The index of the cell to set.</param>
        /// <param name="cell">The new cell value. It is clipped to the specified <see cref="ValueRangeType" />.</param>
        public override void SetCell(int index, int cell) {
            int max = _registerTypes[index] == ValueRangeType.Address ? 999 : _dataValueMaximum;
            base.SetCell(index, cell.ClipIn(0, max));
        }

        /// <summary>
        ///     Overloads the <see cref="SetCell(int,int)" /> method in order to support indexing via the
        ///     <see cref="Timmethy.Core.Register.Type" /> enumeration.
        /// </summary>
        public void SetCell(Type index, int cell) {
            SetCell((int) index, cell);
        }

        /// <summary>
        ///     Overloads the <see cref="GetCell" /> method in order to support indexing via the
        ///     <see cref="Timmethy.Core.Register.Type" /> enumeration.
        /// </summary>
        /// <returns>The cell belonging to the specified index</returns>
        public int GetCell(Type index) => GetCell((int) index);
    }
}