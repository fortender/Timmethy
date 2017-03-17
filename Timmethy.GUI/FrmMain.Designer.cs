namespace Timmethy.GUI {
    partial class FrmMain {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMicroCode = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecordMacro = new System.Windows.Forms.CheckBox();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.txtRecordMacroName = new System.Windows.Forms.TextBox();
            this.nudRecordMacro = new System.Windows.Forms.NumericUpDown();
            this.btnLoadMicroCode = new System.Windows.Forms.Button();
            this.btnPerformMicroStep = new System.Windows.Forms.Button();
            this.btnSaveMicroCode = new System.Windows.Forms.Button();
            this.gbMacroCode = new System.Windows.Forms.GroupBox();
            this.lVelocity = new System.Windows.Forms.Label();
            this.btnPauseProgramExecution = new System.Windows.Forms.Button();
            this.btnExecuteProgram = new System.Windows.Forms.Button();
            this.btnPerformMacroStep = new System.Windows.Forms.Button();
            this.btnResetRegisters = new System.Windows.Forms.Button();
            this.btnSaveMacroCode = new System.Windows.Forms.Button();
            this.btnLoadMacroCode = new System.Windows.Forms.Button();
            this.btnResetMacroCode = new System.Windows.Forms.Button();
            this.tbDelay = new System.Windows.Forms.TrackBar();
            this.btnShowSettings = new System.Windows.Forms.Button();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.mainPanel = new Timmethy.GUI.DoubleBufferedPanel();
            this.btnBasisRegMinusDataBusToDataBus = new System.Windows.Forms.Button();
            this.btnInsRegToAccumulator = new System.Windows.Forms.Button();
            this.lblBasisReg = new System.Windows.Forms.Label();
            this.btnDataBusToBasisReg = new System.Windows.Forms.Button();
            this.cbShowControlUnit = new System.Windows.Forms.CheckBox();
            this.btnInsRegPlusProgramCounter = new System.Windows.Forms.Button();
            this.btnStopProgramExecution = new System.Windows.Forms.Button();
            this.btnProgramCounterToAddressBus = new System.Windows.Forms.Button();
            this.btnConditionalIncrementProgramCounter = new System.Windows.Forms.Button();
            this.btnIncrementProgramCounter = new System.Windows.Forms.Button();
            this.btnInsRegToAddressBus = new System.Windows.Forms.Button();
            this.btnInsRegToProgramCounter = new System.Windows.Forms.Button();
            this.btnResetMicroCodePointer = new System.Windows.Forms.Button();
            this.btnInsRegToMicroCode = new System.Windows.Forms.Button();
            this.btnDataBusToInsReg = new System.Windows.Forms.Button();
            this.dgvMicroCode = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMacroCode = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMCCurrentCmd = new System.Windows.Forms.Label();
            this.lblMCCurrent = new System.Windows.Forms.Label();
            this.lblMCCell = new System.Windows.Forms.Label();
            this.lblInsRegLoCode = new System.Windows.Forms.Label();
            this.lblInsRegHiCode = new System.Windows.Forms.Label();
            this.lblProgramCounter = new System.Windows.Forms.Label();
            this.btnMemoryToDataBus = new System.Windows.Forms.Button();
            this.btnDataBusToMemory = new System.Windows.Forms.Button();
            this.btnDecrementAccumulator = new System.Windows.Forms.Button();
            this.btnIncrementAccumulator = new System.Windows.Forms.Button();
            this.btnResetAccumulator = new System.Windows.Forms.Button();
            this.btnAccumulatorToDataBus = new System.Windows.Forms.Button();
            this.btnDataBusToAccumulator = new System.Windows.Forms.Button();
            this.btnSubtractDataBusFromAccumulator = new System.Windows.Forms.Button();
            this.btnAddDataBusToAccumulator = new System.Windows.Forms.Button();
            this.pbAccumulatorZeroStatus = new System.Windows.Forms.PictureBox();
            this.btnSetDataBusValue = new System.Windows.Forms.Button();
            this.txtDataBusValue = new System.Windows.Forms.TextBox();
            this.btnSetAddressBusValue = new System.Windows.Forms.Button();
            this.txtAddressBusValue = new System.Windows.Forms.TextBox();
            this.lblAddressBusValue = new System.Windows.Forms.Label();
            this.lblDataBusValue = new System.Windows.Forms.Label();
            this.lblRAMCellValue = new System.Windows.Forms.Label();
            this.lblRAMCell = new System.Windows.Forms.Label();
            this.lblAccumulator = new System.Windows.Forms.Label();
            this.gbMicroCode.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordMacro)).BeginInit();
            this.gbMacroCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).BeginInit();
            this.gbProject.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacroCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccumulatorZeroStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMicroCode
            // 
            this.gbMicroCode.Controls.Add(this.panel1);
            this.gbMicroCode.Controls.Add(this.btnLoadMicroCode);
            this.gbMicroCode.Controls.Add(this.btnPerformMicroStep);
            this.gbMicroCode.Controls.Add(this.btnSaveMicroCode);
            this.gbMicroCode.Location = new System.Drawing.Point(587, 6);
            this.gbMicroCode.Name = "gbMicroCode";
            this.gbMicroCode.Size = new System.Drawing.Size(353, 68);
            this.gbMicroCode.TabIndex = 39;
            this.gbMicroCode.TabStop = false;
            this.gbMicroCode.Text = "Micro Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRecordMacro);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtRecordMacroName);
            this.panel1.Controls.Add(this.nudRecordMacro);
            this.panel1.Location = new System.Drawing.Point(142, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 59);
            this.panel1.TabIndex = 40;
            // 
            // btnRecordMacro
            // 
            this.btnRecordMacro.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecordMacro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecordMacro.ImageKey = "Record-icon.png";
            this.btnRecordMacro.ImageList = this.iconList;
            this.btnRecordMacro.Location = new System.Drawing.Point(3, 11);
            this.btnRecordMacro.Name = "btnRecordMacro";
            this.btnRecordMacro.Size = new System.Drawing.Size(44, 43);
            this.btnRecordMacro.TabIndex = 12;
            this.btnRecordMacro.UseVisualStyleBackColor = true;
            this.btnRecordMacro.CheckedChanged += new System.EventHandler(this.btnRecordMacro_CheckedChanged);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Accept-icon.png");
            this.iconList.Images.SetKeyName(1, "Arrow-Right-icon.png");
            this.iconList.Images.SetKeyName(2, "Arrow-Right-Micro-icon.png");
            this.iconList.Images.SetKeyName(3, "Delete-icon.png");
            this.iconList.Images.SetKeyName(4, "Double-Arrow-Right-icon.png");
            this.iconList.Images.SetKeyName(5, "Export-To-File-icon.png");
            this.iconList.Images.SetKeyName(6, "File-New-icon.png");
            this.iconList.Images.SetKeyName(7, "Folder-Open-icon.png");
            this.iconList.Images.SetKeyName(8, "Folder-Open-Micro-icon.png");
            this.iconList.Images.SetKeyName(9, "Help-icon.png");
            this.iconList.Images.SetKeyName(10, "Pause-icon.png");
            this.iconList.Images.SetKeyName(11, "Record-icon.png");
            this.iconList.Images.SetKeyName(12, "Reload-icon.png");
            this.iconList.Images.SetKeyName(13, "Save-icon.png");
            this.iconList.Images.SetKeyName(14, "Save-Micro-icon.png");
            this.iconList.Images.SetKeyName(15, "Settings-icon.png");
            this.iconList.Images.SetKeyName(16, "Stop-icon.png");
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Location = new System.Drawing.Point(53, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "uAd/Op";
            // 
            // txtRecordMacroName
            // 
            this.txtRecordMacroName.Location = new System.Drawing.Point(152, 23);
            this.txtRecordMacroName.Name = "txtRecordMacroName";
            this.txtRecordMacroName.Size = new System.Drawing.Size(51, 20);
            this.txtRecordMacroName.TabIndex = 14;
            this.txtRecordMacroName.Text = "NN";
            this.txtRecordMacroName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRecordMacroName_Validating);
            // 
            // nudRecordMacro
            // 
            this.nudRecordMacro.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRecordMacro.Location = new System.Drawing.Point(100, 23);
            this.nudRecordMacro.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudRecordMacro.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRecordMacro.Name = "nudRecordMacro";
            this.nudRecordMacro.Size = new System.Drawing.Size(46, 20);
            this.nudRecordMacro.TabIndex = 13;
            this.nudRecordMacro.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRecordMacro.Enter += new System.EventHandler(this.nudRecordMacro_Enter);
            // 
            // btnLoadMicroCode
            // 
            this.btnLoadMicroCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadMicroCode.ImageKey = "Folder-Open-Micro-icon.png";
            this.btnLoadMicroCode.ImageList = this.iconList;
            this.btnLoadMicroCode.Location = new System.Drawing.Point(6, 18);
            this.btnLoadMicroCode.Name = "btnLoadMicroCode";
            this.btnLoadMicroCode.Size = new System.Drawing.Size(44, 43);
            this.btnLoadMicroCode.TabIndex = 9;
            this.btnLoadMicroCode.UseVisualStyleBackColor = true;
            this.btnLoadMicroCode.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // btnPerformMicroStep
            // 
            this.btnPerformMicroStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerformMicroStep.ImageKey = "Arrow-Right-Micro-icon.png";
            this.btnPerformMicroStep.ImageList = this.iconList;
            this.btnPerformMicroStep.Location = new System.Drawing.Point(92, 18);
            this.btnPerformMicroStep.Name = "btnPerformMicroStep";
            this.btnPerformMicroStep.Size = new System.Drawing.Size(44, 43);
            this.btnPerformMicroStep.TabIndex = 11;
            this.btnPerformMicroStep.UseVisualStyleBackColor = true;
            this.btnPerformMicroStep.Click += new System.EventHandler(this.btnMicroStep_Click);
            // 
            // btnSaveMicroCode
            // 
            this.btnSaveMicroCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveMicroCode.ImageKey = "Save-Micro-icon.png";
            this.btnSaveMicroCode.ImageList = this.iconList;
            this.btnSaveMicroCode.Location = new System.Drawing.Point(49, 18);
            this.btnSaveMicroCode.Name = "btnSaveMicroCode";
            this.btnSaveMicroCode.Size = new System.Drawing.Size(44, 43);
            this.btnSaveMicroCode.TabIndex = 10;
            this.btnSaveMicroCode.UseVisualStyleBackColor = true;
            this.btnSaveMicroCode.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // gbMacroCode
            // 
            this.gbMacroCode.Controls.Add(this.lVelocity);
            this.gbMacroCode.Controls.Add(this.btnPauseProgramExecution);
            this.gbMacroCode.Controls.Add(this.btnExecuteProgram);
            this.gbMacroCode.Controls.Add(this.btnPerformMacroStep);
            this.gbMacroCode.Controls.Add(this.btnResetRegisters);
            this.gbMacroCode.Controls.Add(this.btnSaveMacroCode);
            this.gbMacroCode.Controls.Add(this.btnLoadMacroCode);
            this.gbMacroCode.Controls.Add(this.btnResetMacroCode);
            this.gbMacroCode.Controls.Add(this.tbDelay);
            this.gbMacroCode.Location = new System.Drawing.Point(145, 6);
            this.gbMacroCode.Name = "gbMacroCode";
            this.gbMacroCode.Size = new System.Drawing.Size(408, 68);
            this.gbMacroCode.TabIndex = 32;
            this.gbMacroCode.TabStop = false;
            this.gbMacroCode.Text = "Macro Code";
            // 
            // lVelocity
            // 
            this.lVelocity.AutoSize = true;
            this.lVelocity.Location = new System.Drawing.Point(258, 48);
            this.lVelocity.Name = "lVelocity";
            this.lVelocity.Size = new System.Drawing.Size(21, 13);
            this.lVelocity.TabIndex = 10;
            this.lVelocity.Text = "1 s";
            // 
            // btnPauseProgramExecution
            // 
            this.btnPauseProgramExecution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPauseProgramExecution.ImageKey = "Pause-icon.png";
            this.btnPauseProgramExecution.ImageList = this.iconList;
            this.btnPauseProgramExecution.Location = new System.Drawing.Point(313, 18);
            this.btnPauseProgramExecution.Name = "btnPauseProgramExecution";
            this.btnPauseProgramExecution.Size = new System.Drawing.Size(44, 43);
            this.btnPauseProgramExecution.TabIndex = 6;
            this.btnPauseProgramExecution.UseVisualStyleBackColor = true;
            this.btnPauseProgramExecution.Click += new System.EventHandler(this.btnPauseMacros_Click);
            // 
            // btnExecuteProgram
            // 
            this.btnExecuteProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecuteProgram.ImageKey = "Double-Arrow-Right-icon.png";
            this.btnExecuteProgram.ImageList = this.iconList;
            this.btnExecuteProgram.Location = new System.Drawing.Point(188, 18);
            this.btnExecuteProgram.Name = "btnExecuteProgram";
            this.btnExecuteProgram.Size = new System.Drawing.Size(44, 43);
            this.btnExecuteProgram.TabIndex = 4;
            this.btnExecuteProgram.UseVisualStyleBackColor = true;
            this.btnExecuteProgram.Click += new System.EventHandler(this.btnRunMacros_Click);
            // 
            // btnPerformMacroStep
            // 
            this.btnPerformMacroStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerformMacroStep.ImageIndex = 1;
            this.btnPerformMacroStep.ImageList = this.iconList;
            this.btnPerformMacroStep.Location = new System.Drawing.Point(145, 18);
            this.btnPerformMacroStep.Name = "btnPerformMacroStep";
            this.btnPerformMacroStep.Size = new System.Drawing.Size(44, 43);
            this.btnPerformMacroStep.TabIndex = 3;
            this.btnPerformMacroStep.UseVisualStyleBackColor = true;
            this.btnPerformMacroStep.Click += new System.EventHandler(this.btnMacroStep_Click);
            // 
            // btnResetRegisters
            // 
            this.btnResetRegisters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetRegisters.ImageKey = "Reload-icon.png";
            this.btnResetRegisters.ImageList = this.iconList;
            this.btnResetRegisters.Location = new System.Drawing.Point(356, 18);
            this.btnResetRegisters.Name = "btnResetRegisters";
            this.btnResetRegisters.Size = new System.Drawing.Size(44, 43);
            this.btnResetRegisters.TabIndex = 7;
            this.btnResetRegisters.UseVisualStyleBackColor = true;
            this.btnResetRegisters.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveMacroCode
            // 
            this.btnSaveMacroCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveMacroCode.ImageKey = "Save-icon.png";
            this.btnSaveMacroCode.ImageList = this.iconList;
            this.btnSaveMacroCode.Location = new System.Drawing.Point(92, 18);
            this.btnSaveMacroCode.Name = "btnSaveMacroCode";
            this.btnSaveMacroCode.Size = new System.Drawing.Size(44, 43);
            this.btnSaveMacroCode.TabIndex = 2;
            this.btnSaveMacroCode.UseVisualStyleBackColor = true;
            this.btnSaveMacroCode.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // btnLoadMacroCode
            // 
            this.btnLoadMacroCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadMacroCode.ImageKey = "Folder-Open-icon.png";
            this.btnLoadMacroCode.ImageList = this.iconList;
            this.btnLoadMacroCode.Location = new System.Drawing.Point(49, 18);
            this.btnLoadMacroCode.Name = "btnLoadMacroCode";
            this.btnLoadMacroCode.Size = new System.Drawing.Size(44, 43);
            this.btnLoadMacroCode.TabIndex = 1;
            this.btnLoadMacroCode.UseVisualStyleBackColor = true;
            this.btnLoadMacroCode.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // btnResetMacroCode
            // 
            this.btnResetMacroCode.ImageKey = "File-New-icon.png";
            this.btnResetMacroCode.ImageList = this.iconList;
            this.btnResetMacroCode.Location = new System.Drawing.Point(6, 18);
            this.btnResetMacroCode.Name = "btnResetMacroCode";
            this.btnResetMacroCode.Size = new System.Drawing.Size(44, 43);
            this.btnResetMacroCode.TabIndex = 0;
            this.btnResetMacroCode.UseVisualStyleBackColor = true;
            this.btnResetMacroCode.Click += new System.EventHandler(this.btnResetMacroCode_Click);
            // 
            // tbDelay
            // 
            this.tbDelay.AutoSize = false;
            this.tbDelay.Location = new System.Drawing.Point(226, 18);
            this.tbDelay.Minimum = 1;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(93, 33);
            this.tbDelay.TabIndex = 5;
            this.tbDelay.Value = 5;
            this.tbDelay.Scroll += new System.EventHandler(this.trbDelay_Scroll);
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowSettings.ImageKey = "Settings-icon.png";
            this.btnShowSettings.ImageList = this.iconList;
            this.btnShowSettings.Location = new System.Drawing.Point(951, 24);
            this.btnShowSettings.Name = "btnShowSettings";
            this.btnShowSettings.Size = new System.Drawing.Size(44, 43);
            this.btnShowSettings.TabIndex = 15;
            this.btnShowSettings.UseVisualStyleBackColor = true;
            this.btnShowSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.btnLoadProject);
            this.gbProject.Controls.Add(this.btnSaveProject);
            this.gbProject.Location = new System.Drawing.Point(8, 6);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(105, 68);
            this.gbProject.TabIndex = 41;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Project";
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadProject.ImageKey = "Folder-Open-icon.png";
            this.btnLoadProject.ImageList = this.iconList;
            this.btnLoadProject.Location = new System.Drawing.Point(8, 17);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(44, 43);
            this.btnLoadProject.TabIndex = 1;
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveProject.ImageKey = "Save-icon.png";
            this.btnSaveProject.ImageList = this.iconList;
            this.btnSaveProject.Location = new System.Drawing.Point(51, 17);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(44, 43);
            this.btnSaveProject.TabIndex = 2;
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.SaveLoadUnitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::Timmethy.GUI.Properties.Resources.timmethypanelbg;
            this.mainPanel.Controls.Add(this.btnBasisRegMinusDataBusToDataBus);
            this.mainPanel.Controls.Add(this.btnInsRegToAccumulator);
            this.mainPanel.Controls.Add(this.lblBasisReg);
            this.mainPanel.Controls.Add(this.btnDataBusToBasisReg);
            this.mainPanel.Controls.Add(this.cbShowControlUnit);
            this.mainPanel.Controls.Add(this.btnInsRegPlusProgramCounter);
            this.mainPanel.Controls.Add(this.btnStopProgramExecution);
            this.mainPanel.Controls.Add(this.btnProgramCounterToAddressBus);
            this.mainPanel.Controls.Add(this.btnConditionalIncrementProgramCounter);
            this.mainPanel.Controls.Add(this.btnIncrementProgramCounter);
            this.mainPanel.Controls.Add(this.btnInsRegToAddressBus);
            this.mainPanel.Controls.Add(this.btnInsRegToProgramCounter);
            this.mainPanel.Controls.Add(this.btnResetMicroCodePointer);
            this.mainPanel.Controls.Add(this.btnInsRegToMicroCode);
            this.mainPanel.Controls.Add(this.btnDataBusToInsReg);
            this.mainPanel.Controls.Add(this.dgvMicroCode);
            this.mainPanel.Controls.Add(this.dgvMacroCode);
            this.mainPanel.Controls.Add(this.lblMCCurrentCmd);
            this.mainPanel.Controls.Add(this.lblMCCurrent);
            this.mainPanel.Controls.Add(this.lblMCCell);
            this.mainPanel.Controls.Add(this.lblInsRegLoCode);
            this.mainPanel.Controls.Add(this.lblInsRegHiCode);
            this.mainPanel.Controls.Add(this.lblProgramCounter);
            this.mainPanel.Controls.Add(this.btnMemoryToDataBus);
            this.mainPanel.Controls.Add(this.btnDataBusToMemory);
            this.mainPanel.Controls.Add(this.btnDecrementAccumulator);
            this.mainPanel.Controls.Add(this.btnIncrementAccumulator);
            this.mainPanel.Controls.Add(this.btnResetAccumulator);
            this.mainPanel.Controls.Add(this.btnAccumulatorToDataBus);
            this.mainPanel.Controls.Add(this.btnDataBusToAccumulator);
            this.mainPanel.Controls.Add(this.btnSubtractDataBusFromAccumulator);
            this.mainPanel.Controls.Add(this.btnAddDataBusToAccumulator);
            this.mainPanel.Controls.Add(this.pbAccumulatorZeroStatus);
            this.mainPanel.Controls.Add(this.btnSetDataBusValue);
            this.mainPanel.Controls.Add(this.txtDataBusValue);
            this.mainPanel.Controls.Add(this.btnSetAddressBusValue);
            this.mainPanel.Controls.Add(this.txtAddressBusValue);
            this.mainPanel.Controls.Add(this.lblAddressBusValue);
            this.mainPanel.Controls.Add(this.lblDataBusValue);
            this.mainPanel.Controls.Add(this.lblRAMCellValue);
            this.mainPanel.Controls.Add(this.lblRAMCell);
            this.mainPanel.Controls.Add(this.lblAccumulator);
            this.mainPanel.Location = new System.Drawing.Point(0, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1008, 651);
            this.mainPanel.TabIndex = 40;
            // 
            // btnBasisRegMinusDataBusToDataBus
            // 
            this.btnBasisRegMinusDataBusToDataBus.Location = new System.Drawing.Point(652, 506);
            this.btnBasisRegMinusDataBusToDataBus.Name = "btnBasisRegMinusDataBusToDataBus";
            this.btnBasisRegMinusDataBusToDataBus.Size = new System.Drawing.Size(60, 28);
            this.btnBasisRegMinusDataBusToDataBus.TabIndex = 36;
            this.btnBasisRegMinusDataBusToDataBus.Tag = "24";
            this.btnBasisRegMinusDataBusToDataBus.Text = "br-db->db";
            this.btnBasisRegMinusDataBusToDataBus.UseVisualStyleBackColor = true;
            this.btnBasisRegMinusDataBusToDataBus.Visible = false;
            this.btnBasisRegMinusDataBusToDataBus.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnInsRegToAccumulator
            // 
            this.btnInsRegToAccumulator.Location = new System.Drawing.Point(528, 271);
            this.btnInsRegToAccumulator.Name = "btnInsRegToAccumulator";
            this.btnInsRegToAccumulator.Size = new System.Drawing.Size(60, 28);
            this.btnInsRegToAccumulator.TabIndex = 28;
            this.btnInsRegToAccumulator.Tag = "23";
            this.btnInsRegToAccumulator.Text = "ins->acc";
            this.btnInsRegToAccumulator.UseVisualStyleBackColor = true;
            this.btnInsRegToAccumulator.Visible = false;
            this.btnInsRegToAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // lblBasisReg
            // 
            this.lblBasisReg.AutoSize = true;
            this.lblBasisReg.BackColor = System.Drawing.Color.Transparent;
            this.lblBasisReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasisReg.Location = new System.Drawing.Point(633, 428);
            this.lblBasisReg.Name = "lblBasisReg";
            this.lblBasisReg.Size = new System.Drawing.Size(52, 29);
            this.lblBasisReg.TabIndex = 81;
            this.lblBasisReg.Text = "000";
            this.lblBasisReg.Visible = false;
            // 
            // btnDataBusToBasisReg
            // 
            this.btnDataBusToBasisReg.Location = new System.Drawing.Point(599, 535);
            this.btnDataBusToBasisReg.Name = "btnDataBusToBasisReg";
            this.btnDataBusToBasisReg.Size = new System.Drawing.Size(60, 28);
            this.btnDataBusToBasisReg.TabIndex = 35;
            this.btnDataBusToBasisReg.Tag = "21";
            this.btnDataBusToBasisReg.Text = "db->br";
            this.btnDataBusToBasisReg.UseVisualStyleBackColor = true;
            this.btnDataBusToBasisReg.Visible = false;
            this.btnDataBusToBasisReg.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // cbShowControlUnit
            // 
            this.cbShowControlUnit.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowControlUnit.Checked = true;
            this.cbShowControlUnit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowControlUnit.Location = new System.Drawing.Point(599, 3);
            this.cbShowControlUnit.Name = "cbShowControlUnit";
            this.cbShowControlUnit.Size = new System.Drawing.Size(43, 21);
            this.cbShowControlUnit.TabIndex = 8;
            this.cbShowControlUnit.Text = "Show";
            this.cbShowControlUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowControlUnit.UseVisualStyleBackColor = true;
            this.cbShowControlUnit.CheckedChanged += new System.EventHandler(this.cbShowControlUnit_CheckedChanged);
            // 
            // btnInsRegPlusProgramCounter
            // 
            this.btnInsRegPlusProgramCounter.Location = new System.Drawing.Point(528, 226);
            this.btnInsRegPlusProgramCounter.Name = "btnInsRegPlusProgramCounter";
            this.btnInsRegPlusProgramCounter.Size = new System.Drawing.Size(60, 28);
            this.btnInsRegPlusProgramCounter.TabIndex = 27;
            this.btnInsRegPlusProgramCounter.Tag = "20";
            this.btnInsRegPlusProgramCounter.Text = "ins+pc";
            this.btnInsRegPlusProgramCounter.UseVisualStyleBackColor = true;
            this.btnInsRegPlusProgramCounter.Visible = false;
            this.btnInsRegPlusProgramCounter.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnStopProgramExecution
            // 
            this.btnStopProgramExecution.Location = new System.Drawing.Point(594, 533);
            this.btnStopProgramExecution.Name = "btnStopProgramExecution";
            this.btnStopProgramExecution.Size = new System.Drawing.Size(60, 28);
            this.btnStopProgramExecution.TabIndex = 34;
            this.btnStopProgramExecution.Tag = "19";
            this.btnStopProgramExecution.Text = "stop";
            this.btnStopProgramExecution.UseVisualStyleBackColor = true;
            this.btnStopProgramExecution.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnProgramCounterToAddressBus
            // 
            this.btnProgramCounterToAddressBus.Location = new System.Drawing.Point(629, 143);
            this.btnProgramCounterToAddressBus.Name = "btnProgramCounterToAddressBus";
            this.btnProgramCounterToAddressBus.Size = new System.Drawing.Size(60, 28);
            this.btnProgramCounterToAddressBus.TabIndex = 30;
            this.btnProgramCounterToAddressBus.Tag = "8";
            this.btnProgramCounterToAddressBus.Text = "pc->ab";
            this.btnProgramCounterToAddressBus.UseVisualStyleBackColor = true;
            this.btnProgramCounterToAddressBus.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnConditionalIncrementProgramCounter
            // 
            this.btnConditionalIncrementProgramCounter.Location = new System.Drawing.Point(629, 266);
            this.btnConditionalIncrementProgramCounter.Name = "btnConditionalIncrementProgramCounter";
            this.btnConditionalIncrementProgramCounter.Size = new System.Drawing.Size(60, 28);
            this.btnConditionalIncrementProgramCounter.TabIndex = 31;
            this.btnConditionalIncrementProgramCounter.Tag = "10";
            this.btnConditionalIncrementProgramCounter.Text = "=0:pc++";
            this.btnConditionalIncrementProgramCounter.UseVisualStyleBackColor = true;
            this.btnConditionalIncrementProgramCounter.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnIncrementProgramCounter
            // 
            this.btnIncrementProgramCounter.Location = new System.Drawing.Point(629, 294);
            this.btnIncrementProgramCounter.Name = "btnIncrementProgramCounter";
            this.btnIncrementProgramCounter.Size = new System.Drawing.Size(60, 28);
            this.btnIncrementProgramCounter.TabIndex = 32;
            this.btnIncrementProgramCounter.Tag = "9";
            this.btnIncrementProgramCounter.Text = "pc++";
            this.btnIncrementProgramCounter.UseVisualStyleBackColor = true;
            this.btnIncrementProgramCounter.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnInsRegToAddressBus
            // 
            this.btnInsRegToAddressBus.Location = new System.Drawing.Point(469, 143);
            this.btnInsRegToAddressBus.Name = "btnInsRegToAddressBus";
            this.btnInsRegToAddressBus.Size = new System.Drawing.Size(60, 28);
            this.btnInsRegToAddressBus.TabIndex = 25;
            this.btnInsRegToAddressBus.Tag = "4";
            this.btnInsRegToAddressBus.Text = "ins->ab";
            this.btnInsRegToAddressBus.UseVisualStyleBackColor = true;
            this.btnInsRegToAddressBus.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnInsRegToProgramCounter
            // 
            this.btnInsRegToProgramCounter.Location = new System.Drawing.Point(528, 208);
            this.btnInsRegToProgramCounter.Name = "btnInsRegToProgramCounter";
            this.btnInsRegToProgramCounter.Size = new System.Drawing.Size(60, 28);
            this.btnInsRegToProgramCounter.TabIndex = 26;
            this.btnInsRegToProgramCounter.Tag = "11";
            this.btnInsRegToProgramCounter.Text = "ins->pc";
            this.btnInsRegToProgramCounter.UseVisualStyleBackColor = true;
            this.btnInsRegToProgramCounter.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnResetMicroCodePointer
            // 
            this.btnResetMicroCodePointer.Location = new System.Drawing.Point(594, 499);
            this.btnResetMicroCodePointer.Name = "btnResetMicroCodePointer";
            this.btnResetMicroCodePointer.Size = new System.Drawing.Size(60, 28);
            this.btnResetMicroCodePointer.TabIndex = 33;
            this.btnResetMicroCodePointer.Tag = "7";
            this.btnResetMicroCodePointer.Text = "mc:=0";
            this.btnResetMicroCodePointer.UseVisualStyleBackColor = true;
            this.btnResetMicroCodePointer.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnInsRegToMicroCode
            // 
            this.btnInsRegToMicroCode.Location = new System.Drawing.Point(421, 274);
            this.btnInsRegToMicroCode.Name = "btnInsRegToMicroCode";
            this.btnInsRegToMicroCode.Size = new System.Drawing.Size(60, 28);
            this.btnInsRegToMicroCode.TabIndex = 24;
            this.btnInsRegToMicroCode.Tag = "5";
            this.btnInsRegToMicroCode.Text = "ins->mc";
            this.btnInsRegToMicroCode.UseVisualStyleBackColor = true;
            this.btnInsRegToMicroCode.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnDataBusToInsReg
            // 
            this.btnDataBusToInsReg.Location = new System.Drawing.Point(358, 208);
            this.btnDataBusToInsReg.Name = "btnDataBusToInsReg";
            this.btnDataBusToInsReg.Size = new System.Drawing.Size(60, 28);
            this.btnDataBusToInsReg.TabIndex = 23;
            this.btnDataBusToInsReg.Tag = "3";
            this.btnDataBusToInsReg.Text = "db->ins";
            this.btnDataBusToInsReg.UseVisualStyleBackColor = true;
            this.btnDataBusToInsReg.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // dgvMicroCode
            // 
            this.dgvMicroCode.AllowDrop = true;
            this.dgvMicroCode.AllowUserToAddRows = false;
            this.dgvMicroCode.AllowUserToDeleteRows = false;
            this.dgvMicroCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMicroCode.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMicroCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroCode.ColumnHeadersVisible = false;
            this.dgvMicroCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMicroCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMicroCode.Location = new System.Drawing.Point(429, 375);
            this.dgvMicroCode.MultiSelect = false;
            this.dgvMicroCode.Name = "dgvMicroCode";
            this.dgvMicroCode.ReadOnly = true;
            this.dgvMicroCode.RowHeadersVisible = false;
            this.dgvMicroCode.RowHeadersWidth = 23;
            this.dgvMicroCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMicroCode.Size = new System.Drawing.Size(154, 149);
            this.dgvMicroCode.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dgvMacroCode
            // 
            this.dgvMacroCode.AllowDrop = true;
            this.dgvMacroCode.AllowUserToAddRows = false;
            this.dgvMacroCode.AllowUserToDeleteRows = false;
            this.dgvMacroCode.AllowUserToResizeColumns = false;
            this.dgvMacroCode.AllowUserToResizeRows = false;
            this.dgvMacroCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMacroCode.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMacroCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacroCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMacroCode.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMacroCode.Location = new System.Drawing.Point(72, 143);
            this.dgvMacroCode.MultiSelect = false;
            this.dgvMacroCode.Name = "dgvMacroCode";
            this.dgvMacroCode.ReadOnly = true;
            this.dgvMacroCode.RowHeadersWidth = 23;
            this.dgvMacroCode.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMacroCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMacroCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMacroCode.Size = new System.Drawing.Size(235, 312);
            this.dgvMacroCode.TabIndex = 18;
            this.dgvMacroCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMacroCode_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            dataGridViewCellStyle7.Format = "000:";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Adr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hi";
            dataGridViewCellStyle8.Format = "00";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lo";
            dataGridViewCellStyle9.Format = "000";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Lo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MacroName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Asm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Operand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Opnd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblMCCurrentCmd
            // 
            this.lblMCCurrentCmd.AutoSize = true;
            this.lblMCCurrentCmd.BackColor = System.Drawing.Color.Transparent;
            this.lblMCCurrentCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMCCurrentCmd.Location = new System.Drawing.Point(435, 533);
            this.lblMCCurrentCmd.Name = "lblMCCurrentCmd";
            this.lblMCCurrentCmd.Size = new System.Drawing.Size(69, 24);
            this.lblMCCurrentCmd.TabIndex = 67;
            this.lblMCCurrentCmd.Text = "pc->ab";
            // 
            // lblMCCurrent
            // 
            this.lblMCCurrent.AutoSize = true;
            this.lblMCCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblMCCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCCurrent.Location = new System.Drawing.Point(486, 336);
            this.lblMCCurrent.Name = "lblMCCurrent";
            this.lblMCCurrent.Size = new System.Drawing.Size(26, 29);
            this.lblMCCurrent.TabIndex = 66;
            this.lblMCCurrent.Text = "0";
            // 
            // lblMCCell
            // 
            this.lblMCCell.AutoSize = true;
            this.lblMCCell.BackColor = System.Drawing.Color.Transparent;
            this.lblMCCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCCell.Location = new System.Drawing.Point(434, 336);
            this.lblMCCell.Name = "lblMCCell";
            this.lblMCCell.Size = new System.Drawing.Size(39, 29);
            this.lblMCCell.TabIndex = 65;
            this.lblMCCell.Text = "00";
            // 
            // lblInsRegLoCode
            // 
            this.lblInsRegLoCode.AutoSize = true;
            this.lblInsRegLoCode.BackColor = System.Drawing.Color.Transparent;
            this.lblInsRegLoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsRegLoCode.ForeColor = System.Drawing.Color.Blue;
            this.lblInsRegLoCode.Location = new System.Drawing.Point(470, 204);
            this.lblInsRegLoCode.Name = "lblInsRegLoCode";
            this.lblInsRegLoCode.Size = new System.Drawing.Size(52, 29);
            this.lblInsRegLoCode.TabIndex = 64;
            this.lblInsRegLoCode.Text = "000";
            // 
            // lblInsRegHiCode
            // 
            this.lblInsRegHiCode.AutoSize = true;
            this.lblInsRegHiCode.BackColor = System.Drawing.Color.Transparent;
            this.lblInsRegHiCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsRegHiCode.ForeColor = System.Drawing.Color.Red;
            this.lblInsRegHiCode.Location = new System.Drawing.Point(435, 204);
            this.lblInsRegHiCode.Name = "lblInsRegHiCode";
            this.lblInsRegHiCode.Size = new System.Drawing.Size(39, 29);
            this.lblInsRegHiCode.TabIndex = 62;
            this.lblInsRegHiCode.Text = "00";
            // 
            // lblProgramCounter
            // 
            this.lblProgramCounter.AutoSize = true;
            this.lblProgramCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramCounter.Location = new System.Drawing.Point(632, 204);
            this.lblProgramCounter.Name = "lblProgramCounter";
            this.lblProgramCounter.Size = new System.Drawing.Size(52, 29);
            this.lblProgramCounter.TabIndex = 63;
            this.lblProgramCounter.Text = "000";
            // 
            // btnMemoryToDataBus
            // 
            this.btnMemoryToDataBus.Location = new System.Drawing.Point(203, 507);
            this.btnMemoryToDataBus.Name = "btnMemoryToDataBus";
            this.btnMemoryToDataBus.Size = new System.Drawing.Size(60, 28);
            this.btnMemoryToDataBus.TabIndex = 20;
            this.btnMemoryToDataBus.Tag = "2";
            this.btnMemoryToDataBus.Text = "ram->db";
            this.btnMemoryToDataBus.UseVisualStyleBackColor = true;
            this.btnMemoryToDataBus.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnDataBusToMemory
            // 
            this.btnDataBusToMemory.Location = new System.Drawing.Point(130, 540);
            this.btnDataBusToMemory.Name = "btnDataBusToMemory";
            this.btnDataBusToMemory.Size = new System.Drawing.Size(60, 28);
            this.btnDataBusToMemory.TabIndex = 19;
            this.btnDataBusToMemory.Tag = "1";
            this.btnDataBusToMemory.Text = "db->ram";
            this.btnDataBusToMemory.UseVisualStyleBackColor = true;
            this.btnDataBusToMemory.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnDecrementAccumulator
            // 
            this.btnDecrementAccumulator.Location = new System.Drawing.Point(850, 164);
            this.btnDecrementAccumulator.Name = "btnDecrementAccumulator";
            this.btnDecrementAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnDecrementAccumulator.TabIndex = 39;
            this.btnDecrementAccumulator.Tag = "17";
            this.btnDecrementAccumulator.Text = "acc--";
            this.btnDecrementAccumulator.UseVisualStyleBackColor = true;
            this.btnDecrementAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnIncrementAccumulator
            // 
            this.btnIncrementAccumulator.Location = new System.Drawing.Point(850, 130);
            this.btnIncrementAccumulator.Name = "btnIncrementAccumulator";
            this.btnIncrementAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnIncrementAccumulator.TabIndex = 38;
            this.btnIncrementAccumulator.Tag = "16";
            this.btnIncrementAccumulator.Text = "acc++";
            this.btnIncrementAccumulator.UseVisualStyleBackColor = true;
            this.btnIncrementAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnResetAccumulator
            // 
            this.btnResetAccumulator.Location = new System.Drawing.Point(850, 96);
            this.btnResetAccumulator.Name = "btnResetAccumulator";
            this.btnResetAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnResetAccumulator.TabIndex = 37;
            this.btnResetAccumulator.Tag = "12";
            this.btnResetAccumulator.Text = "acc:=0";
            this.btnResetAccumulator.UseVisualStyleBackColor = true;
            this.btnResetAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnAccumulatorToDataBus
            // 
            this.btnAccumulatorToDataBus.Location = new System.Drawing.Point(850, 460);
            this.btnAccumulatorToDataBus.Name = "btnAccumulatorToDataBus";
            this.btnAccumulatorToDataBus.Size = new System.Drawing.Size(75, 28);
            this.btnAccumulatorToDataBus.TabIndex = 43;
            this.btnAccumulatorToDataBus.Tag = "15";
            this.btnAccumulatorToDataBus.Text = "acc->db";
            this.btnAccumulatorToDataBus.UseVisualStyleBackColor = true;
            this.btnAccumulatorToDataBus.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnDataBusToAccumulator
            // 
            this.btnDataBusToAccumulator.Location = new System.Drawing.Point(743, 460);
            this.btnDataBusToAccumulator.Name = "btnDataBusToAccumulator";
            this.btnDataBusToAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnDataBusToAccumulator.TabIndex = 42;
            this.btnDataBusToAccumulator.Tag = "18";
            this.btnDataBusToAccumulator.Text = "db->acc";
            this.btnDataBusToAccumulator.UseVisualStyleBackColor = true;
            this.btnDataBusToAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnSubtractDataBusFromAccumulator
            // 
            this.btnSubtractDataBusFromAccumulator.Location = new System.Drawing.Point(743, 426);
            this.btnSubtractDataBusFromAccumulator.Name = "btnSubtractDataBusFromAccumulator";
            this.btnSubtractDataBusFromAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnSubtractDataBusFromAccumulator.TabIndex = 41;
            this.btnSubtractDataBusFromAccumulator.Tag = "14";
            this.btnSubtractDataBusFromAccumulator.Text = "minus";
            this.btnSubtractDataBusFromAccumulator.UseVisualStyleBackColor = true;
            this.btnSubtractDataBusFromAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // btnAddDataBusToAccumulator
            // 
            this.btnAddDataBusToAccumulator.Location = new System.Drawing.Point(743, 392);
            this.btnAddDataBusToAccumulator.Name = "btnAddDataBusToAccumulator";
            this.btnAddDataBusToAccumulator.Size = new System.Drawing.Size(75, 28);
            this.btnAddDataBusToAccumulator.TabIndex = 40;
            this.btnAddDataBusToAccumulator.Tag = "13";
            this.btnAddDataBusToAccumulator.Text = "plus";
            this.btnAddDataBusToAccumulator.UseVisualStyleBackColor = true;
            this.btnAddDataBusToAccumulator.Click += new System.EventHandler(this.MicroCommandExecution);
            // 
            // pbAccumulatorZeroStatus
            // 
            this.pbAccumulatorZeroStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbAccumulatorZeroStatus.Location = new System.Drawing.Point(767, 267);
            this.pbAccumulatorZeroStatus.Name = "pbAccumulatorZeroStatus";
            this.pbAccumulatorZeroStatus.Size = new System.Drawing.Size(30, 26);
            this.pbAccumulatorZeroStatus.TabIndex = 52;
            this.pbAccumulatorZeroStatus.TabStop = false;
            // 
            // btnSetDataBusValue
            // 
            this.btnSetDataBusValue.Location = new System.Drawing.Point(97, 576);
            this.btnSetDataBusValue.Name = "btnSetDataBusValue";
            this.btnSetDataBusValue.Size = new System.Drawing.Size(13, 55);
            this.btnSetDataBusValue.TabIndex = 22;
            this.btnSetDataBusValue.UseVisualStyleBackColor = true;
            this.btnSetDataBusValue.Click += new System.EventHandler(this.btnBusValue_Click);
            // 
            // txtDataBusValue
            // 
            this.txtDataBusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBusValue.Location = new System.Drawing.Point(26, 587);
            this.txtDataBusValue.Name = "txtDataBusValue";
            this.txtDataBusValue.Size = new System.Drawing.Size(70, 32);
            this.txtDataBusValue.TabIndex = 21;
            this.txtDataBusValue.Text = "00000";
            this.txtDataBusValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataBusValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusValue_KeyPress);
            // 
            // btnSetAddressBusValue
            // 
            this.btnSetAddressBusValue.Location = new System.Drawing.Point(97, 26);
            this.btnSetAddressBusValue.Name = "btnSetAddressBusValue";
            this.btnSetAddressBusValue.Size = new System.Drawing.Size(13, 55);
            this.btnSetAddressBusValue.TabIndex = 17;
            this.btnSetAddressBusValue.UseVisualStyleBackColor = true;
            this.btnSetAddressBusValue.Click += new System.EventHandler(this.btnBusValue_Click);
            // 
            // txtAddressBusValue
            // 
            this.txtAddressBusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressBusValue.Location = new System.Drawing.Point(26, 38);
            this.txtAddressBusValue.Name = "txtAddressBusValue";
            this.txtAddressBusValue.Size = new System.Drawing.Size(70, 32);
            this.txtAddressBusValue.TabIndex = 16;
            this.txtAddressBusValue.Text = "000";
            this.txtAddressBusValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddressBusValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusValue_KeyPress);
            // 
            // lblAddressBusValue
            // 
            this.lblAddressBusValue.AutoSize = true;
            this.lblAddressBusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressBusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressBusValue.Location = new System.Drawing.Point(421, 40);
            this.lblAddressBusValue.Name = "lblAddressBusValue";
            this.lblAddressBusValue.Size = new System.Drawing.Size(52, 29);
            this.lblAddressBusValue.TabIndex = 47;
            this.lblAddressBusValue.Text = "000";
            // 
            // lblDataBusValue
            // 
            this.lblDataBusValue.AutoSize = true;
            this.lblDataBusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBusValue.Location = new System.Drawing.Point(421, 588);
            this.lblDataBusValue.Name = "lblDataBusValue";
            this.lblDataBusValue.Size = new System.Drawing.Size(84, 29);
            this.lblDataBusValue.TabIndex = 46;
            this.lblDataBusValue.Text = "00 000";
            // 
            // lblRAMCellValue
            // 
            this.lblRAMCellValue.AutoSize = true;
            this.lblRAMCellValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRAMCellValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMCellValue.Location = new System.Drawing.Point(149, 463);
            this.lblRAMCellValue.Name = "lblRAMCellValue";
            this.lblRAMCellValue.Size = new System.Drawing.Size(84, 29);
            this.lblRAMCellValue.TabIndex = 45;
            this.lblRAMCellValue.Text = "00 000";
            // 
            // lblRAMCell
            // 
            this.lblRAMCell.AutoSize = true;
            this.lblRAMCell.BackColor = System.Drawing.Color.Transparent;
            this.lblRAMCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMCell.Location = new System.Drawing.Point(165, 107);
            this.lblRAMCell.Name = "lblRAMCell";
            this.lblRAMCell.Size = new System.Drawing.Size(52, 29);
            this.lblRAMCell.TabIndex = 44;
            this.lblRAMCell.Text = "000";
            // 
            // lblAccumulator
            // 
            this.lblAccumulator.AutoSize = true;
            this.lblAccumulator.BackColor = System.Drawing.Color.Transparent;
            this.lblAccumulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumulator.Location = new System.Drawing.Point(843, 287);
            this.lblAccumulator.Name = "lblAccumulator";
            this.lblAccumulator.Size = new System.Drawing.Size(84, 29);
            this.lblAccumulator.TabIndex = 43;
            this.lblAccumulator.Text = "00 000";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 712);
            this.Controls.Add(this.gbProject);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.gbMicroCode);
            this.Controls.Add(this.btnShowSettings);
            this.Controls.Add(this.gbMacroCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timmethy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.gbMicroCode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordMacro)).EndInit();
            this.gbMacroCode.ResumeLayout(false);
            this.gbMacroCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelay)).EndInit();
            this.gbProject.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacroCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccumulatorZeroStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbMicroCode;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.CheckBox btnRecordMacro;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtRecordMacroName;
        internal System.Windows.Forms.NumericUpDown nudRecordMacro;
        internal System.Windows.Forms.Button btnLoadMicroCode;
        internal System.Windows.Forms.Button btnPerformMicroStep;
        internal System.Windows.Forms.Button btnSaveMicroCode;
        internal System.Windows.Forms.Button btnShowSettings;
        internal System.Windows.Forms.CheckBox cbShowControlUnit;
        internal System.Windows.Forms.GroupBox gbMacroCode;
        internal System.Windows.Forms.Label lVelocity;
        internal System.Windows.Forms.Button btnPauseProgramExecution;
        internal System.Windows.Forms.Button btnExecuteProgram;
        internal System.Windows.Forms.Button btnPerformMacroStep;
        internal System.Windows.Forms.Button btnResetRegisters;
        internal System.Windows.Forms.Button btnSaveMacroCode;
        internal System.Windows.Forms.Button btnLoadMacroCode;
        internal System.Windows.Forms.Button btnResetMacroCode;
        internal System.Windows.Forms.TrackBar tbDelay;
        private DoubleBufferedPanel mainPanel;
        internal System.Windows.Forms.Button btnBasisRegMinusDataBusToDataBus;
        internal System.Windows.Forms.Button btnInsRegToAccumulator;
        internal System.Windows.Forms.Label lblBasisReg;
        internal System.Windows.Forms.Button btnDataBusToBasisReg;
        internal System.Windows.Forms.Button btnInsRegPlusProgramCounter;
        internal System.Windows.Forms.Button btnProgramCounterToAddressBus;
        internal System.Windows.Forms.Button btnConditionalIncrementProgramCounter;
        internal System.Windows.Forms.Button btnIncrementProgramCounter;
        internal System.Windows.Forms.Button btnInsRegToAddressBus;
        internal System.Windows.Forms.Button btnInsRegToProgramCounter;
        internal System.Windows.Forms.Button btnResetMicroCodePointer;
        internal System.Windows.Forms.Button btnInsRegToMicroCode;
        internal System.Windows.Forms.Button btnDataBusToInsReg;
        internal System.Windows.Forms.DataGridView dgvMicroCode;
        internal System.Windows.Forms.DataGridView dgvMacroCode;
        internal System.Windows.Forms.Label lblMCCurrentCmd;
        internal System.Windows.Forms.Label lblMCCurrent;
        internal System.Windows.Forms.Label lblMCCell;
        internal System.Windows.Forms.Label lblInsRegLoCode;
        internal System.Windows.Forms.Label lblInsRegHiCode;
        internal System.Windows.Forms.Label lblProgramCounter;
        internal System.Windows.Forms.Button btnMemoryToDataBus;
        internal System.Windows.Forms.Button btnDataBusToMemory;
        internal System.Windows.Forms.Button btnDecrementAccumulator;
        internal System.Windows.Forms.Button btnIncrementAccumulator;
        internal System.Windows.Forms.Button btnResetAccumulator;
        internal System.Windows.Forms.Button btnAccumulatorToDataBus;
        internal System.Windows.Forms.Button btnDataBusToAccumulator;
        internal System.Windows.Forms.Button btnSubtractDataBusFromAccumulator;
        internal System.Windows.Forms.Button btnAddDataBusToAccumulator;
        internal System.Windows.Forms.PictureBox pbAccumulatorZeroStatus;
        internal System.Windows.Forms.Button btnSetDataBusValue;
        internal System.Windows.Forms.TextBox txtDataBusValue;
        internal System.Windows.Forms.Button btnSetAddressBusValue;
        internal System.Windows.Forms.TextBox txtAddressBusValue;
        internal System.Windows.Forms.Label lblAddressBusValue;
        internal System.Windows.Forms.Label lblDataBusValue;
        internal System.Windows.Forms.Label lblRAMCellValue;
        internal System.Windows.Forms.Label lblRAMCell;
        internal System.Windows.Forms.Label lblAccumulator;
        internal System.Windows.Forms.Button btnStopProgramExecution;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbProject;
        internal System.Windows.Forms.Button btnLoadProject;
        internal System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

