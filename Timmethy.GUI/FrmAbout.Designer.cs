namespace Timmethy.GUI
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.rtfAbout = new System.Windows.Forms.RichTextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkLicense = new System.Windows.Forms.LinkLabel();
            this.lnkBase = new System.Windows.Forms.LinkLabel();
            this.lnkIcons = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfAbout
            // 
            this.rtfAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfAbout.Location = new System.Drawing.Point(12, 12);
            this.rtfAbout.Name = "rtfAbout";
            this.rtfAbout.ReadOnly = true;
            this.rtfAbout.Size = new System.Drawing.Size(357, 129);
            this.rtfAbout.TabIndex = 2;
            this.rtfAbout.Text = resources.GetString("rtfAbout.Text");
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::Timmethy.GUI.Properties.Resources.by_nc_sa_eu;
            this.PictureBox1.Location = new System.Drawing.Point(126, 133);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(126, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // lnkLicense
            // 
            this.lnkLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLicense.LinkArea = new System.Windows.Forms.LinkArea(44, 80);
            this.lnkLicense.Location = new System.Drawing.Point(12, 193);
            this.lnkLicense.Name = "lnkLicense";
            this.lnkLicense.Size = new System.Drawing.Size(357, 49);
            this.lnkLicense.TabIndex = 5;
            this.lnkLicense.TabStop = true;
            this.lnkLicense.Text = "Timmethy by Tim Gubener is licensed under a\r\nCreative Commons Attribution-NonComm" +
    "ercial-ShareAlike 4.0 International License.";
            this.lnkLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkLicense.UseCompatibleTextRendering = true;
            this.lnkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicense_LinkClicked);
            // 
            // lnkBase
            // 
            this.lnkBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBase.LinkArea = new System.Windows.Forms.LinkArea(20, 39);
            this.lnkBase.Location = new System.Drawing.Point(12, 235);
            this.lnkBase.Name = "lnkBase";
            this.lnkBase.Size = new System.Drawing.Size(357, 33);
            this.lnkBase.TabIndex = 6;
            this.lnkBase.TabStop = true;
            this.lnkBase.Text = "Based on a work at\r\nhttp://www.inf-schule.de/rechner/johnny.";
            this.lnkBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkBase.UseCompatibleTextRendering = true;
            this.lnkBase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBase_LinkClicked);
            // 
            // lnkIcons
            // 
            this.lnkIcons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkIcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIcons.LinkArea = new System.Windows.Forms.LinkArea(30, 31);
            this.lnkIcons.Location = new System.Drawing.Point(12, 265);
            this.lnkIcons.Name = "lnkIcons";
            this.lnkIcons.Size = new System.Drawing.Size(357, 32);
            this.lnkIcons.TabIndex = 7;
            this.lnkIcons.TabStop = true;
            this.lnkIcons.Text = "Icons\' copyright goes all to\r\nhttp://www.doublejdesign.co.uk/";
            this.lnkIcons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkIcons.UseCompatibleTextRendering = true;
            this.lnkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIcons_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(153, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 336);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkIcons);
            this.Controls.Add(this.lnkBase);
            this.Controls.Add(this.lnkLicense);
            this.Controls.Add(this.rtfAbout);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox rtfAbout;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.LinkLabel lnkLicense;
        internal System.Windows.Forms.LinkLabel lnkBase;
        internal System.Windows.Forms.LinkLabel lnkIcons;
        internal System.Windows.Forms.Button btnClose;
    }
}