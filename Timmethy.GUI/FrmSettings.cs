// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: FrmSettings.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timmethy.Core.Configuration;
using Timmethy.Core.Helpers;

namespace Timmethy.GUI {
    public partial class FrmSettings : Form {
        private readonly Dictionary<RadioButton, SimulatorMode> _buttonModeRelationDictionary;

        public FrmSettings() {
            InitializeComponent();
        }

        public FrmSettings(SimulatorMode simulatorMode) : this() {
            _buttonModeRelationDictionary = new Dictionary<RadioButton, SimulatorMode>();
            foreach (KeyValuePair<string, Enum> mode in Enums.ToNameEnumDictionary(typeof(SimulatorMode)))
            {
                var rb = new RadioButton {
                    Parent = flpRadioButtons,
                    AutoSize = true,
                    Text = $@"{mode.Key} Mode ({mode.Value.GetDescription()})",
                    Checked = simulatorMode.ToString() == mode.Key
                };
                flpRadioButtons.Controls.Add(rb);
                _buttonModeRelationDictionary.Add(rb, (SimulatorMode) mode.Value);
            }
        }

        public SimulatorMode SelectedMode => _buttonModeRelationDictionary.Single(p => p.Key.Checked).Value;

        private void btnAbout_Click(object sender, EventArgs e) {
            using (Form frmAbout = new FrmAbout())
                frmAbout.ShowDialog();
        }
    }
}