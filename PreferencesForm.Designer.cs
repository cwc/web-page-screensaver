namespace WebPageScreensaver
{
    internal partial class PreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this._linkLabelProjectURL = new System.Windows.Forms.LinkLabel();
            this._tabControlScreens = new System.Windows.Forms.TabControl();
            this._tabPageScreen = new System.Windows.Forms.TabPage();
            this._labelWebsiteURLs = new System.Windows.Forms.Label();
            this._toolTipScreenMode = new System.Windows.Forms.ToolTip(this.components);
            this._radioButtonSeparateScreens = new System.Windows.Forms.RadioButton();
            this._radioButtonMirrorScreens = new System.Windows.Forms.RadioButton();
            this._radioButtonSpanScreens = new System.Windows.Forms.RadioButton();
            this._tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanelMainBottom = new System.Windows.Forms.TableLayoutPanel();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonOK = new System.Windows.Forms.Button();
            this._tableLayoutPanelMainTop = new System.Windows.Forms.TableLayoutPanel();
            this._checkBoxCloseOnMouseMovement = new System.Windows.Forms.CheckBox();
            this._labelMultiScreen = new System.Windows.Forms.Label();
            this._flowLayoutPanelMultiScreenMode = new System.Windows.Forms.FlowLayoutPanel();
            this._tabControlScreens.SuspendLayout();
            this._tableLayoutPanelMain.SuspendLayout();
            this._tableLayoutPanelMainBottom.SuspendLayout();
            this._tableLayoutPanelMainTop.SuspendLayout();
            this._flowLayoutPanelMultiScreenMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // _linkLabelProjectURL
            // 
            this._linkLabelProjectURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._linkLabelProjectURL.AutoSize = true;
            this._linkLabelProjectURL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._linkLabelProjectURL.Location = new System.Drawing.Point(6, 0);
            this._linkLabelProjectURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._linkLabelProjectURL.Name = "_linkLabelProjectURL";
            this._linkLabelProjectURL.Size = new System.Drawing.Size(662, 65);
            this._linkLabelProjectURL.TabIndex = 7;
            this._linkLabelProjectURL.TabStop = true;
            this._linkLabelProjectURL.Text = "Website";
            this._linkLabelProjectURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._linkLabelProjectURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelProjectURL_LinkClicked);
            // 
            // _tabControlScreens
            // 
            this._tabControlScreens.Controls.Add(this._tabPageScreen);
            this._tabControlScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControlScreens.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._tabControlScreens.Location = new System.Drawing.Point(0, 181);
            this._tabControlScreens.Margin = new System.Windows.Forms.Padding(0);
            this._tabControlScreens.Name = "_tabControlScreens";
            this._tabControlScreens.SelectedIndex = 0;
            this._tabControlScreens.Size = new System.Drawing.Size(998, 451);
            this._tabControlScreens.TabIndex = 6;
            // 
            // _tabPageScreen
            // 
            this._tabPageScreen.Location = new System.Drawing.Point(8, 46);
            this._tabPageScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tabPageScreen.Name = "_tabPageScreen";
            this._tabPageScreen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tabPageScreen.Size = new System.Drawing.Size(982, 397);
            this._tabPageScreen.TabIndex = 0;
            this._tabPageScreen.Text = "Screen 1";
            this._tabPageScreen.UseVisualStyleBackColor = true;
            // 
            // _labelWebsiteURLs
            // 
            this._labelWebsiteURLs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelWebsiteURLs.AutoSize = true;
            this._labelWebsiteURLs.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._labelWebsiteURLs.Location = new System.Drawing.Point(6, 122);
            this._labelWebsiteURLs.Margin = new System.Windows.Forms.Padding(6);
            this._labelWebsiteURLs.Name = "_labelWebsiteURLs";
            this._labelWebsiteURLs.Size = new System.Drawing.Size(986, 53);
            this._labelWebsiteURLs.TabIndex = 5;
            this._labelWebsiteURLs.Text = "Website URLs:";
            this._labelWebsiteURLs.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _radioButtonSeparateScreens
            // 
            this._radioButtonSeparateScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._radioButtonSeparateScreens.AutoSize = true;
            this._radioButtonSeparateScreens.Checked = true;
            this._radioButtonSeparateScreens.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._radioButtonSeparateScreens.Location = new System.Drawing.Point(6, 6);
            this._radioButtonSeparateScreens.Margin = new System.Windows.Forms.Padding(6);
            this._radioButtonSeparateScreens.Name = "_radioButtonSeparateScreens";
            this._radioButtonSeparateScreens.Size = new System.Drawing.Size(138, 36);
            this._radioButtonSeparateScreens.TabIndex = 1;
            this._radioButtonSeparateScreens.TabStop = true;
            this._radioButtonSeparateScreens.Tag = "MultiScreenMode";
            this._radioButtonSeparateScreens.Text = "Separate";
            this._toolTipScreenMode.SetToolTip(this._radioButtonSeparateScreens, "Each to their own!");
            this._radioButtonSeparateScreens.UseVisualStyleBackColor = true;
            this._radioButtonSeparateScreens.CheckedChanged += new System.EventHandler(this.RadioButtonMultiScreenMode_Checked);
            // 
            // _radioButtonMirrorScreens
            // 
            this._radioButtonMirrorScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._radioButtonMirrorScreens.AutoSize = true;
            this._radioButtonMirrorScreens.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._radioButtonMirrorScreens.Location = new System.Drawing.Point(156, 6);
            this._radioButtonMirrorScreens.Margin = new System.Windows.Forms.Padding(6);
            this._radioButtonMirrorScreens.Name = "_radioButtonMirrorScreens";
            this._radioButtonMirrorScreens.Size = new System.Drawing.Size(111, 36);
            this._radioButtonMirrorScreens.TabIndex = 2;
            this._radioButtonMirrorScreens.TabStop = true;
            this._radioButtonMirrorScreens.Tag = "MultiScreenMode";
            this._radioButtonMirrorScreens.Text = "Mirror";
            this._toolTipScreenMode.SetToolTip(this._radioButtonMirrorScreens, "One for All!");
            this._radioButtonMirrorScreens.UseVisualStyleBackColor = true;
            this._radioButtonMirrorScreens.CheckedChanged += new System.EventHandler(this.RadioButtonMultiScreenMode_Checked);
            // 
            // _radioButtonSpanScreens
            // 
            this._radioButtonSpanScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._radioButtonSpanScreens.AutoSize = true;
            this._radioButtonSpanScreens.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._radioButtonSpanScreens.Location = new System.Drawing.Point(279, 6);
            this._radioButtonSpanScreens.Margin = new System.Windows.Forms.Padding(6);
            this._radioButtonSpanScreens.Name = "_radioButtonSpanScreens";
            this._radioButtonSpanScreens.Size = new System.Drawing.Size(98, 36);
            this._radioButtonSpanScreens.TabIndex = 3;
            this._radioButtonSpanScreens.TabStop = true;
            this._radioButtonSpanScreens.Tag = "MultiScreenMode";
            this._radioButtonSpanScreens.Text = "Span";
            this._toolTipScreenMode.SetToolTip(this._radioButtonSpanScreens, "All for One!");
            this._radioButtonSpanScreens.UseVisualStyleBackColor = true;
            this._radioButtonSpanScreens.CheckedChanged += new System.EventHandler(this.RadioButtonMultiScreenMode_Checked);
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.AutoSize = true;
            this._tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMain.ColumnCount = 1;
            this._tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Controls.Add(this._tabControlScreens, 0, 2);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainBottom, 0, 3);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainTop, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._labelWebsiteURLs, 0, 1);
            this._tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 4;
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanelMain.Size = new System.Drawing.Size(998, 697);
            this._tableLayoutPanelMain.TabIndex = 19;
            // 
            // _tableLayoutPanelMainBottom
            // 
            this._tableLayoutPanelMainBottom.AutoSize = true;
            this._tableLayoutPanelMainBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainBottom.ColumnCount = 3;
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelMainBottom.Controls.Add(this._buttonCancel, 2, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._linkLabelProjectURL, 0, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._buttonOK, 1, 0);
            this._tableLayoutPanelMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMainBottom.Location = new System.Drawing.Point(0, 632);
            this._tableLayoutPanelMainBottom.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMainBottom.Name = "_tableLayoutPanelMainBottom";
            this._tableLayoutPanelMainBottom.RowCount = 1;
            this._tableLayoutPanelMainBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelMainBottom.Size = new System.Drawing.Size(998, 65);
            this._tableLayoutPanelMainBottom.TabIndex = 0;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._buttonCancel.Location = new System.Drawing.Point(842, 10);
            this._buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(150, 44);
            this._buttonCancel.TabIndex = 9;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _buttonOK
            // 
            this._buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonOK.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._buttonOK.Location = new System.Drawing.Point(680, 10);
            this._buttonOK.Margin = new System.Windows.Forms.Padding(6);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(150, 44);
            this._buttonOK.TabIndex = 8;
            this._buttonOK.Text = "OK";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // _tableLayoutPanelMainTop
            // 
            this._tableLayoutPanelMainTop.AutoSize = true;
            this._tableLayoutPanelMainTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainTop.ColumnCount = 2;
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelMainTop.Controls.Add(this._checkBoxCloseOnMouseMovement, 0, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._labelMultiScreen, 1, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._flowLayoutPanelMultiScreenMode, 1, 1);
            this._tableLayoutPanelMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMainTop.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMainTop.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMainTop.Name = "_tableLayoutPanelMainTop";
            this._tableLayoutPanelMainTop.RowCount = 2;
            this._tableLayoutPanelMainTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelMainTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelMainTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanelMainTop.Size = new System.Drawing.Size(998, 116);
            this._tableLayoutPanelMainTop.TabIndex = 1;
            // 
            // _checkBoxCloseOnMouseMovement
            // 
            this._checkBoxCloseOnMouseMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._checkBoxCloseOnMouseMovement.AutoSize = true;
            this._checkBoxCloseOnMouseMovement.Checked = true;
            this._checkBoxCloseOnMouseMovement.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxCloseOnMouseMovement.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._checkBoxCloseOnMouseMovement.Location = new System.Drawing.Point(6, 6);
            this._checkBoxCloseOnMouseMovement.Margin = new System.Windows.Forms.Padding(6);
            this._checkBoxCloseOnMouseMovement.Name = "_checkBoxCloseOnMouseMovement";
            this._checkBoxCloseOnMouseMovement.Size = new System.Drawing.Size(487, 36);
            this._checkBoxCloseOnMouseMovement.TabIndex = 4;
            this._checkBoxCloseOnMouseMovement.Text = "Close on mouse movement";
            this._checkBoxCloseOnMouseMovement.UseVisualStyleBackColor = true;
            // 
            // _labelMultiScreen
            // 
            this._labelMultiScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelMultiScreen.AutoSize = true;
            this._labelMultiScreen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._labelMultiScreen.Location = new System.Drawing.Point(505, 6);
            this._labelMultiScreen.Margin = new System.Windows.Forms.Padding(6);
            this._labelMultiScreen.Name = "_labelMultiScreen";
            this._labelMultiScreen.Size = new System.Drawing.Size(487, 36);
            this._labelMultiScreen.TabIndex = 0;
            this._labelMultiScreen.Text = "Multiscreen:";
            this._labelMultiScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _flowLayoutPanelMultiScreenMode
            // 
            this._flowLayoutPanelMultiScreenMode.AutoSize = true;
            this._flowLayoutPanelMultiScreenMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._flowLayoutPanelMultiScreenMode.Controls.Add(this._radioButtonSeparateScreens);
            this._flowLayoutPanelMultiScreenMode.Controls.Add(this._radioButtonMirrorScreens);
            this._flowLayoutPanelMultiScreenMode.Controls.Add(this._radioButtonSpanScreens);
            this._flowLayoutPanelMultiScreenMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanelMultiScreenMode.Location = new System.Drawing.Point(502, 51);
            this._flowLayoutPanelMultiScreenMode.Name = "_flowLayoutPanelMultiScreenMode";
            this._flowLayoutPanelMultiScreenMode.Size = new System.Drawing.Size(493, 62);
            this._flowLayoutPanelMultiScreenMode.TabIndex = 20;
            // 
            // PreferencesForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Web Page Screensaver Settings";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this._tabControlScreens.ResumeLayout(false);
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this._tableLayoutPanelMainBottom.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.PerformLayout();
            this._tableLayoutPanelMainTop.ResumeLayout(false);
            this._tableLayoutPanelMainTop.PerformLayout();
            this._flowLayoutPanelMultiScreenMode.ResumeLayout(false);
            this._flowLayoutPanelMultiScreenMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMain;

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMainTop;
        private System.Windows.Forms.Label _labelMultiScreen;
        private System.Windows.Forms.RadioButton _radioButtonSpanScreens;
        private System.Windows.Forms.RadioButton _radioButtonMirrorScreens;
        private System.Windows.Forms.RadioButton _radioButtonSeparateScreens;
        private System.Windows.Forms.ToolTip _toolTipScreenMode;
        private System.Windows.Forms.CheckBox _checkBoxCloseOnMouseMovement;

        private System.Windows.Forms.Label _labelWebsiteURLs;
        private System.Windows.Forms.TabControl _tabControlScreens;
        private System.Windows.Forms.TabPage _tabPageScreen;

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMainBottom;
        private System.Windows.Forms.LinkLabel _linkLabelProjectURL;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanelMultiScreenMode;

        private System.ComponentModel.IContainer components;
    }
}