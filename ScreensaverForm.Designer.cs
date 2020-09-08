namespace WebPageScreensaver
{
    partial class ScreensaverForm
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
            this._webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this._closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this._webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._webBrowser.Location = new System.Drawing.Point(0, 0);
            this._webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this._webBrowser.MinimumSize = new System.Drawing.Size(44, 50);
            this._webBrowser.Name = "webBrowser";
            this._webBrowser.Size = new System.Drawing.Size(616, 644);
            this._webBrowser.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this._webBrowser.TabIndex = 0;
            this._webBrowser.ZoomFactor = 1D;
            // 
            // closeButton
            // 
            this._closeButton.AutoSize = true;
            this._closeButton.BackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.ForeColor = System.Drawing.Color.Transparent;
            this._closeButton.Location = new System.Drawing.Point(516, 0);
            this._closeButton.Margin = new System.Windows.Forms.Padding(4);
            this._closeButton.Name = "closeButton";
            this._closeButton.Size = new System.Drawing.Size(100, 100);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "X";
            this._closeButton.UseVisualStyleBackColor = false;
            this._closeButton.Visible = false;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ScreensaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._webBrowser);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreensaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ScreensaverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 _webBrowser;
        private System.Windows.Forms.Button _closeButton;
    }
}
