using System.Windows.Forms;

namespace Timmethy.GUI {
    partial class FrmRamCellEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRamCellEditor));
            this.lblAdr = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblLo = new System.Windows.Forms.Label();
            this.txtHi = new System.Windows.Forms.TextBox();
            this.txtLo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.imgButtons = new System.Windows.Forms.ImageList(this.components);
            this.btnSetZero = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMacros = new System.Windows.Forms.ComboBox();
            this.mPMCellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mPMCellBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Location = new System.Drawing.Point(9, 11);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(45, 13);
            this.lblAdr.TabIndex = 0;
            this.lblAdr.Text = "Address";
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Location = new System.Drawing.Point(6, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(17, 13);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "Hi";
            // 
            // lblLo
            // 
            this.lblLo.AutoSize = true;
            this.lblLo.Location = new System.Drawing.Point(119, 0);
            this.lblLo.Name = "lblLo";
            this.lblLo.Size = new System.Drawing.Size(19, 13);
            this.lblLo.TabIndex = 2;
            this.lblLo.Text = "Lo";
            // 
            // txtHi
            // 
            this.txtHi.BackColor = System.Drawing.Color.Yellow;
            this.txtHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHi.Location = new System.Drawing.Point(6, 13);
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(60, 38);
            this.txtHi.TabIndex = 3;
            this.txtHi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtLo
            // 
            this.txtLo.BackColor = System.Drawing.Color.Yellow;
            this.txtLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLo.Location = new System.Drawing.Point(122, 13);
            this.txtLo.Name = "txtLo";
            this.txtLo.Size = new System.Drawing.Size(60, 38);
            this.txtLo.TabIndex = 3;
            this.txtLo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Yellow;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 16);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 31);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "000:";
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.ImageKey = "Accept-icon.png";
            this.btnApply.ImageList = this.imgButtons;
            this.btnApply.Location = new System.Drawing.Point(13, 128);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(82, 40);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButtons.Images.SetKeyName(0, "Accept-icon.png");
            this.imgButtons.Images.SetKeyName(1, "Delete-icon.png");
            this.imgButtons.Images.SetKeyName(2, "Reload-icon.png");
            // 
            // btnSetZero
            // 
            this.btnSetZero.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSetZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetZero.ImageKey = "(Keine)";
            this.btnSetZero.ImageList = this.imgButtons;
            this.btnSetZero.Location = new System.Drawing.Point(144, 128);
            this.btnSetZero.Name = "btnSetZero";
            this.btnSetZero.Size = new System.Drawing.Size(82, 40);
            this.btnSetZero.TabIndex = 5;
            this.btnSetZero.Text = "00 000";
            this.btnSetZero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetZero.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageKey = "Delete-icon.png";
            this.btnCancel.ImageList = this.imgButtons;
            this.btnCancel.Location = new System.Drawing.Point(275, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbMacros
            // 
            this.cbMacros.DataSource = this.mPMCellBindingSource;
            this.cbMacros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMacros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMacros.FormattingEnabled = true;
            this.cbMacros.ItemHeight = 16;
            this.cbMacros.Location = new System.Drawing.Point(6, 60);
            this.cbMacros.Name = "cbMacros";
            this.cbMacros.Size = new System.Drawing.Size(102, 24);
            this.cbMacros.TabIndex = 6;
            this.cbMacros.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbMacros_Format);
            // 
            // mPMCellBindingSource
            // 
            this.mPMCellBindingSource.DataSource = typeof(Timmethy.Core.Memory.VisualizedCell.MicroProgramMemoryCell);
            this.mPMCellBindingSource.Filter = "";
            this.mPMCellBindingSource.PositionChanged += new System.EventHandler(this.mPMCellBindingSource_PositionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 95);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblLo);
            this.panel2.Controls.Add(this.lblHi);
            this.panel2.Controls.Add(this.cbMacros);
            this.panel2.Controls.Add(this.txtLo);
            this.panel2.Controls.Add(this.txtHi);
            this.panel2.Location = new System.Drawing.Point(120, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 95);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(117, 11);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // FrmRamCellEditor
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 174);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSetZero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblAdr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRamCellEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit RAM Entry";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmRamCellEditor_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.mPMCellBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblLo;
        private System.Windows.Forms.TextBox txtHi;
        private System.Windows.Forms.TextBox txtLo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSetZero;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbMacros;
        private System.Windows.Forms.BindingSource mPMCellBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Label lblData;
        private ImageList imgButtons;
    }
}