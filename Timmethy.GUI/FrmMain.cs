// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: frmMain.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Timmethy.Core;
using Timmethy.Core.Configuration;
using Timmethy.Core.Helpers;
using Timmethy.Core.Memory;
using Timmethy.Core.Memory.VisualizedCell;
using Timmethy.GUI.Properties;
using static Timmethy.Core.Register.Type;
using Type = Timmethy.Core.Register.Type;

namespace Timmethy.GUI {
    /// <summary>
    ///     Contains all necessairy event handlers for the User Interface.
    /// </summary>
    public partial class FrmMain : Form {
        private readonly MacroRecorder _recorder;
        private readonly Simulator _simulator;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FrmMain" /> class.
        /// </summary>
        public FrmMain() {
            InitializeComponent();
            dgvMicroCode.VirtualMode = true;
            dgvMacroCode.VirtualMode = true;
            cbShowControlUnit.Checked = false;
            IsAccZero = true;
            _simulator = new Simulator(20) {Mode = SimulatorMode.Johnny};
            _recorder = new MacroRecorder(_simulator);
            dgvMicroCode.RowCount = _simulator.MicroProgramMemory.Length;
            dgvMacroCode.RowCount = _simulator.RandomAccessMemory.Length;
            SubscribeSimulatorEvents();
            EstablishBindings();
            ManualChanges();
        }

        private void FrmMain_Shown(object s, EventArgs args) {
            dgvMicroCode.CellValueNeeded += delegate (object sender, DataGridViewCellValueEventArgs e) {
                MicroProgramMemoryCell cell = _simulator.VisualizedMicroProgramMemory[e.RowIndex];
                switch (e.ColumnIndex) {
                    case 0:
                        e.Value = cell.Address;
                        break;
                    case 1:
                        e.Value = cell.MacroName;
                        break;
                    case 2:
                        e.Value = cell.InstructionName;
                        break;
                }
            };

            dgvMacroCode.CellValueNeeded += delegate (object sender, DataGridViewCellValueEventArgs e) {
                RandomAccessMemoryCell cell = _simulator.VisualizedRandomAccessMemory[e.RowIndex];
                switch (e.ColumnIndex) {
                    case 0:
                        e.Value = cell.Address;
                        break;
                    case 1:
                        e.Value = cell.Hi;
                        break;
                    case 2:
                        e.Value = cell.Lo;
                        break;
                    case 3:
                        e.Value = cell.MacroName;
                        break;
                    case 4:
                        e.Value = cell.Operand;
                        break;
                }
            };

            //_simulator.MicroProgramMemory.CellChanged += (sender, e) => dgvMicroCode.InvalidateRow(e.CellIndex);
        }

        #region Persistence Support

        /// <summary>
        ///     Is called when any button with file saving/loading purposes is pressed.
        /// </summary>
        private void SaveLoadUnitButton_Click(object sender, EventArgs e) {
            // Check if it shall be a loading or saving operation
            bool load = new[] {btnLoadProject, btnLoadMacroCode, btnLoadMicroCode}.Any(c => sender == c);
            PersistenceFileMode mode = load ? PersistenceFileMode.Load : PersistenceFileMode.Save;
            string fdFilter;
            // Match the 
            PersistenceFileType fileType;
            if (sender == btnLoadMicroCode || sender == btnSaveMicroCode)
                fileType = PersistenceFileType.MicroCode;
            else if (sender == btnLoadMacroCode || sender == btnSaveMacroCode)
                fileType = PersistenceFileType.MacroCode;
            else if (sender == btnLoadProject || sender == btnSaveProject)
                fileType = PersistenceFileType.Project;
            else
                throw new ArgumentException(nameof(sender));

            switch (fileType)
            {
                case PersistenceFileType.MicroCode:
                    fdFilter = Resources.FileDialogFilterStringMicroCodeFile;
                    break;
                case PersistenceFileType.MacroCode:
                    fdFilter = Resources.FileDialogFilterStringMacroCodeFile;
                    break;
                case PersistenceFileType.Project:
                    fdFilter = Resources.FileDialogFilterStringProjectFile;
                    break;
                default:
                    fdFilter = @"All files (*.*)|*.*";
                    break;
            }
            using (FileDialog fd = load ? (FileDialog) new OpenFileDialog() : new SaveFileDialog())
            {
                fd.CustomPlaces.Add(Application.StartupPath);
                fd.Filter = fdFilter;
                fd.Title = $@"{(load ? "Load" : "Save")} {fileType}";

                if (fd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    PersistenceHelper.SaveLoadUnit(_simulator, new FileInfo(fd.FileName), fileType, mode);
                    if (load) dgvMacroCode.Invalidate();
                    MessageBox.Show(this,
                        $@"{fileType} file {(load ? "loaded" : "saved")} successfully!",
                        $@"File {(load ? "Loaded" : "Saved")}",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(this,
                        string.Format(Resources.MessageBoxTextUnauthorizedFileAccess, load ? "load" : "save"),
                        nameof(UnauthorizedAccessException),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(this,
                        load
                            ? Resources.MessageBoxTextSerializationErrorOnLoad
                            : string.Format(Resources.MessageBoxTextSerializationErrorOnSave, ex.Message, ex.StackTrace),
                        nameof(SerializationException),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Misc

        /// <summary>
        ///     Launches the settings dialog.
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e) {
            using (var settingsDialog = new FrmSettings(_simulator.Mode))
            {
                if (settingsDialog.ShowDialog() == DialogResult.OK)
                    _simulator.Mode = settingsDialog.SelectedMode;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            InstructionExecuter executer = _simulator.VisualizedMicroProgramMemory.Executer;
            if (executer.IsExecutingProgram)
            {
                executer.StopProgram();
                if (MessageBox.Show(this,
                        Resources.MessageBoxTextAbortPendingExecution,
                        @"Execution Pending",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.No)
                {
                    btnRunMacros_Click(null, EventArgs.Empty);
                    e.Cancel = true;
                    return;
                }
            }
            if (
                MessageBox.Show(this,
                    Resources.MessageBoxTextSaveProjectBeforeQuitting,
                    @"Save Project?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                return;
            SaveLoadUnitButton_Click(btnSaveProject, EventArgs.Empty);
        }

        #endregion

        #region Visualization

        /// <summary>
        ///     Creates all data bindings to display and visualize the components' values.
        ///     Bidirectional data binding will enable updating the controls' captions automatically.
        /// </summary>
        private void EstablishBindings() {
            lblAddressBusValue.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) AB],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "000");
            lblDataBusValue.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) DB],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "00 000");
            lblRAMCell.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) AB],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "000");
            //this.lblRAMCellValue.DataBindings.Add("Text", this.simulator.RAM.Current, "Value", true, DataSourceUpdateMode.OnPropertyChanged, null, "00 000");
            lblInsRegHiCode.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) IR],
                "Hi",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "00");
            lblInsRegLoCode.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) IR],
                "Lo",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "000");
            lblMCCell.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) IR],
                "Hi",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "00");
            //this.lblMCCurrent.DataBindings.Add("Text", this.simulator.MC.po, "Position", true, DataSourceUpdateMode.OnPropertyChanged);
            //this.lblMCCurrentCmd.DataBindings.Add("Text", this.simulator.MC, "Current");
            lblProgramCounter.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) PC],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "000");
            lblAccumulator.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) ACC],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "00 000");
            lblBasisReg.DataBindings.Add("Text",
                _simulator.VisualizedRegisters[(int) BR],
                "Value",
                true,
                DataSourceUpdateMode.OnPropertyChanged,
                null,
                "000");
        }

        /// <summary>
        ///     Subscribes to the <see cref="Simulator" />'s events in order to establish the connection between Core and UI.
        /// </summary>
        private void SubscribeSimulatorEvents() {
            _simulator.SimulatorModeChanged += _simulator_SimulatorModeChanged;
            //
            _simulator.VisualizedMicroProgramMemory.Executer.InstructionExecuted +=
                (sender, e) =>
                        dgvMicroCode.SelectAndScrollTo(_simulator.VisualizedMicroProgramMemory.Executer.Position);
            //
            _simulator.VisualizedMicroProgramMemory.Executer.MacroExecuted +=
                (sender, e) => dgvMacroCode.Rows[_simulator.Registers[PC]].Selected = true;
            //
            _simulator.Registers.CellChanged += delegate(object sender, CellChangedEventArgs e) {
                switch ((Type) e.CellIndex)
                {
                    case AB:
                        dgvMacroCode.Rows[_simulator.Registers[AB]].Selected = true;
                        break;
                    case ACC:
                        IsAccZero = _simulator.Registers[ACC] == 0;
                        break;
                    case DB:
                        break;
                    case IR:
                        break;
                    case PC:
                        break;
                    case BR:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            };
            //
            _recorder.RecordingPositionChanged +=
                (sender, e) => dgvMicroCode.SelectAndScrollTo(_recorder.Current.Position);
        }

        /// <summary>
        ///     Is called when the mode of the <see cref="Simulator" /> has changed.
        ///     Updates the UI and hides unaccessible controls.
        /// </summary>
        private void _simulator_SimulatorModeChanged(object sender, SimulatorModeChangedEventArgs e) {
            var hideables = new Control[] {
                btnResetAccumulator, btnAddDataBusToAccumulator, btnSubtractDataBusFromAccumulator, btnDataBusToBasisReg,
                btnBasisRegMinusDataBusToDataBus, lblBasisReg, btnInsRegPlusProgramCounter, btnInsRegToAccumulator
            };
            IEnumerable<Control> controlUnitControls =
                mainPanel.Controls.Cast<Control>().Where(c => new Rectangle(340, 85, 385, 490).Contains(c.Location));
            IEnumerable<Control> controlsToHide;
            switch (e.SimulatorMode)
            {
                case SimulatorMode.Bonsai:
                    if (cbShowControlUnit.Checked)
                        mainPanel.BackgroundImage = Resources.timmethypanelbg;
                    controlsToHide = hideables;
                    btnInsRegToProgramCounter.Location = new Point(528, 208);
                    btnResetMicroCodePointer.Location = new Point(594, 499);
                    btnStopProgramExecution.Location = new Point(594, 533);
                    break;
                case SimulatorMode.Johnny:
                    if (cbShowControlUnit.Checked)
                        mainPanel.BackgroundImage = Resources.timmethypanelbg;
                    controlsToHide = new Control[] {
                        btnDataBusToBasisReg, btnBasisRegMinusDataBusToDataBus, lblBasisReg, btnInsRegPlusProgramCounter,
                        btnInsRegToAccumulator
                    };
                    btnInsRegToProgramCounter.Location = new Point(528, 208);
                    btnResetMicroCodePointer.Location = new Point(594, 499);
                    btnStopProgramExecution.Location = new Point(594, 533);
                    break;
                case SimulatorMode.Timmethy:
                    if (cbShowControlUnit.Checked)
                        mainPanel.BackgroundImage = Resources.timmethymodepanelbg;
                    controlsToHide = new Control[] {};
                    btnInsRegToProgramCounter.Location = new Point(528, 192);
                    btnResetMicroCodePointer.Location = new Point(523, 337);
                    btnStopProgramExecution.Location = new Point(523, 533);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(e.SimulatorMode));
            }

            if (cbShowControlUnit.Checked)
                hideables.Except(controlsToHide).ForEach(c => c.Visible = true);
            else
                hideables.Except(controlsToHide).Except(controlUnitControls).ForEach(c => c.Visible = true);
            controlsToHide.ForEach(c => c.Visible = false);

            //temporary solution for micro code behaviour when mode changes
            if (sender == null) return;
            byte[] data = _simulator.Mode == SimulatorMode.Johnny || _simulator.Mode == SimulatorMode.Timmethy
                ? Resources.johnny
                : Resources.bonsai;
            using (var ms = new MemoryStream(data))
            {
                var formatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.File, _simulator.InstructionSet));
                formatter.Deserialize(ms);
                _simulator.MicroProgramMemory = (Memory<MicroOperationCell>) formatter.Deserialize(ms);
            }
        }

        /// <summary>
        ///     Draws the boxes when an instruction is executed manually via user interface.
        /// </summary>
        private void VisualizeButtonAction(Control sender) {
            Graphics panelGraphics = mainPanel.CreateGraphics();
            //Draw boxes
            if (sender == btnResetAccumulator || sender == btnIncrementAccumulator || sender == btnDecrementAccumulator ||
                sender == btnIncrementProgramCounter || sender == btnConditionalIncrementProgramCounter ||
                sender == btnResetMicroCodePointer || sender == btnStopProgramExecution)

                panelGraphics.FillRectangle(Brushes.Red,
                    sender.Location.X - 3,
                    sender.Location.Y - 3,
                    sender.Size.Width + 6,
                    sender.Size.Height + 6);
            else if (sender == btnAddDataBusToAccumulator || sender == btnSubtractDataBusFromAccumulator ||
                     sender == btnDataBusToAccumulator)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 764, 327, 32, 250);
            else if (sender == btnAccumulatorToDataBus)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 871, 366, 32, 184);
            else if (sender == btnDataBusToBasisReg)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 622, 504, 15, 74);
            else if (sender == btnBasisRegMinusDataBusToDataBus)
            {
                panelGraphics.FillRectangle(Brushes.DarkGreen, 677, 465, 9, 28);
                panelGraphics.FillRectangle(Brushes.DarkGreen, 665, 549, 9, 28);
                panelGraphics.FillRectangle(Brushes.DarkGreen, 694, 534, 9, 31);
            }
            else if (sender == btnDataBusToInsReg)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 360, 208, 25, 370);
            else if (sender == btnDataBusToMemory)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 145, 520, 32, 58);
            else if (sender == btnMemoryToDataBus)
                panelGraphics.FillRectangle(Brushes.DarkGreen, 217, 497, 32, 58);
            else if (sender == btnInsRegToMicroCode)
                panelGraphics.FillRectangle(Brushes.DarkRed, 443, 240, 17, 60);
            else if (sender == btnInsRegToAddressBus)
                panelGraphics.FillRectangle(Brushes.DarkBlue, 487, 110, 24, 88);
            else if (sender == btnInsRegToProgramCounter)
                panelGraphics.FillRectangle(Brushes.DarkBlue, 525, 211, 65, 23);
            else if (sender == btnInsRegPlusProgramCounter)
                panelGraphics.FillRectangle(Brushes.DarkBlue, 525, 211, 65, 23);
            else if (sender == btnInsRegToAccumulator)
            {
                panelGraphics.FillRectangle(Brushes.DarkBlue, 534, 235, 16, 56);
                panelGraphics.FillRectangle(Brushes.DarkBlue, 537, 277, 77, 18);
                panelGraphics.FillRectangle(Brushes.DarkBlue, 596, 277, 19, 66);
                panelGraphics.FillRectangle(Brushes.DarkBlue, 598, 325, 113, 18);
            }
            else if (sender == btnProgramCounterToAddressBus)
                panelGraphics.FillRectangle(Brushes.DarkBlue, 645, 110, 24, 88);
            //Block user interactions for a second
            using (
                var frmBlocker = new Form {
                    FormBorderStyle = FormBorderStyle.None,
                    Size = new Size(0, 0),
                    Opacity = 0,
                    ShowIcon = false,
                    ShowInTaskbar = false
                })
            {
                frmBlocker.Shown += delegate {
                    Thread.Sleep(800);
                    frmBlocker.DialogResult = DialogResult.OK;
                };
                frmBlocker.ShowDialog();
            }
        }

        /// <summary>
        ///     Is called when the control unit toggle has changed its state.
        /// </summary>
        private void cbShowControlUnit_CheckedChanged(object sender, EventArgs e) {
            mainPanel.BackgroundImage = cbShowControlUnit.Checked
                ? Resources.timmethypanelbg
                : Resources.timmethypanelbgdis;
            gbMicroCode.Visible = cbShowControlUnit.Checked;
            mainPanel.Controls.Cast<Control>()
                .Where(c => new Rectangle(340, 85, 385, 490).Contains(c.Location))
                .ForEach(c => c.Visible = cbShowControlUnit.Checked);
            if (_simulator != null)
                _simulator_SimulatorModeChanged(null, new SimulatorModeChangedEventArgs(_simulator.Mode));
            cbShowControlUnit.Text = cbShowControlUnit.Checked ? "Hide" : "Show";
        }

        /// <summary>
        ///     Is called by the <see cref="DataGridView" /> when a cell is clicked.
        /// </summary>
        private void dgvMacroCode_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvMacroCode.CurrentRow == null) return;
            RandomAccessMemoryCell selectedCell =
                _simulator.VisualizedRandomAccessMemory[(int) dgvMacroCode.CurrentRow.Cells[0].Value];
            using (var cellEditor = new FrmRamCellEditor(_simulator.VisualizedMicroProgramMemory, selectedCell))
            {
                switch (cellEditor.ShowDialog())
                {
                    case DialogResult.OK:
                        selectedCell.Hi = cellEditor.HiCode;
                        selectedCell.Lo = cellEditor.LoCode;
                        dgvMacroCode.InvalidateRow(dgvMacroCode.CurrentRow.Index);
                        break;
                    case DialogResult.Yes:
                        selectedCell.Value = 0;
                        dgvMacroCode.InvalidateRow(dgvMacroCode.CurrentRow.Index);
                        break;
                }
            }
        }

        /// <summary>
        ///     Is called when the user wants to specify a custom value for a bus.
        ///     Filters all invalid key presses.
        /// </summary>
        private void tbBusValue_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char) 13)
                btnBusValue_Click(sender == txtAddressBusValue ? btnSetAddressBusValue : btnSetDataBusValue, null);
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char) 8)
                e.Handled = true;
        }

        /// <summary>
        ///     Is called when the user wants to specify a custom value for a bus.
        ///     Sets the entered value to the chosen bus.
        /// </summary>
        private void btnBusValue_Click(object sender, EventArgs e) {
            if (sender == btnSetAddressBusValue)
                _simulator.Registers[AB] = int.Parse(txtAddressBusValue.Text);
            else
                _simulator.Registers[DB] = int.Parse(txtDataBusValue.Text);
        }

        #region Accumulator Zero Status Light

        private bool _isAccZero;

        private bool IsAccZero {
            set {
                if (_isAccZero == value) return;
                _isAccZero = value;
                DrawAccEllipse(value);
            }
        }

        private void DrawAccEllipse(bool enabled) {
            pbAccumulatorZeroStatus.Image = new Bitmap(pbAccumulatorZeroStatus.Width, pbAccumulatorZeroStatus.Height);
            using (Graphics gr = Graphics.FromImage(pbAccumulatorZeroStatus.Image))
            {
                gr.FillEllipse(enabled ? Brushes.Yellow : Brushes.Gray,
                    0,
                    0,
                    pbAccumulatorZeroStatus.Width - 1,
                    pbAccumulatorZeroStatus.Height - 1);
                gr.DrawEllipse(Pens.Black, 0, 0, pbAccumulatorZeroStatus.Width - 1, pbAccumulatorZeroStatus.Height - 1);
            }
        }

        #endregion

        #endregion

        #region Instruction Execution

        /// <summary>
        ///     Is called when a micro step shall be performed by user interaction.
        /// </summary>
        private void btnMicroStep_Click(object sender, EventArgs e) {
            _simulator.VisualizedMicroProgramMemory.Executer.ExecuteCurrent();
        }

        /// <summary>
        ///     Is called when a button which shall run a micro command is pressed.
        /// </summary>
        private void MicroCommandExecution(object sender, EventArgs e) {
            VisualizeButtonAction((Control) sender);
            //Execute instruction
            MicroOperation instruction =
                _simulator.InstructionSet.SingleOrDefault(o => o.Name == (sender as Button)?.Text);
            instruction.MicroAction?.Invoke();
            //Macro recording
            if (_recorder.IsRecording)
            {
                MacroRecording record = _recorder.Current;
                if (record.Position == _simulator.MicroProgramMemory.Length - 1)
                {
                    MessageBox.Show(this,
                        Resources.MessageBoxTextEndOfMicroProgramMemoryReached,
                        @"End Of Memory",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnRecordMacro.Checked = false;
                }
                record.PlaceCell(instruction);
            }
            mainPanel.Refresh();
        }

        #endregion

        #region Macro Execution

        /// <summary>
        ///     Clears the ram by initializing a new instance.
        /// </summary>
        private void btnResetMacroCode_Click(object sender, EventArgs e) {
            ClippedIntegerMemory oldMem = _simulator.RandomAccessMemory;
            _simulator.RandomAccessMemory = new ClippedIntegerMemory(oldMem.Length, oldMem.ValueMaximum);
            dgvMacroCode.Invalidate();
        }

        /// <summary>
        ///     Executes the macro that the address bus is pointing at.
        /// </summary>
        private void btnMacroStep_Click(object sender, EventArgs e) {
            _simulator.VisualizedMicroProgramMemory.Executer.ExecuteMacro();
        }

        /// <summary>
        ///     Starts the program execution.
        /// </summary>
        private void btnRunMacros_Click(object sender, EventArgs e) {
            _simulator.VisualizedMicroProgramMemory.Executer.StartProgram(tbDelay.Value*200, this);
        }

        /// <summary>
        ///     Controls the macro execution interval (program execution).
        /// </summary>
        private void trbDelay_Scroll(object sender, EventArgs e) {
            if (_simulator.VisualizedMicroProgramMemory.Executer.IsExecutingProgram)
                _simulator.VisualizedMicroProgramMemory.Executer.ChangeMacroExecutionInterval(tbDelay.Value*200);
            lVelocity.Text = $@"{(double) tbDelay.Value/5} s";
        }

        /// <summary>
        ///     Pauses/Stops the program execution.
        /// </summary>
        private void btnPauseMacros_Click(object sender, EventArgs e) {
            _simulator.VisualizedMicroProgramMemory.Executer.StopProgram();
        }

        /// <summary>
        ///     Resets all registers + micro code execution pointer.
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e) {
            for (var i = 0; i < _simulator.Registers.Length; i++)
                _simulator.Registers[i] = 0;
        }

        #endregion

        #region Macro Recording

        /// <summary>
        ///     Starts/Stops the recording when the RecordMacro button is pressed.
        /// </summary>
        private void btnRecordMacro_CheckedChanged(object sender, EventArgs e) {
            if (btnRecordMacro.Checked)
            {
                var macroId = (int) nudRecordMacro.Value;
                if (MacroRecording.Exists(_simulator, macroId) &&
                    MessageBox.Show(this,
                        Resources.MessageBoxTextMacroOverride,
                        @"Macro Override",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
                {
                    btnRecordMacro.Checked = false;
                    return;
                }
                _recorder.Record((int) nudRecordMacro.Value, txtRecordMacroName.Text);
                dgvMicroCode.SelectAndScrollTo(_recorder.Current.Position);
                dgvMicroCode.Invalidate();
                btnRecordMacro.ImageKey = @"Stop-icon.png";
            }
            else
            {
                if (!_recorder.IsRecording) return;
                _recorder.Stop();
                dgvMicroCode.SelectAndScrollTo(_simulator.VisualizedMicroProgramMemory.Executer.Position);
                btnRecordMacro.ImageKey = @"Record-icon.png";
            }
        }

        /// <summary>
        ///     Refreshes the numeric up down maximum.
        /// </summary>
        private void nudRecordMacro_Enter(object sender, EventArgs e) {
            nudRecordMacro.Maximum = (decimal) _simulator.MicroProgramMemory.Length - 10;
        }

        /// <summary>
        ///     Checks the recording macro name.
        ///     Macro name has to be longer than two chars and shorter than six chars.
        /// </summary>
        private void txtRecordMacroName_Validating(object sender, CancelEventArgs e) {
            if (txtRecordMacroName.Text.Length > 6)
            {
                MessageBox.Show(this,
                    Resources.MessageBoxTextMacroNameTooLong,
                    @"Macro name too long",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (txtRecordMacroName.Text.Length < 2)
            {
                MessageBox.Show(this,
                    Resources.MessageBoxTextMacroNameTooShort,
                    @"Macro name too short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        #endregion

        #region Testing

        private void ManualChanges() {
            var i = 0;
            AddMacro(ref i, "fetch", "pc->ab", "ram->db", "db->ins", "ins->mc");
            AddMacro(ref i, "TAKE", "acc:=0", "ins->ab", "ram->db", "plus", "pc++", "mc:=0");
            AddMacro(ref i, "ADD", "ins->ab", "ram->db", "plus", "pc++", "mc:=0");
            AddMacro(ref i, "SUB", "ins->ab", "ram->db", "minus", "pc++", "mc:=0");
            AddMacro(ref i, "SAVE", "ins->ab", "acc->db", "db->ram", "pc++", "mc:=0");
            AddMacro(ref i, "JMP", "ins->pc", "mc:=0");
            AddMacro(ref i, "TST", "ins->ab", "ram->db", "db->acc", "=0:pc++", "pc++", "mc:=0");
            AddMacro(ref i,
                "INC",
                "acc:=0",
                "ins->ab",
                "ram->db",
                "plus",
                "acc++",
                "acc->db",
                "db->ram",
                "pc++",
                "mc:=0");
            AddMacro(ref i,
                "DEC",
                "acc:=0",
                "ins->ab",
                "ram->db",
                "plus",
                "acc--",
                "acc->db",
                "db->ram",
                "pc++",
                "mc:=0");
            AddMacro(ref i, "NULL", "ins->ab", "acc:=0", "acc->db", "db->ram", "pc++", "mc:=0");
            AddMacro(ref i, "HLT", "stop", "mc:=0");
        }

        private void AddMacro(ref int index, string name, params string[] keys) {
            string kk = keys[0];
            _simulator.MicroProgramMemory[index] = new MicroOperationCell {
                MacroName = name,
                Operation = _simulator.InstructionSet.Single(o => o.Name == kk)
            };
            index++;
            for (var i = 1; i < keys.Length; i++)
            {
                string ko = keys[i];
                _simulator.MicroProgramMemory[index++] = new MicroOperationCell {
                    Operation = _simulator.InstructionSet.Single(o => o.Name == ko)
                };
            }
            while (index%10 != 0) index++;
        }

        #endregion
    }
}