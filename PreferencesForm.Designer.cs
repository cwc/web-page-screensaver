namespace pl.polidea.lab.Web_Page_Screensaver
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
            this.label1 = new System.Windows.Forms.Label();
            this.llProjectLocationUrl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cbCloseOnActivity = new System.Windows.Forms.CheckBox();
            this.nudRotationInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUrls = new System.Windows.Forms.ListBox();
            this.tbUrlToAdd = new System.Windows.Forms.TextBox();
            this.addUrlButton = new System.Windows.Forms.Button();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Page Screensaver";
            // 
            // llProjectLocationUrl
            // 
            this.llProjectLocationUrl.AutoSize = true;
            this.llProjectLocationUrl.Location = new System.Drawing.Point(29, 31);
            this.llProjectLocationUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llProjectLocationUrl.Name = "llProjectLocationUrl";
            this.llProjectLocationUrl.Size = new System.Drawing.Size(293, 17);
            this.llProjectLocationUrl.TabIndex = 1;
            this.llProjectLocationUrl.TabStop = true;
            this.llProjectLocationUrl.Text = "http://github.com/cwc/web-page-screensaver/";
            this.llProjectLocationUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProjectLocationUrl_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website URLs";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(136, 372);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(244, 372);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cbCloseOnActivity
            // 
            this.cbCloseOnActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCloseOnActivity.AutoSize = true;
            this.cbCloseOnActivity.Checked = true;
            this.cbCloseOnActivity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCloseOnActivity.Location = new System.Drawing.Point(20, 315);
            this.cbCloseOnActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCloseOnActivity.Name = "cbCloseOnActivity";
            this.cbCloseOnActivity.Size = new System.Drawing.Size(200, 21);
            this.cbCloseOnActivity.TabIndex = 6;
            this.cbCloseOnActivity.Text = "Close on mouse movement";
            this.cbCloseOnActivity.UseVisualStyleBackColor = true;
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRotationInterval.Location = new System.Drawing.Point(20, 283);
            this.nudRotationInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudRotationInterval.Name = "nudRotationInterval";
            this.nudRotationInterval.Size = new System.Drawing.Size(53, 22);
            this.nudRotationInterval.TabIndex = 7;
            this.nudRotationInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seconds to display each site";
            // 
            // lbUrls
            // 
            this.lbUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUrls.FormattingEnabled = true;
            this.lbUrls.ItemHeight = 16;
            this.lbUrls.Location = new System.Drawing.Point(20, 89);
            this.lbUrls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUrls.Name = "lbUrls";
            this.lbUrls.Size = new System.Drawing.Size(327, 148);
            this.lbUrls.TabIndex = 9;
            // 
            // tbUrlToAdd
            // 
            this.tbUrlToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrlToAdd.Location = new System.Drawing.Point(20, 247);
            this.tbUrlToAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUrlToAdd.Name = "tbUrlToAdd";
            this.tbUrlToAdd.Size = new System.Drawing.Size(240, 22);
            this.tbUrlToAdd.TabIndex = 10;
            // 
            // addUrlButton
            // 
            this.addUrlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUrlButton.Location = new System.Drawing.Point(271, 245);
            this.addUrlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Size = new System.Drawing.Size(77, 28);
            this.addUrlButton.TabIndex = 11;
            this.addUrlButton.Text = "Add";
            this.addUrlButton.UseVisualStyleBackColor = true;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // cbRandomize
            // 
            this.cbRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Location = new System.Drawing.Point(20, 343);
            this.cbRandomize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(160, 21);
            this.cbRandomize.TabIndex = 12;
            this.cbRandomize.Text = "Shuffle display order";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(369, 409);
            this.Controls.Add(this.cbRandomize);
            this.Controls.Add(this.addUrlButton);
            this.Controls.Add(this.tbUrlToAdd);
            this.Controls.Add(this.lbUrls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudRotationInterval);
            this.Controls.Add(this.cbCloseOnActivity);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llProjectLocationUrl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Web Page Screensaver Settings";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llProjectLocationUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox cbCloseOnActivity;
        private System.Windows.Forms.NumericUpDown nudRotationInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUrls;
        private System.Windows.Forms.TextBox tbUrlToAdd;
        private System.Windows.Forms.Button addUrlButton;
        private System.Windows.Forms.CheckBox cbRandomize;
    }
}