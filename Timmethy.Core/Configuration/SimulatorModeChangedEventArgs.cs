// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: SimulatorModeChangedEventArgs.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;

namespace Timmethy.Core.Configuration {
    public class SimulatorModeChangedEventArgs : EventArgs {
        /// <summary>
        ///     Creates a SimulatorModeChangedEventArgs object covering the changed simulator mode
        /// </summary>
        /// <param name="mode">Updated simulator mode</param>
        public SimulatorModeChangedEventArgs(SimulatorMode mode) {
            SimulatorMode = mode;
        }

        public SimulatorMode SimulatorMode { private set; get; }
    }
}