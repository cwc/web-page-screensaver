using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    partial class PreferencesForm
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
            this.components = new System.ComponentModel.Container();
            this._linkLabelProjectURL = new LinkLabel();
            this._tabControlScreens = new TabControl();
            this._tabPageScreen = new TabPage();
            this._labelWebsiteURLs = new Label();
            this._toolTipScreenMode = new ToolTip(this.components);
            this._radioButtonSeparateScreens = new RadioButton();
            this._radioButtonMirrorScreens = new RadioButton();
            this._radioButtonSpanScreens = new RadioButton();
            this._tableLayoutPanelMain = new TableLayoutPanel();
            this._tableLayoutPanelMainBottom = new TableLayoutPanel();
            this._buttonCancel = new Button();
            this._buttonOK = new Button();
            this._tableLayoutPanelMainTop = new TableLayoutPanel();
            this._labelMultiScreen = new Label();
            this._checkBoxCloseOnMouseMovement = new CheckBox();
            this._flowLayoutPanelMultiScreenButtons = new FlowLayoutPanel();
            this._prefsByScreenUserControl = new WebPageScreensaver.PrefsByScreenUserControl();
            this._tabControlScreens.SuspendLayout();
            this._tabPageScreen.SuspendLayout();
            this._tableLayoutPanelMain.SuspendLayout();
            this._tableLayoutPanelMainBottom.SuspendLayout();
            this._tableLayoutPanelMainTop.SuspendLayout();
            this._flowLayoutPanelMultiScreenButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // _linkLabelProjectURL
            // 
            this._linkLabelProjectURL.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left)));
            this._linkLabelProjectURL.AutoSize = true;
            this._linkLabelProjectURL.Location = new Point(6, 0);
            this._linkLabelProjectURL.Margin = new Padding(6, 0, 6, 0);
            this._linkLabelProjectURL.Name = "_linkLabelProjectURL";
            this._linkLabelProjectURL.Size = new Size(99, 59);
            this._linkLabelProjectURL.TabIndex = 1;
            this._linkLabelProjectURL.TabStop = true;
            this._linkLabelProjectURL.Text = "Website";
            this._linkLabelProjectURL.TextAlign = ContentAlignment.MiddleCenter;
            this._toolTipScreenMode.SetToolTip(this._linkLabelProjectURL, "http://github.com/carlossanlop/web-page-screensaver/");
            this._linkLabelProjectURL.LinkClicked += new LinkLabelLinkClickedEventHandler(this.llProjectLocationUrl_LinkClicked);
            // 
            // screenTabControl
            // 
            this._tabControlScreens.Controls.Add(this._tabPageScreen);
            this._tabControlScreens.Dock = DockStyle.Fill;
            this._tabControlScreens.Location = new Point(4, 186);
            this._tabControlScreens.Margin = new Padding(4, 5, 4, 5);
            this._tabControlScreens.Name = "screenTabControl";
            this._tabControlScreens.SelectedIndex = 0;
            this._tabControlScreens.Size = new Size(990, 697);
            this._tabControlScreens.TabIndex = 13;
            // 
            // screenTabPage1
            // 
            this._tabPageScreen.Controls.Add(this._prefsByScreenUserControl);
            this._tabPageScreen.Location = new Point(8, 46);
            this._tabPageScreen.Margin = new Padding(4, 5, 4, 5);
            this._tabPageScreen.Name = "screenTabPage1";
            this._tabPageScreen.Padding = new Padding(4, 5, 4, 5);
            this._tabPageScreen.Size = new Size(974, 643);
            this._tabPageScreen.TabIndex = 0;
            this._tabPageScreen.Text = "Screen 1";
            this._tabPageScreen.UseVisualStyleBackColor = true;
            // 
            // _labelWebsiteURLs
            // 
            this._labelWebsiteURLs.AutoSize = true;
            this._labelWebsiteURLs.Dock = DockStyle.Left;
            this._labelWebsiteURLs.Location = new Point(6, 122);
            this._labelWebsiteURLs.Margin = new Padding(6);
            this._labelWebsiteURLs.Name = "_labelWebsiteURLs";
            this._labelWebsiteURLs.Size = new Size(157, 53);
            this._labelWebsiteURLs.TabIndex = 2;
            this._labelWebsiteURLs.Text = "Website URLs";
            this._labelWebsiteURLs.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _radioButtonSeparateScreens
            // 
            this._radioButtonSeparateScreens.AutoSize = true;
            this._radioButtonSeparateScreens.Location = new Point(233, 9);
            this._radioButtonSeparateScreens.Margin = new Padding(4, 5, 4, 5);
            this._radioButtonSeparateScreens.Name = "_radioButtonSeparateScreens";
            this._radioButtonSeparateScreens.Size = new Size(138, 36);
            this._radioButtonSeparateScreens.TabIndex = 15;
            this._radioButtonSeparateScreens.TabStop = true;
            this._radioButtonSeparateScreens.Tag = "MultiScreenMode";
            this._radioButtonSeparateScreens.Text = "Separate";
            this._toolTipScreenMode.SetToolTip(this._radioButtonSeparateScreens, "Each to their own.");
            this._radioButtonSeparateScreens.UseVisualStyleBackColor = true;
            // 
            // _radioButtonMirrorScreens
            // 
            this._radioButtonMirrorScreens.AutoSize = true;
            this._radioButtonMirrorScreens.Location = new Point(114, 9);
            this._radioButtonMirrorScreens.Margin = new Padding(4, 5, 4, 5);
            this._radioButtonMirrorScreens.Name = "_radioButtonMirrorScreens";
            this._radioButtonMirrorScreens.Size = new Size(111, 36);
            this._radioButtonMirrorScreens.TabIndex = 26;
            this._radioButtonMirrorScreens.TabStop = true;
            this._radioButtonMirrorScreens.Tag = "MultiScreenMode";
            this._radioButtonMirrorScreens.Text = "Mirror";
            this._toolTipScreenMode.SetToolTip(this._radioButtonMirrorScreens, "One for All!");
            this._radioButtonMirrorScreens.UseVisualStyleBackColor = true;
            // 
            // _radioButtonSpanScreens
            // 
            this._radioButtonSpanScreens.AutoSize = true;
            this._radioButtonSpanScreens.Checked = true;
            this._radioButtonSpanScreens.Location = new Point(8, 9);
            this._radioButtonSpanScreens.Margin = new Padding(4, 5, 4, 5);
            this._radioButtonSpanScreens.Name = "_radioButtonSpanScreens";
            this._radioButtonSpanScreens.Size = new Size(98, 36);
            this._radioButtonSpanScreens.TabIndex = 21;
            this._radioButtonSpanScreens.TabStop = true;
            this._radioButtonSpanScreens.Tag = "MultiScreenMode";
            this._radioButtonSpanScreens.Text = "Span";
            this._toolTipScreenMode.SetToolTip(this._radioButtonSpanScreens, "All for One!");
            this._radioButtonSpanScreens.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.AutoSize = true;
            this._tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMain.ColumnCount = 1;
            this._tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Controls.Add(this._tabControlScreens, 0, 2);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainBottom, 0, 3);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainTop, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._labelWebsiteURLs, 0, 1);
            this._tableLayoutPanelMain.Dock = DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new Point(0, 0);
            this._tableLayoutPanelMain.Margin = new Padding(4);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 4;
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this._tableLayoutPanelMain.Size = new Size(998, 953);
            this._tableLayoutPanelMain.TabIndex = 19;
            // 
            // _tableLayoutPanelMainBottom
            // 
            this._tableLayoutPanelMainBottom.ColumnCount = 3;
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle());
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle());
            this._tableLayoutPanelMainBottom.Controls.Add(this._buttonCancel, 2, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._linkLabelProjectURL, 0, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._buttonOK, 1, 0);
            this._tableLayoutPanelMainBottom.Dock = DockStyle.Fill;
            this._tableLayoutPanelMainBottom.Location = new Point(3, 891);
            this._tableLayoutPanelMainBottom.Name = "_tableLayoutPanelMainBottom";
            this._tableLayoutPanelMainBottom.RowCount = 1;
            this._tableLayoutPanelMainBottom.RowStyles.Add(new RowStyle());
            this._tableLayoutPanelMainBottom.Size = new Size(992, 59);
            this._tableLayoutPanelMainBottom.TabIndex = 0;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = AnchorStyles.None;
            this._buttonCancel.DialogResult = DialogResult.Cancel;
            this._buttonCancel.Location = new Point(836, 7);
            this._buttonCancel.Margin = new Padding(6);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new Size(150, 44);
            this._buttonCancel.TabIndex = 6;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonOK
            // 
            this._buttonOK.Anchor = AnchorStyles.None;
            this._buttonOK.DialogResult = DialogResult.OK;
            this._buttonOK.Location = new Point(674, 7);
            this._buttonOK.Margin = new Padding(6);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new Size(150, 44);
            this._buttonOK.TabIndex = 8;
            this._buttonOK.Text = "OK";
            this._buttonOK.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanelMainTop
            // 
            this._tableLayoutPanelMainTop.ColumnCount = 2;
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this._tableLayoutPanelMainTop.Controls.Add(this._labelMultiScreen, 0, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._checkBoxCloseOnMouseMovement, 1, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._flowLayoutPanelMultiScreenButtons, 0, 1);
            this._tableLayoutPanelMainTop.Dock = DockStyle.Fill;
            this._tableLayoutPanelMainTop.Location = new Point(3, 3);
            this._tableLayoutPanelMainTop.Name = "_tableLayoutPanelMainTop";
            this._tableLayoutPanelMainTop.RowCount = 2;
            this._tableLayoutPanelMainTop.RowStyles.Add(new RowStyle());
            this._tableLayoutPanelMainTop.RowStyles.Add(new RowStyle());
            this._tableLayoutPanelMainTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this._tableLayoutPanelMainTop.Size = new Size(992, 110);
            this._tableLayoutPanelMainTop.TabIndex = 1;
            // 
            // _labelMultiScreen
            // 
            this._labelMultiScreen.AutoSize = true;
            this._labelMultiScreen.Dock = DockStyle.Left;
            this._labelMultiScreen.Location = new Point(6, 0);
            this._labelMultiScreen.Margin = new Padding(6, 0, 6, 0);
            this._labelMultiScreen.Name = "_labelMultiScreen";
            this._labelMultiScreen.Size = new Size(144, 50);
            this._labelMultiScreen.TabIndex = 17;
            this._labelMultiScreen.Text = "Multiscreen:";
            this._labelMultiScreen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _checkBoxCloseOnMouseMovement
            // 
            this._checkBoxCloseOnMouseMovement.AutoSize = true;
            this._checkBoxCloseOnMouseMovement.Checked = true;
            this._checkBoxCloseOnMouseMovement.CheckState = CheckState.Checked;
            this._checkBoxCloseOnMouseMovement.Dock = DockStyle.Left;
            this._checkBoxCloseOnMouseMovement.Location = new Point(502, 7);
            this._checkBoxCloseOnMouseMovement.Margin = new Padding(6, 7, 6, 7);
            this._checkBoxCloseOnMouseMovement.Name = "_checkBoxCloseOnMouseMovement";
            this._checkBoxCloseOnMouseMovement.Size = new Size(341, 36);
            this._checkBoxCloseOnMouseMovement.TabIndex = 20;
            this._checkBoxCloseOnMouseMovement.Text = "Close on mouse movement";
            this._checkBoxCloseOnMouseMovement.UseVisualStyleBackColor = true;
            // 
            // _flowLayoutPanelMultiScreenButtons
            // 
            this._flowLayoutPanelMultiScreenButtons.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this._flowLayoutPanelMultiScreenButtons.AutoSize = true;
            this._flowLayoutPanelMultiScreenButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._flowLayoutPanelMultiScreenButtons.Controls.Add(this._radioButtonSpanScreens);
            this._flowLayoutPanelMultiScreenButtons.Controls.Add(this._radioButtonMirrorScreens);
            this._flowLayoutPanelMultiScreenButtons.Controls.Add(this._radioButtonSeparateScreens);
            this._flowLayoutPanelMultiScreenButtons.Location = new Point(4, 54);
            this._flowLayoutPanelMultiScreenButtons.Margin = new Padding(4);
            this._flowLayoutPanelMultiScreenButtons.Name = "_flowLayoutPanelMultiScreenButtons";
            this._flowLayoutPanelMultiScreenButtons.Padding = new Padding(4);
            this._flowLayoutPanelMultiScreenButtons.Size = new Size(488, 54);
            this._flowLayoutPanelMultiScreenButtons.TabIndex = 22;
            // 
            // prefsByScreenUserControl1
            // 
            this._prefsByScreenUserControl.BackColor = Color.White;
            this._prefsByScreenUserControl.Dock = DockStyle.Fill;
            this._prefsByScreenUserControl.Location = new Point(4, 5);
            this._prefsByScreenUserControl.Margin = new Padding(0);
            this._prefsByScreenUserControl.Name = "prefsByScreenUserControl1";
            this._prefsByScreenUserControl.Size = new Size(966, 633);
            this._prefsByScreenUserControl.TabIndex = 25;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(998, 953);
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Margin = new Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(1024, 768);
            this.Name = "PreferencesForm";
            this.SizeGripStyle = SizeGripStyle.Show;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Web Page Screensaver Settings";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this._tabControlScreens.ResumeLayout(false);
            this._tabPageScreen.ResumeLayout(false);
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this._tableLayoutPanelMainBottom.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.PerformLayout();
            this._tableLayoutPanelMainTop.ResumeLayout(false);
            this._tableLayoutPanelMainTop.PerformLayout();
            this._flowLayoutPanelMultiScreenButtons.ResumeLayout(false);
            this._flowLayoutPanelMultiScreenButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel _tableLayoutPanelMain;

        private TableLayoutPanel _tableLayoutPanelMainTop;
        private FlowLayoutPanel _flowLayoutPanelMultiScreenButtons;
        private Label _labelMultiScreen;
        private RadioButton _radioButtonSpanScreens;
        private RadioButton _radioButtonMirrorScreens;
        private RadioButton _radioButtonSeparateScreens;
        private CheckBox _checkBoxCloseOnMouseMovement;

        private Label _labelWebsiteURLs;
        private TabControl _tabControlScreens;
        private TabPage _tabPageScreen;
        private PrefsByScreenUserControl _prefsByScreenUserControl;

        private TableLayoutPanel _tableLayoutPanelMainBottom;
        private LinkLabel _linkLabelProjectURL;
        private Button _buttonCancel;
        private Button _buttonOK;

        private ToolTip _toolTipScreenMode;
    }
}