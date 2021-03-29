namespace WebPageScreensaver
{
    internal partial class PrefsByScreenUserControl
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
            if (disposing && _components != null)
            {
                _components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._numericUpDownRotationInterval = new System.Windows.Forms.NumericUpDown();
            this._labelSecondsToDisplay = new System.Windows.Forms.Label();
            this._checkBoxShuffle = new System.Windows.Forms.CheckBox();
            this._listViewURLs = new System.Windows.Forms.ListView();
            this._buttonAddURL = new System.Windows.Forms.Button();
            this._buttonUp = new System.Windows.Forms.Button();
            this._toolTipURLButtons = new System.Windows.Forms.ToolTip(this.components);
            this._buttonDeleteURL = new System.Windows.Forms.Button();
            this._buttonDown = new System.Windows.Forms.Button();
            this._tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanelMainTop = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanelMainBottom = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownRotationInterval)).BeginInit();
            this._tableLayoutPanelMain.SuspendLayout();
            this._tableLayoutPanelMainTop.SuspendLayout();
            this._tableLayoutPanelMainBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // _numericUpDownRotationInterval
            // 
            this._numericUpDownRotationInterval.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._numericUpDownRotationInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._numericUpDownRotationInterval.Location = new System.Drawing.Point(98, 6);
            this._numericUpDownRotationInterval.Margin = new System.Windows.Forms.Padding(6);
            this._numericUpDownRotationInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this._numericUpDownRotationInterval.Name = "_numericUpDownRotationInterval";
            this._numericUpDownRotationInterval.Size = new System.Drawing.Size(50, 23);
            this._numericUpDownRotationInterval.TabIndex = 12;
            this._numericUpDownRotationInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._numericUpDownRotationInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // _labelSecondsToDisplay
            // 
            this._labelSecondsToDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labelSecondsToDisplay.AutoSize = true;
            this._labelSecondsToDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelSecondsToDisplay.Location = new System.Drawing.Point(160, 10);
            this._labelSecondsToDisplay.Margin = new System.Windows.Forms.Padding(6);
            this._labelSecondsToDisplay.Name = "_labelSecondsToDisplay";
            this._labelSecondsToDisplay.Size = new System.Drawing.Size(154, 15);
            this._labelSecondsToDisplay.Text = "Seconds to display each site";
            // 
            // _checkBoxShuffle
            // 
            this._checkBoxShuffle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._checkBoxShuffle.AutoSize = true;
            this._checkBoxShuffle.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this._checkBoxShuffle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._checkBoxShuffle.Location = new System.Drawing.Point(6, 8);
            this._checkBoxShuffle.Margin = new System.Windows.Forms.Padding(6);
            this._checkBoxShuffle.Name = "_checkBoxShuffle";
            this._checkBoxShuffle.Size = new System.Drawing.Size(63, 19);
            this._checkBoxShuffle.TabIndex = 11;
            this._checkBoxShuffle.Text = "Shuffle";
            this._checkBoxShuffle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._checkBoxShuffle.UseVisualStyleBackColor = true;
            // 
            // _listViewURLs
            // 
            this._listViewURLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listViewURLs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._listViewURLs.FullRowSelect = true;
            this._listViewURLs.GridLines = true;
            this._listViewURLs.HideSelection = false;
            this._listViewURLs.LabelEdit = true;
            this._listViewURLs.Location = new System.Drawing.Point(6, 41);
            this._listViewURLs.Margin = new System.Windows.Forms.Padding(6);
            this._listViewURLs.Name = "_listViewURLs";
            this._listViewURLs.Size = new System.Drawing.Size(308, 78);
            this._listViewURLs.TabIndex = 10;
            this._listViewURLs.UseCompatibleStateImageBehavior = false;
            this._listViewURLs.View = System.Windows.Forms.View.List;
            // 
            // _buttonAddURL
            // 
            this._buttonAddURL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._buttonAddURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonAddURL.Location = new System.Drawing.Point(6, 6);
            this._buttonAddURL.Margin = new System.Windows.Forms.Padding(6);
            this._buttonAddURL.Name = "_buttonAddURL";
            this._buttonAddURL.Size = new System.Drawing.Size(75, 23);
            this._buttonAddURL.TabIndex = 6;
            this._buttonAddURL.Text = "Add URL";
            this._buttonAddURL.UseVisualStyleBackColor = true;
            this._buttonAddURL.Click += new System.EventHandler(this.ButtonAddURL_Click);
            // 
            // _buttonUp
            // 
            this._buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._buttonUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonUp.Location = new System.Drawing.Point(256, 6);
            this._buttonUp.Margin = new System.Windows.Forms.Padding(6);
            this._buttonUp.Name = "_buttonUp";
            this._buttonUp.Size = new System.Drawing.Size(23, 23);
            this._buttonUp.TabIndex = 8;
            this._buttonUp.Text = "▲";
            this._toolTipURLButtons.SetToolTip(this._buttonUp, "Move selected URLs up");
            this._buttonUp.UseVisualStyleBackColor = true;
            this._buttonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // _buttonDeleteURL
            // 
            this._buttonDeleteURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._buttonDeleteURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonDeleteURL.ForeColor = System.Drawing.Color.Black;
            this._buttonDeleteURL.Location = new System.Drawing.Point(93, 6);
            this._buttonDeleteURL.Margin = new System.Windows.Forms.Padding(6);
            this._buttonDeleteURL.Name = "_buttonDeleteURL";
            this._buttonDeleteURL.Size = new System.Drawing.Size(75, 23);
            this._buttonDeleteURL.TabIndex = 7;
            this._buttonDeleteURL.Text = "Delete URL";
            this._toolTipURLButtons.SetToolTip(this._buttonDeleteURL, "DELETE selected URLs");
            this._buttonDeleteURL.UseVisualStyleBackColor = true;
            this._buttonDeleteURL.Click += new System.EventHandler(this.ButtonDeleteURL_Click);
            // 
            // _buttonDown
            // 
            this._buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._buttonDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonDown.Location = new System.Drawing.Point(291, 6);
            this._buttonDown.Margin = new System.Windows.Forms.Padding(6);
            this._buttonDown.Name = "_buttonDown";
            this._buttonDown.Size = new System.Drawing.Size(23, 23);
            this._buttonDown.TabIndex = 9;
            this._buttonDown.Text = "▼";
            this._toolTipURLButtons.SetToolTip(this._buttonDown, "Move selected URLs down");
            this._buttonDown.UseVisualStyleBackColor = true;
            this._buttonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.AutoSize = true;
            this._tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMain.ColumnCount = 1;
            this._tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainTop, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._listViewURLs, 0, 1);
            this._tableLayoutPanelMain.Controls.Add(this._tableLayoutPanelMainBottom, 0, 2);
            this._tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 3;
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tableLayoutPanelMain.Size = new System.Drawing.Size(320, 160);
            // 
            // _tableLayoutPanelMainTop
            // 
            this._tableLayoutPanelMainTop.AutoSize = true;
            this._tableLayoutPanelMainTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainTop.ColumnCount = 4;
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tableLayoutPanelMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonAddURL, 0, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonDown, 3, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonUp, 2, 0);
            this._tableLayoutPanelMainTop.Controls.Add(this._buttonDeleteURL, 1, 0);
            this._tableLayoutPanelMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMainTop.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMainTop.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMainTop.Name = "_tableLayoutPanelMainTop";
            this._tableLayoutPanelMainTop.RowCount = 1;
            this._tableLayoutPanelMainTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMainTop.Size = new System.Drawing.Size(320, 35);
            // 
            // _tableLayoutPanelMainBottom
            // 
            this._tableLayoutPanelMainBottom.AutoSize = true;
            this._tableLayoutPanelMainBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanelMainBottom.ColumnCount = 3;
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelMainBottom.Controls.Add(this._checkBoxShuffle, 0, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._labelSecondsToDisplay, 2, 0);
            this._tableLayoutPanelMainBottom.Controls.Add(this._numericUpDownRotationInterval, 1, 0);
            this._tableLayoutPanelMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMainBottom.Location = new System.Drawing.Point(0, 125);
            this._tableLayoutPanelMainBottom.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMainBottom.Name = "_tableLayoutPanelMainBottom";
            this._tableLayoutPanelMainBottom.RowCount = 1;
            this._tableLayoutPanelMainBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMainBottom.Size = new System.Drawing.Size(320, 35);
            // 
            // PrefsByScreenUserControl
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(320, 160);
            this.Name = "PrefsByScreenUserControl";
            this.Size = new System.Drawing.Size(320, 160);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownRotationInterval)).EndInit();
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this._tableLayoutPanelMainTop.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.ResumeLayout(false);
            this._tableLayoutPanelMainBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMain;

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMainTop;
        private System.Windows.Forms.Button _buttonAddURL;
        private System.Windows.Forms.Button _buttonDeleteURL;
        private System.Windows.Forms.Button _buttonUp;

        public System.Windows.Forms.ListView _listViewURLs;

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMainBottom;
        public System.Windows.Forms.CheckBox _checkBoxShuffle;
        public System.Windows.Forms.NumericUpDown _numericUpDownRotationInterval;
        private System.Windows.Forms.Label _labelSecondsToDisplay;

        private System.Windows.Forms.ToolTip _toolTipURLButtons;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button _buttonDown;
    }
}
