using System.Diagnostics;
using System.Windows.Forms;

namespace Timmethy.GUI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://creativecommons.org/licenses/by-nc-sa/4.0/");
        }

        private void lnkBase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://www.inf-schule.de/rechner/johnny");
        }

        private void lnkIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://www.doublejdesign.co.uk/");
        }
    }
}
