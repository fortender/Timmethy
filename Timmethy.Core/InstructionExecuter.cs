// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: InstructionExecuter.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Timers;
using Timmethy.Core.Helpers;
using Timmethy.Core.Memory;
using Timmethy.Core.Memory.VisualizedCell;

namespace Timmethy.Core {
    /// <summary>
    ///     Provides execution support for instructions, macros and program(s).
    /// </summary>
    public class InstructionExecuter : PropertyChangedNotifier {
        private readonly IMemoryCellInfoProvider<MicroOperationCell> _cellContainer;
        private readonly object _lockObj = new object();
        private int _position;

        /// <summary>
        ///     Initializes a new instance of the <see cref="InstructionExecuter" /> class.
        /// </summary>
        /// <param name="cellContainer"></param>
        public InstructionExecuter(IMemoryCellInfoProvider<MicroOperationCell> cellContainer) {
            if (cellContainer == null)
                throw new ArgumentNullException(nameof(cellContainer));
            _cellContainer = cellContainer;
        }

        /// <summary>
        ///     Points at the current micro program memory cell/instruction.
        /// </summary>
        public int Position {
            get { return _position; }
            set {
                int clipped = value.ClipIn(0, _cellContainer.RelatedMemory.Length);
                if (_position == clipped) return;
                _position = clipped;
                OnPositionChanged();
            }
        }

        /// <summary>
        ///     Current MicroOperationCell reference pointed at.
        /// </summary>
        public MicroOperationCell Current => _cellContainer.RelatedMemory.GetCell(Position);

        /// <summary>
        ///     Executes the instruction currently pointed at.
        /// </summary>
        public void ExecuteCurrent() {
            lock (_lockObj)
            {
                //If the instruction does not perform a jump itself update position
                //example: instructions such as ins->mc and mc:=0 perform jumps themselves
                //=> there is no need to update (increment) the position
                int tempPos = Position;
                Current.Operation.MicroAction?.Invoke();
                if (Position == tempPos) Position++;
                else OnMacroExecuted(); //raising MacroExecuted event when a whole macro was executed
                OnInstructionExecuted();
            }
        }

        /// <summary>
        ///     Executes a whole macro.
        /// </summary>
        public void ExecuteMacro() {
            lock (_lockObj)
            {
                ExecuteCurrent();
                while (Position != 0)
                    ExecuteCurrent();
                OnMacroExecuted(); //obsolete/not needed anymore
            }
        }

        #region PositionChanged Support

        /// <summary>
        ///     Raises the PropertyChanged event for the Position property.
        ///     Is called by the Position-setter method when position has changed.
        /// </summary>
        protected virtual void OnPositionChanged() {
            RaisePropertyChanged(nameof(Position), nameof(Current));
        }

        #endregion

        #region Program Execution

        /// <summary>
        ///     Wraps a timer to enable the wanted macro execution delay.
        /// </summary>
        private static class ProgramExecutionTimer {
            private static Timer _executionTimer;

            /// <summary>
            ///     Gets or sets the macro execution interval.
            /// </summary>
            public static double Interval {
                get { return _executionTimer.Interval; }
                set { _executionTimer.Interval = value; }
            }

            /// <summary>
            ///     Starts the program execution.
            /// </summary>
            /// <param name="instructionExecuter">The instruction executer instance.</param>
            /// <param name="interval">The macro execution interval.</param>
            /// <param name="synchronizingObject">The object that the timer is synchronizing with.</param>
            public static void Start(InstructionExecuter instructionExecuter, int interval,
                ISynchronizeInvoke synchronizingObject) {
                _executionTimer = new Timer {
                    SynchronizingObject = synchronizingObject,
                    Interval = interval
                };
                _executionTimer.Elapsed += (sender, e) => instructionExecuter.ExecuteMacro();
                _executionTimer.Start();
            }

            /// <summary>
            ///     Stops the program execution.
            /// </summary>
            public static void Stop() {
                if (_executionTimer == null) return;
                _executionTimer.Stop();
                _executionTimer.Dispose();
            }
        }

        public void StartProgram(int interval, ISynchronizeInvoke synchronizingObject) {
            if (IsExecutingProgram) return;
            ProgramExecutionTimer.Start(this, interval, synchronizingObject);
            IsExecutingProgram = true;
        }

        public void StopProgram() {
            if (!IsExecutingProgram) return;
            ProgramExecutionTimer.Stop();
            IsExecutingProgram = false;
        }

        public void ChangeMacroExecutionInterval(int interval) {
            ProgramExecutionTimer.Interval = interval;
        }

        public bool IsExecutingProgram { private set; get; }

        #endregion

        #region InstructionExecuted Support

        /// <summary>
        ///     Occurs when a instruction was executed.
        /// </summary>
        public event EventHandler InstructionExecuted;

        /// <summary>
        ///     Raises the InstructionExecuted event
        /// </summary>
        protected virtual void OnInstructionExecuted() {
            InstructionExecuted?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region MacroExecuted Support

        /// <summary>
        ///     Occurs when a macro was executed.
        /// </summary>
        public event EventHandler MacroExecuted;

        /// <summary>
        ///     Raises the MacroExecuted event.
        /// </summary>
        protected virtual void OnMacroExecuted() {
            MacroExecuted?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}