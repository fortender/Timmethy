// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MicroOperationCell.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using Timmethy.Core.Helpers;

namespace Timmethy.Core.Memory {
    /// <summary>
    ///     Contains the basic cell information for the micro program memory.
    /// </summary>
    [Serializable]
    public struct MicroOperationCell : ISerializable, IEquatable<MicroOperationCell> {
        /// <summary>
        ///     The specified <see cref="MicroOperation" /> value containing the instruction information
        /// </summary>
        public MicroOperation Operation { get; set; }

        /// <summary>
        ///     The optional macro name.
        ///     Is only set for the macro introduction cell (every tenth cell in micro code).
        /// </summary>
        public string MacroName { get; set; }

        public bool Equals(MicroOperationCell other) {
            return Operation.Equals(other.Operation) && MacroName == other.MacroName;
        }

        #region Serialization Support

        /// <summary>
        ///     Is called by the serializer to initialize a new instance of the <see cref="MicroOperationCell" /> struct by
        ///     forwarding
        ///     a <see cref="SerializationInfo" /> and a related <see cref="StreamingContext" />.
        ///     This is just needed for the deserialization process.
        /// </summary>
        /// <param name="info">A <see cref="SerializationInfo" /> object covering the deserialization information.</param>
        /// <param name="context">A <see cref="StreamingContext" /> containing the instruction set.</param>
        public MicroOperationCell(SerializationInfo info, StreamingContext context) {
            //Verify streaming context
            var instructionSet = context.Context as IEnumerable<MicroOperation>;
            if (instructionSet == null)
                throw new SerializationException(
                    "Context is either null or is not an ReadOnlyCollection<MicroOperation> containing the instruction set");
            //Read ID + MacroName and resolve the ID into its related instruction (MicroOperation)
            var operationId = info.GetValue<int>("operationId");
            Operation = instructionSet.ElementAt(operationId);
            MacroName = info.GetValue<string>("macroName");
        }

        /// <summary>
        ///     Is called by the serializer to serialize the <see cref="MicroOperationCell" /> instance by forwarding
        ///     a <see cref="SerializationInfo" /> object and a related <see cref="StreamingContext" /> (ignored here -> not
        ///     needed).
        ///     This is just needed for the serialization process.
        /// </summary>
        /// <param name="info">A <see cref="SerializationInfo" /> object covering the serialization information.</param>
        /// <param name="context">A <see cref="StreamingContext" /> containing the instruction set. (ignored here -> not needed)</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("operationId", Operation.Id);
            info.AddValue("macroName", MacroName);
        }


        #endregion
    }
}