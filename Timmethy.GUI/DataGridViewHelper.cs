using System.Windows.Forms;

namespace Timmethy.GUI {
    internal static class DataGridViewHelper {

        internal static void SelectAndScrollTo(this DataGridView dgv, int rowIndex, bool multiSelect = false) {
            if (!multiSelect) dgv.ClearSelection();
            dgv.Rows[rowIndex].Selected = true;
            if (!dgv.Rows[rowIndex].Displayed)
                dgv.FirstDisplayedScrollingRowIndex = rowIndex;
        }

    }
}
