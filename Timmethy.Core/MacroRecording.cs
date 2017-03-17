// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: MacroRecording.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using Timmethy.Core.Memory;

namespace Timmethy.Core {
    /// <summary>
    ///     Initiates and manages the recording of new macros.
    /// </summary>
    public class MacroRecorder {
        private readonly Simulator _simulator;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MacroRecorder" /> class.
        /// </summary>
        /// <param name="simulator"></param>
        public MacroRecorder(Simulator simulator) {
            _simulator = simulator;
        }

        /// <summary>
        ///     Gets the recording status
        /// </summary>
        public bool IsRecording { private set; get; }

        /// <summary>
        ///     Gets the current <see cref="MacroRecording" /> object.
        /// </summary>
        public MacroRecording Current { private set; get; }

        /// <summary>
        ///     Starts a new macro recording.
        /// </summary>
        /// <param name="id">Macro identifier (usually cell index / 10)</param>
        /// <param name="name">Macro name</param>
        /// <exception cref="Exception"></exception>
        public void Record(int id, string name) {
            if (IsRecording)
                throw new Exception("Is already recording");
            Current = new MacroRecording(_simulator, id, name);
            IsRecording = true;
            if (_redirectingEventHandlers.Count < 1) return;
            foreach (EventHandler handler in _redirectingEventHandlers)
                Current.PositionChanged += handler;
        }

        /// <summary>
        ///     Stops the current recording.
        /// </summary>
        public void Stop() {
            if (!IsRecording) return;
            IsRecording = false;
            Current.Dispose();
            Current = null;
        }

        #region RecordingPositionChanged Support

        private List<EventHandler> _redirectingEventHandlers;

        /// <summary>
        ///     Occurs when the current recording position has changed
        /// </summary>
        public event EventHandler RecordingPositionChanged {
            add {
                if (_redirectingEventHandlers == null)
                    _redirectingEventHandlers = new List<EventHandler>();
                if (IsRecording)
                    Current.PositionChanged += value;
                else
                    _redirectingEventHandlers.Add(value);
            }
            remove {
                if (IsRecording)
                    Current.PositionChanged -= value;
                _redirectingEventHandlers.Remove(value);
            }
        }

        #endregion
    }

    /// <summary>
    ///     Provides information of the macro recording and methods to record the macro.
    /// </summary>
    public class MacroRecording : IDisposable {
        private readonly int _macroId;
        private readonly string _macroName;
        private readonly Simulator _simulator;
        private int _position;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MacroRecording" /> class.
        /// </summary>
        /// <param name="simulator">The related <see cref="Simulator" /> instance</param>
        /// <param name="macroId">The starting cell related macro Id</param>
        /// <param name="macroName">The name of the new macro</param>
        public MacroRecording(Simulator simulator, int macroId, string macroName) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            _simulator = simulator;
            _macroId = macroId;
            Position = macroId;
            _macroName = macroName;
            Delete(simulator, macroId);
            simulator.MicroProgramMemory.SetCell(macroId,
                new MicroOperationCell {
                    MacroName = macroName
                });
        }

        /// <summary>
        ///     Gets the current recording position.
        /// </summary>
        public int Position {
            get { return _position; }
            private set {
                if (Position >= 0 && Position < _simulator.MicroProgramMemory.Length - 1)
                {
                    _position = value;
                    OnPositionChanged();
                }
            }
        }

        /// <summary>
        ///     Places a specified <see cref="MicroOperation" /> at the current recording position.
        /// </summary>
        /// <param name="operation">The <see cref="MicroOperation" /> that has to be placed</param>
        public void PlaceCell(MicroOperation operation) {
            string name = Position == _macroId ? _macroName : null;
            Memory<MicroOperationCell> mpm = _simulator.MicroProgramMemory;
            if (Position >= mpm.Length)
                throw new IndexOutOfRangeException(nameof(Position));
            mpm.SetCell(Position++, new MicroOperationCell {MacroName = name, Operation = operation});
        }

        /// <summary>
        ///     Deletes a specified macro.
        /// </summary>
        /// <param name="simulator">The related <see cref="Simulator" /> instance</param>
        /// <param name="macroId">The macro identifier</param>
        public static void Delete(Simulator simulator, int macroId) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            Memory<MicroOperationCell> mpm = simulator.MicroProgramMemory;
            mpm.SetCell(macroId++, new MicroOperationCell());
            for (; macroId < mpm.Length - 1 && string.IsNullOrEmpty(mpm.GetCell(macroId).MacroName); macroId++)
                mpm.SetCell(macroId, new MicroOperationCell());
        }

        public static bool Exists(Simulator simulator, int macroId) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            return !simulator.MicroProgramMemory.GetCell(macroId).Equals(default(MicroOperationCell));
        }

        #region PositionChanged Support

        /// <summary>
        ///     Occurs when the recording position has changed.
        /// </summary>
        public event EventHandler PositionChanged;

        protected virtual void OnPositionChanged() {
            PositionChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region IDisposable Support

        private bool _disposed;

        protected virtual void Dispose(bool disposing) {
            if (!_disposed)
            {
                if (disposing)
                {
                    Delegate[] invocationList = PositionChanged?.GetInvocationList();
                    if (invocationList != null)
                        foreach (Delegate handler in invocationList)
                            PositionChanged -= handler as EventHandler;
                }
                _disposed = true;
            }
        }

        /// <summary>
        ///     Releases all resources of this <see cref="MacroRecording" /> object.
        /// </summary>
        public void Dispose() {
            Dispose(true);
        }

        #endregion
    }
}