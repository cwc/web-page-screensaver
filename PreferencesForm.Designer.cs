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
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Page Screensaver";
            // 
            // llProjectLocationUrl
            // 
            this.llProjectLocationUrl.AutoSize = true;
            this.llProjectLocationUrl.Location = new System.Drawing.Point(22, 25);
            this.llProjectLocationUrl.Name = "llProjectLocationUrl";
            this.llProjectLocationUrl.Size = new System.Drawing.Size(233, 13);
            this.llProjectLocationUrl.TabIndex = 1;
            this.llProjectLocationUrl.TabStop = true;
            this.llProjectLocationUrl.Text = "http://github.com/cwc/web-page-screensaver/";
            this.llProjectLocationUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProjectLocationUrl_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website URLs";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(102, 302);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(183, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cbCloseOnActivity
            // 
            this.cbCloseOnActivity.AutoSize = true;
            this.cbCloseOnActivity.Checked = true;
            this.cbCloseOnActivity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCloseOnActivity.Location = new System.Drawing.Point(15, 256);
            this.cbCloseOnActivity.Name = "cbCloseOnActivity";
            this.cbCloseOnActivity.Size = new System.Drawing.Size(153, 17);
            this.cbCloseOnActivity.TabIndex = 6;
            this.cbCloseOnActivity.Text = "Close on mouse movement";
            this.cbCloseOnActivity.UseVisualStyleBackColor = true;
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Location = new System.Drawing.Point(15, 230);
            this.nudRotationInterval.Name = "nudRotationInterval";
            this.nudRotationInterval.Size = new System.Drawing.Size(40, 20);
            this.nudRotationInterval.TabIndex = 7;
            this.nudRotationInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seconds to display each site";
            // 
            // lbUrls
            // 
            this.lbUrls.FormattingEnabled = true;
            this.lbUrls.Location = new System.Drawing.Point(15, 72);
            this.lbUrls.Name = "lbUrls";
            this.lbUrls.Size = new System.Drawing.Size(246, 121);
            this.lbUrls.TabIndex = 9;
            // 
            // tbUrlToAdd
            // 
            this.tbUrlToAdd.Location = new System.Drawing.Point(15, 201);
            this.tbUrlToAdd.Name = "tbUrlToAdd";
            this.tbUrlToAdd.Size = new System.Drawing.Size(181, 20);
            this.tbUrlToAdd.TabIndex = 10;
            // 
            // addUrlButton
            // 
            this.addUrlButton.Location = new System.Drawing.Point(203, 199);
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Size = new System.Drawing.Size(58, 23);
            this.addUrlButton.TabIndex = 11;
            this.addUrlButton.Text = "Add";
            this.addUrlButton.UseVisualStyleBackColor = true;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // cbRandomize
            // 
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Location = new System.Drawing.Point(15, 279);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(121, 17);
            this.cbRandomize.TabIndex = 12;
            this.cbRandomize.Text = "Shuffle display order";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(277, 332);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
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