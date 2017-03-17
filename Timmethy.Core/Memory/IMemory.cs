// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: IMemory.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Timmethy.Core.Memory {
    public interface IMemory : IEnumerable {
        int Length { get; }
        long LongLength { get; }
        event EventHandler<CellChangedEventArgs> CellChanged;
    }

    public interface IMemory<T> : IMemory, IEnumerable<T> where T : struct {
        void SetCell(int index, T cell);
        T GetCell(int index);
    }
}