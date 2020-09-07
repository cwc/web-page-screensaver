using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    partial class PrefsByScreenUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer _components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._components = new Container();
            this._numericUpDownSecondsToDisplay = new NumericUpDown();
            this._labelSecondsToDisplay = new Label();
            this._checkBoxShuffle = new CheckBox();
            this._listViewURLs = new ListView();
            this._buttonAddURL = new Button();
            this._buttonUp = new Button();
            this._toolTipURLButtons = new ToolTip(this._components);
            this._buttonDown = new Button();
            this._buttonDeleteURL = new Button();
            this._tableLayoutPanelMain = new TableLayoutPanel();
            this._tableLayoutPanelMainTop = new TableLayoutPanel();
            this._tableLayoutPanelMainBottom = new TableLayoutPanel();
            ((ISupportInitialize)(this._numericUpDownSecondsToDisplay)).BeginInit();
            this._tableLayoutPanelMain.SuspendLayout();
            this._tableLayoutPanelMainTop.SuspendLayout();
            this._tableLayoutPanelMainBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // _numericUpDownSecondsToDisplay
            // 
            this._numericUpDownSecondsToDisplay.Anchor = AnchorStyles.Right;
            this._numericUpDownSecondsToDisplay.Location = new Point(315, 14);
            this._numericUpDownSecondsToDisplay.Margin = new Padding(4);
            this._numericUpDownSecondsToDisplay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this._numericUpDownSecondsToDisplay.Name = "_numericUpDownSecondsToDisplay";
            this._numericUpDownSecondsToDisplay.Size = new Size(80, 39);
            this._numericUpDownSecondsToDisplay.TabIndex = 6;
            this._numericUpDownSecondsToDisplay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // _labelSecondsToDisplay
            // 
            this._labelSecondsToDisplay.Anchor = AnchorStyles.Left;
            this._labelSecondsToDisplay.AutoSize = true;
            this._labelSecondsToDisplay.Location = new Point(405, 18);
            this._labelSecondsToDisplay.Margin = new Padding(6, 0, 6, 0);
            this._labelSecondsToDisplay.Name = "_labelSecondsToDisplay";
            this._labelSecondsToDisplay.Size = new Size(314, 32);
            this._labelSecondsToDisplay.TabIndex = 7;
            this._labelSecondsToDisplay.Text = "Seconds to display each site";
            this._labelSecondsToDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _checkBoxShuffle
            // 
            this._checkBoxShuffle.AutoSize = true;
            this._checkBoxShuffle.Dock = DockStyle.Left;
            this._checkBoxShuffle.Location = new Point(6, 7);
            this._checkBoxShuffle.Margin = new Padding(6, 7, 6, 7);
            this._checkBoxShuffle.Name = "_checkBoxShuffle";
            this._checkBoxShuffle.Size = new Size(267, 54);
            this._checkBoxShuffle.TabIndex = 5;
            this._checkBoxShuffle.Text = "Shuffle display order";
            this._checkBoxShuffle.UseVisualStyleBackColor = true;
            // 
            // _listViewURLs
            // 
            this._listViewURLs.Dock = DockStyle.Fill;
            this._listViewURLs.HideSelection = false;
            this._listViewURLs.LabelEdit = true;
            this._listViewURLs.Location = new Point(4, 79);
            this._listViewURLs.Margin = new Padding(4, 5, 4, 5);
            this._listViewURLs.Name = "_listViewURLs";
            this._listViewURLs.Size = new Size(723, 442);
            this._listViewURLs.TabIndex = 0;
            this._listViewURLs.UseCompatibleStateImageBehavior = false;
            this._listViewURLs.View = View.List;
            // 
            // _buttonAddURL
            // 
            this._buttonAddURL.Location = new Point(8, 8);
            this._buttonAddURL.Margin = new Padding(4);
            this._buttonAddURL.Name = "_buttonAddURL";
            this._buttonAddURL.Size = new Size(150, 44);
            this._buttonAddURL.TabIndex = 11;
            this._buttonAddURL.Text = "Add URL";
            this._buttonAddURL.UseVisualStyleBackColor = true;
            this._buttonAddURL.Click += new EventHandler(this.AddUrlButton_Click);
            // 
            // _buttonUp
            // 
            this._buttonUp.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this._buttonUp.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
            this._buttonUp.Location = new Point(619, 8);
            this._buttonUp.Margin = new Padding(4);
            this._buttonUp.Name = "_buttonUp";
            this._buttonUp.Size = new Size(44, 44);
            this._buttonUp.TabIndex = 3;
            this._buttonUp.Text = "▲";
            this._toolTipURLButtons.SetToolTip(this._buttonUp, "Move selected URLs up");
            this._buttonUp.UseVisualStyleBackColor = true;
            this._buttonUp.Click += new EventHandler(this.MoveAllSelectedUrlsUp_Click);
            // 
            // _buttonDown
            // 
            this._buttonDown.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
            this._buttonDown.Location = new Point(671, 8);
            this._buttonDown.Margin = new Padding(4);
            this._buttonDown.Name = "_buttonDown";
            this._buttonDown.Size = new Size(44, 44);
            this._buttonDown.TabIndex = 12;
            this._buttonDown.Text = "▼";
            this._toolTipURLButtons.SetToolTip(this._buttonDown, "Move selected URLs down");
            this._buttonDown.UseVisualStyleBackColor = true;
            this._buttonDown.Click += new EventHandler(this.MoveAllSelectedUrlsDown_Click);
            // 
            // _buttonDeleteURL
            // 
            this._buttonDeleteURL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this._buttonDeleteURL.ForeColor = Color.Black;
            this._buttonDeleteURL.Location = new Point(166, 8);
            this._buttonDeleteURL.Margin = new Padding(4);
            this._buttonDeleteURL.Name = "_buttonDeleteURL";
            this._buttonDeleteURL.Size = new Size(150, 44);
            this._buttonDeleteURL.TabIndex = 13;
            this._buttonDeleteURL.Text = "Delete URL";
            this._toolTipURLButtons.SetToolTip(this._buttonDeleteURL, "DELETE selected URLs");
            this._buttonDeleteURL.UseVisualStyleBackColor = true;
            this._buttonDeleteURL.Click += new EventHandler(this.DeleteAllSelectedUrls_Click);
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.AutoSize = true;
            this._tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMain.ColumnCount = 1;
            this._tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainTop, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._listViewURLs, 0, 1);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainBottom, 0, 2);
            this._tableLayoutPanelMain.Dock = DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new Point(0, 0);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 3;
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            this._tableLayoutPanelMain.Size = new Size(731, 600);
            this._tableLayoutPanelMain.TabIndex = 14;
            // 
            // _tableLayoutPanelMainTop
            // 
            this._tableLayoutPanelMainTop.AutoSize = true;
            this._tableLayoutPanelMainTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainTop.ColumnCount = 4;
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle());
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonAddURL, 0, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonDown, 3, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonUp, 2, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonDeleteURL, 1, 0);
            this._tableLayoutPanelMainTop.Dock = DockStyle.Fill;
            this._tableLayoutPanelMainTop.Location = new Point(4, 4);
            this._tableLayoutPanelMainTop.Margin = new Padding(4);
            this._tableLayoutPanelMainTop.Name = "_tableLayoutPanelMainTop";
            this._tableLayoutPanelMainTop.Padding = new Padding(4);
            this._tableLayoutPanelMainTop.RowCount = 1;
            this._tableLayoutPanelMainTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMainTop.Size = new Size(723, 66);
            this._tableLayoutPanelMainTop.TabIndex = 0;
            // 
            // _tableLayoutPanelMainBottom
            // 
            this._tableLayoutPanelMainBottom.AutoSize = true;
            this._tableLayoutPanelMainBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainBottom.ColumnCount = 3;
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle());
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle());
            this._tableLayoutPanelMainBottom.Controls.Add(this._checkBoxShuffle, 0, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._labelSecondsToDisplay, 2, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._numericUpDownSecondsToDisplay, 1, 0);
            this._tableLayoutPanelMainBottom.Dock = DockStyle.Fill;
            this._tableLayoutPanelMainBottom.Location = new Point(3, 529);
            this._tableLayoutPanelMainBottom.Name = "_tableLayoutPanelMainBottom";
            this._tableLayoutPanelMainBottom.RowCount = 1;
            this._tableLayoutPanelMainBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.Size = new Size(725, 68);
            this._tableLayoutPanelMainBottom.TabIndex = 1;
            // 
            // PrefsByScreenUserControl
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "PrefsByScreenUserControl";
            this.Size = new Size(731, 600);
            ((ISupportInitialize)(this._numericUpDownSecondsToDisplay)).EndInit();
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this._tableLayoutPanelMainTop.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TableLayoutPanel _tableLayoutPanelMain;

        private TableLayoutPanel _tableLayoutPanelMainTop;
        private Button _buttonAddURL;
        private Button _buttonDeleteURL;
        private Button _buttonUp;
        private Button _buttonDown;

        public ListView _listViewURLs;

        private TableLayoutPanel _tableLayoutPanelMainBottom;
        public CheckBox _checkBoxShuffle;
        public NumericUpDown _numericUpDownSecondsToDisplay;
        private Label _labelSecondsToDisplay;

        private ToolTip _toolTipURLButtons;
    }
}
