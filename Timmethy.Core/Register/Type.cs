// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: Type.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

namespace Timmethy.Core.Register {
    /// <summary>
    ///     Covers all register identifiers for the registers that are currently included into the <see cref="Simulator" />.
    /// </summary>
    public enum Type {
        AB,
        DB,
        IR,
        PC,
        BR,
        ACC
    }
}