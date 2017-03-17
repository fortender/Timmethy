// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: ValueRangeType.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

namespace Timmethy.Core.Register {
    /// <summary>
    ///     Currently there are two types of registers. One for address values and one for data values.
    ///     Address value range is different from the data value range so this enumeration is introduced
    ///     to identify the specific register's range type.
    /// </summary>
    public enum ValueRangeType {
        Address,
        Data
    }
}