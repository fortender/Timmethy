// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: DoubleBufferedPanel.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System.Windows.Forms;

namespace Timmethy.GUI {
    /// <summary>
    ///     Advanced Panel which enables the DoubleBuffered feature that is hidden by default.
    ///     Is needed to reduce flickering when multiple controls have to be refreshed.
    /// </summary>
    public class DoubleBufferedPanel : Panel {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DoubleBufferedPanel" /> class.
        /// </summary>
        public DoubleBufferedPanel() {
            // ReSharper disable once VirtualMemberCallInConstructor
            DoubleBuffered = true;
        }
    }
}