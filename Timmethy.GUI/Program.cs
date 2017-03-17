// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: Program.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Timmethy.GUI {
    internal static class Program {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}