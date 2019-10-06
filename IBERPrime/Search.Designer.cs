namespace IBERPrime
{
    partial class Search
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
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.findSubsequenceButton = new System.Windows.Forms.Button();
            this.complementCheckbox = new System.Windows.Forms.CheckBox();
            this.mismatchCounter = new System.Windows.Forms.NumericUpDown();
            this.mismatchCountLabel = new System.Windows.Forms.Label();
            this.enterSubsequenceLabel = new System.Windows.Forms.Label();
            this.reverseComplementCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mismatchCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 35);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(426, 96);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "";
            // 
            // findSubsequenceButton
            // 
            this.findSubsequenceButton.Location = new System.Drawing.Point(24, 150);
            this.findSubsequenceButton.Name = "findSubsequenceButton";
            this.findSubsequenceButton.Size = new System.Drawing.Size(84, 25);
            this.findSubsequenceButton.TabIndex = 1;
            this.findSubsequenceButton.Text = "Find";
            this.findSubsequenceButton.UseVisualStyleBackColor = true;
            this.findSubsequenceButton.Click += new System.EventHandler(this.findSubsequenceButton_Click);
            // 
            // complementCheckbox
            // 
            this.complementCheckbox.AutoSize = true;
            this.complementCheckbox.Location = new System.Drawing.Point(288, 146);
            this.complementCheckbox.Name = "complementCheckbox";
            this.complementCheckbox.Size = new System.Drawing.Size(121, 17);
            this.complementCheckbox.TabIndex = 2;
            this.complementCheckbox.Text = "Include complement";
            this.complementCheckbox.UseVisualStyleBackColor = true;
            // 
            // mismatchCounter
            // 
            this.mismatchCounter.Location = new System.Drawing.Point(218, 155);
            this.mismatchCounter.Name = "mismatchCounter";
            this.mismatchCounter.Size = new System.Drawing.Size(44, 20);
            this.mismatchCounter.TabIndex = 3;
            // 
            // mismatchCountLabel
            // 
            this.mismatchCountLabel.AutoSize = true;
            this.mismatchCountLabel.Location = new System.Drawing.Point(149, 150);
            this.mismatchCountLabel.Name = "mismatchCountLabel";
            this.mismatchCountLabel.Size = new System.Drawing.Size(63, 26);
            this.mismatchCountLabel.TabIndex = 4;
            this.mismatchCountLabel.Text = "Mismatches\r\n      count:";
            // 
            // enterSubsequenceLabel
            // 
            this.enterSubsequenceLabel.AutoSize = true;
            this.enterSubsequenceLabel.Location = new System.Drawing.Point(21, 13);
            this.enterSubsequenceLabel.Name = "enterSubsequenceLabel";
            this.enterSubsequenceLabel.Size = new System.Drawing.Size(173, 13);
            this.enterSubsequenceLabel.TabIndex = 5;
            this.enterSubsequenceLabel.Text = "Enter subsequence to search here:";
            // 
            // reverseComplementCheckbox
            // 
            this.reverseComplementCheckbox.AutoSize = true;
            this.reverseComplementCheckbox.Location = new System.Drawing.Point(288, 163);
            this.reverseComplementCheckbox.Name = "reverseComplementCheckbox";
            this.reverseComplementCheckbox.Size = new System.Drawing.Size(159, 17);
            this.reverseComplementCheckbox.TabIndex = 6;
            this.reverseComplementCheckbox.Text = "Include reverse complement";
            this.reverseComplementCheckbox.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 188);
            this.Controls.Add(this.reverseComplementCheckbox);
            this.Controls.Add(this.enterSubsequenceLabel);
            this.Controls.Add(this.mismatchCountLabel);
            this.Controls.Add(this.mismatchCounter);
            this.Controls.Add(this.complementCheckbox);
            this.Controls.Add(this.findSubsequenceButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.mismatchCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchTextBox;
        private System.Windows.Forms.Button findSubsequenceButton;
        private System.Windows.Forms.CheckBox complementCheckbox;
        private System.Windows.Forms.NumericUpDown mismatchCounter;
        private System.Windows.Forms.Label mismatchCountLabel;
        private System.Windows.Forms.Label enterSubsequenceLabel;
        private System.Windows.Forms.CheckBox reverseComplementCheckbox;
    }
}