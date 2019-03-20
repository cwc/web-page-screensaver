namespace Web_Page_Screensaver
{
    partial class PrefsByScreenUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudRotationInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRandomize = new System.Windows.Forms.CheckBox();
            this.lvUrls = new System.Windows.Forms.ListView();
            this.addUrlButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.urlButtonsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.downButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRotationInterval.Location = new System.Drawing.Point(9, 220);
            this.nudRotationInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudRotationInterval.Name = "nudRotationInterval";
            this.nudRotationInterval.Size = new System.Drawing.Size(40, 20);
            this.nudRotationInterval.TabIndex = 6;
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
            this.label3.Location = new System.Drawing.Point(55, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seconds to display each site";
            // 
            // cbRandomize
            // 
            this.cbRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRandomize.AutoSize = true;
            this.cbRandomize.Location = new System.Drawing.Point(10, 195);
            this.cbRandomize.Name = "cbRandomize";
            this.cbRandomize.Size = new System.Drawing.Size(121, 17);
            this.cbRandomize.TabIndex = 5;
            this.cbRandomize.Text = "Shuffle display order";
            this.cbRandomize.UseVisualStyleBackColor = true;
            // 
            // lvUrls
            // 
            this.lvUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUrls.HideSelection = false;
            this.lvUrls.LabelEdit = true;
            this.lvUrls.Location = new System.Drawing.Point(10, 10);
            this.lvUrls.Margin = new System.Windows.Forms.Padding(2);
            this.lvUrls.Name = "lvUrls";
            this.lvUrls.Size = new System.Drawing.Size(230, 150);
            this.lvUrls.TabIndex = 0;
            this.lvUrls.UseCompatibleStateImageBehavior = false;
            this.lvUrls.View = System.Windows.Forms.View.List;
            // 
            // addUrlButton
            // 
            this.addUrlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUrlButton.Location = new System.Drawing.Point(9, 165);
            this.addUrlButton.Margin = new System.Windows.Forms.Padding(0);
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Size = new System.Drawing.Size(50, 25);
            this.addUrlButton.TabIndex = 11;
            this.addUrlButton.Text = "Add";
            this.addUrlButton.UseVisualStyleBackColor = true;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(190, 165);
            this.upButton.Margin = new System.Windows.Forms.Padding(0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(25, 25);
            this.upButton.TabIndex = 3;
            this.upButton.Text = "▲";
            this.urlButtonsTooltip.SetToolTip(this.upButton, "Move selected URLs up");
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.MoveAllSelectedUrlsUp_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(215, 165);
            this.downButton.Margin = new System.Windows.Forms.Padding(0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(25, 25);
            this.downButton.TabIndex = 12;
            this.downButton.Text = "▼";
            this.urlButtonsTooltip.SetToolTip(this.downButton, "Move selected URLs down");
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.MoveAllSelectedUrlsDown_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(59, 165);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(25, 25);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "X";
            this.urlButtonsTooltip.SetToolTip(this.deleteButton, "DELETE selected URLs");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteAllSelectedUrls_Click);
            // 
            // PrefsByScreenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.nudRotationInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRandomize);
            this.Controls.Add(this.lvUrls);
            this.Controls.Add(this.addUrlButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrefsByScreenUserControl";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown nudRotationInterval;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox cbRandomize;
        public System.Windows.Forms.ListView lvUrls;
        private System.Windows.Forms.ToolTip urlButtonsTooltip;
        private System.Windows.Forms.Button addUrlButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
