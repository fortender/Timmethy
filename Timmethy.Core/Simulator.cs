// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: Simulator.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Timmethy.Core.Configuration;
using Timmethy.Core.Helpers;
using Timmethy.Core.Memory;
using Timmethy.Core.Memory.VisualizedCell;
using Timmethy.Core.Register;
using static Timmethy.Core.Register.Type;

namespace Timmethy.Core {
    /// <summary>
    ///     Creates, provides and manages all necessairy components.
    /// </summary>
    public class Simulator : PropertyChangedNotifier {
        private Memory<MicroOperationCell> _microProgramMemory;
        private ClippedIntegerMemory _randomAccessMemory;
        private SimulatorMode _simulatorMode;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Simulator" /> class.
        /// </summary>
        /// <param name="macroAmount"></param>
        public Simulator(int macroAmount) {
            InitializeInstructionSet();
            InitializeUnits(macroAmount);
        }

        public SimulatorMode Mode {
            get { return _simulatorMode; }
            set {
                if (_simulatorMode == value) return;
                _simulatorMode = value;
                OnSimulatorModeChanged(new SimulatorModeChangedEventArgs(value));
            }
        }

        /// <summary>
        ///     Returns a read-only collection of the instruction set containing all <see cref="MicroOperation" /> values.
        /// </summary>
        public ReadOnlyCollection<MicroOperation> InstructionSet { private set; get; }

        /// <summary>
        ///     Gets or sets the <see cref="MicroProgramMemory" /> which contains the micro code.
        /// </summary>
        public Memory<MicroOperationCell> MicroProgramMemory {
            get { return _microProgramMemory; }
            set {
                //Only update related memory if it is a "new" one
                if (_microProgramMemory == value) return;
                _microProgramMemory = value;
                VisualizedMicroProgramMemory.RelatedMemory = value;
                VisualizedRandomAccessMemory.RelatedMicroProgramMemory = value;
            }
        }

        /// <summary>
        ///     Gets or sets the <see cref="ClippedIntegerMemory" /> which contains the macro code.
        /// </summary>
        public ClippedIntegerMemory RandomAccessMemory {
            get { return _randomAccessMemory; }
            set {
                //Only update related memory if it is a "new" one
                if (_randomAccessMemory == value) return;
                _randomAccessMemory = value;
                VisualizedRandomAccessMemory.RelatedMemory = value;
            }
        }

        /// <summary>
        ///     Gets the <see cref="MicroProgramMemoryCellContainer" /> which acts as a visualizer for the
        ///     <see cref="MicroProgramMemory" />.
        ///     It enables you to setup a bi-directional databinding so that the UI gets notified when something has changed.
        /// </summary>
        public MicroProgramMemoryCellContainer VisualizedMicroProgramMemory { private set; get; }

        /// <summary>
        ///     Gets the <see cref="RandomAccessMemoryCellContainer" /> which acts as a visualizer for the
        ///     <see cref="RandomAccessMemory" />.
        ///     It enables you to setup a bi-directional databinding so that the UI gets notified when something has changed.
        /// </summary>
        public RandomAccessMemoryCellContainer VisualizedRandomAccessMemory { private set; get; }

        /// <summary>
        ///     Gets the <see cref="RegisterMemory" /> which contains and manages all register values.
        ///     Each register acts as exactly one cell in the <see cref="RegisterMemory" /> and its value is managed by the given
        ///     <see cref="ValueRangeType" />.
        /// </summary>
        public RegisterMemory Registers { private set; get; }

        /// <summary>
        ///     Gets the <see cref="HighLowValueCellContainer" /> which acts as a visualizer for the <see cref="RegisterMemory" />.
        ///     It enables you to setup a bi-directional databinding so that the UI gets notified when a register's value has
        ///     changed.
        /// </summary>
        public HighLowValueCellContainer VisualizedRegisters { private set; get; }

        /// <summary>
        ///     Initializes all necessairy simulator units.
        /// </summary>
        /// <param name="macroAmount">Maximum amount of macros</param>
        private void InitializeUnits(int macroAmount) {
            int dataValueMax = (macroAmount-1)*1000 + 999;
            _simulatorMode = SimulatorMode.Johnny;
            _microProgramMemory = new Memory<MicroOperationCell>(macroAmount*10);
            _randomAccessMemory = new ClippedIntegerMemory(1000, dataValueMax);
            VisualizedMicroProgramMemory = new MicroProgramMemoryCellContainer(MicroProgramMemory, InstructionSet);
            VisualizedRandomAccessMemory = new RandomAccessMemoryCellContainer(RandomAccessMemory, _microProgramMemory);
            Registers = new RegisterMemory(dataValueMax,
                new[] {
                    ValueRangeType.Address, //AddressBus
                    ValueRangeType.Data, //DataBus
                    ValueRangeType.Data, //InstructionRegister
                    ValueRangeType.Address, //ProgramCounter
                    ValueRangeType.Address, //BasisRegister
                    ValueRangeType.Data //Accumulator
                });
            VisualizedRegisters = new HighLowValueCellContainer(Registers);
        }

        /// <summary>
        ///     Defines and initializes the instruction set.
        /// </summary>
        private void InitializeInstructionSet() {
            var ops = new List<MicroOperation>();
            ops.AddInstruction("", null);
            ops.AddInstruction("db->ram", () => RandomAccessMemory[Registers[AB]] = Registers[DB]);
            ops.AddInstruction("ram->db", () => Registers[DB] = RandomAccessMemory[Registers[AB]]);
            ops.AddInstruction("db->ins", () => Registers[IR] = Registers[DB]);
            ops.AddInstruction("ins->ab", () => Registers[AB] = Registers[IR].GetLoCode());
            ops.AddInstruction("ins->mc",
                () => VisualizedMicroProgramMemory.Executer.Position = VisualizedRegisters[(int) IR].Hi*10);
            //
            ops.AddInstruction("mc:=0", () => VisualizedMicroProgramMemory.Executer.Position = 0);
            ops.AddInstruction("pc->ab", () => Registers[AB] = Registers[PC]);
            ops.AddInstruction("pc++", () => Registers[PC]++);
            ops.AddInstruction("=0:pc++", () => Registers[PC] = Registers[ACC] == 0 ? Registers[PC] + 1 : Registers[PC]);
            ops.AddInstruction("ins->pc", () => Registers[PC] = Registers[IR].GetLoCode());
            ops.AddInstruction("acc:=0", () => Registers[ACC] = 0);
            ops.AddInstruction("plus", () => Registers[ACC] += Registers[DB]);
            ops.AddInstruction("minus", () => Registers[ACC] -= Registers[DB]);
            ops.AddInstruction("acc->db", () => Registers[DB] = Registers[ACC]);
            ops.AddInstruction("acc++", () => Registers[ACC]++);
            ops.AddInstruction("acc--", () => Registers[ACC]--);
            ops.AddInstruction("db->acc", () => Registers[ACC] = Registers[DB]);
            ops.AddInstruction("stop", () => VisualizedMicroProgramMemory.Executer.StopProgram());
            ops.AddInstruction("ins+pc", () => Registers[PC] += Registers[IR].GetLoCode());
            ops.AddInstruction("db->br", () => Registers[BR] = Registers[DB].GetLoCode());
            ops.AddInstruction("ins->acc", () => Registers[ACC] = Registers[IR].GetLoCode());
            ops.AddInstruction("br-db->db", () => Registers[DB] = Registers[BR] - Registers[DB].GetLoCode());
            InstructionSet = new ReadOnlyCollection<MicroOperation>(ops);
        }

        #region SimulatorModeChanged Support

        /// <summary>
        ///     Occurs when the <see cref="Mode" /> has changed
        /// </summary>
        public event EventHandler<SimulatorModeChangedEventArgs> SimulatorModeChanged;

        protected virtual void OnSimulatorModeChanged(SimulatorModeChangedEventArgs e) {
            SimulatorModeChanged?.Invoke(this, e);
        }

        #endregion
    }

    /// <summary>
    ///     Extends the <see cref="List{T}" /> by an <see cref="AddInstruction" /> method to reduce code in the instruction set
    ///     initializer function."/>
    /// </summary>
    public static class InstructionListExtension {
        /// <summary>
        ///     Assigns the internal id automatically and adds the specified instruction to the list
        /// </summary>
        /// <param name="list">List of MicroOperation</param>
        /// <param name="instructionName">Instruction identifier name</param>
        /// <param name="microAction">Method capsulation of the micro action</param>
        public static void AddInstruction(this List<MicroOperation> list, string instructionName, Action microAction) {
            list.Add(new MicroOperation(list.Count == 0 ? 0 : list.Count, instructionName, microAction));
        }
    }
}