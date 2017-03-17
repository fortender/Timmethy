// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MicroOperation.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core {
    /// <summary>
    ///     Covers data to describe and execute an instruction (<see cref="MicroOperation" />)
    /// </summary>
    public struct MicroOperation : IEquatable<MicroOperation> {
        public MicroOperation(int id, string name, Action microAction) {
            Id = id;
            Name = name;
            MicroAction = microAction;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Action MicroAction { get; set; }

        public bool Equals(MicroOperation other) {
            return Id == other.Id;
        }
    }
}