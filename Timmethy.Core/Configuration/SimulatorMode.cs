// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: SimulatorMode.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

#region FileHeader

#if false
-----------------------------------------------------------------------
Purpose:
SimulatorMode enumeration covers all modes the simulator can simulate.
The modes differ in their instruction set (micro actions).
-----------------------------------------------------------------------
#endif
//Usings
using System.ComponentModel;

#endregion

namespace Timmethy.Core.Configuration {
    /// <summary>
    ///     Defines an enumeration covering all modes the <see cref="Simulator" /> can simulate
    /// </summary>
    public enum SimulatorMode {
        [Description("Minimal Instruction Set")] Bonsai,
        [Description("Normal Instruction Set")] Johnny,
        [Description("Extended Instruction Set")] Timmethy
    }
}