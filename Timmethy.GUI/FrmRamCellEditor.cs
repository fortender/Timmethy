// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: frmRamCellEditor.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timmethy.Core.Memory.VisualizedCell;

namespace Timmethy.GUI {
    public partial class FrmRamCellEditor : Form {
        public FrmRamCellEditor() {
            InitializeComponent();
        }

        public FrmRamCellEditor(MicroProgramMemoryCellContainer mpm, HighLowValueCell cell) : this() {
            lblAddress.Text = cell.Address.ToString("000:");
            txtHi.Text = cell.Hi.ToString("00");
            txtLo.Text = cell.Lo.ToString("000");
            mPMCellBindingSource.DataSource = mpm.Where(c => !string.IsNullOrEmpty(c.MacroName));
            mPMCellBindingSource.Position = cell.Hi;
        }

        public int HiCode => int.Parse(txtHi.Text);
        public int LoCode => int.Parse(txtLo.Text);

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbMacros_Format(object sender, ListControlConvertEventArgs e) {
            var cell = (MicroProgramMemoryCell) e.ListItem;
            e.Value = $"{cell.Address/10:00:} {(cell.MacroName == "fetch" ? null : cell.MacroName)}";
        }

        private void mPMCellBindingSource_PositionChanged(object sender, EventArgs e) {
            var microProgramMemoryCell = mPMCellBindingSource.Current as MicroProgramMemoryCell;
            if (microProgramMemoryCell != null)
                txtHi.Text = (microProgramMemoryCell.Address/10).ToString("00");
        }

        #region Drawing

        private void FrmRamCellEditor_Paint(object sender, PaintEventArgs e) {
            using (var gr = e.Graphics)
            {
                gr.FillRectangle(Brushes.Yellow, 12, 43, 343, 35);
                gr.DrawRectangle(Pens.Black, 12, 43, 343, 35);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            using (var gr = e.Graphics)
            {
                gr.FillRectangle(Brushes.Yellow, 0, 14, 345, 35);
                gr.DrawRectangle(Pens.Black, 0, 14, 345, 35);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
            using (var gr = e.Graphics)
            {
                gr.FillRectangle(Brushes.Yellow, 0, 14, 232, 35);
                gr.DrawRectangle(Pens.Black, 0, 14, 232, 35);
            }
        }

        #endregion
    }
}