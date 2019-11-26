namespace IBERPrime
{
    partial class FindPrimers
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
            this.desiredPrimerLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.desiredAmpliconLengthBox = new System.Windows.Forms.TextBox();
            this.desiredPrimerLengthLabel = new System.Windows.Forms.Label();
            this.desiredAmpliconLengthLabel = new System.Windows.Forms.Label();
            this.forwardPrimerBox = new System.Windows.Forms.RichTextBox();
            this.reversePrimerBox = new System.Windows.Forms.RichTextBox();
            this.forwardPrimerLengthBox = new System.Windows.Forms.RichTextBox();
            this.reversePrimerLengthBox = new System.Windows.Forms.RichTextBox();
            this.forwardPrimerTmBox = new System.Windows.Forms.RichTextBox();
            this.reversePrimerTmBox = new System.Windows.Forms.RichTextBox();
            this.forwardPrimerGCcontentBox = new System.Windows.Forms.RichTextBox();
            this.reversePrimerGCcontentBox = new System.Windows.Forms.RichTextBox();
            this.dnaDirection5to3label = new System.Windows.Forms.Label();
            this.forwardPrimerLabel = new System.Windows.Forms.Label();
            this.reversePrimerLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.TmLabel = new System.Windows.Forms.Label();
            this.GCcontentLabel = new System.Windows.Forms.Label();
            this.resultingAmpliconLengthTextBox = new System.Windows.Forms.TextBox();
            this.resultingAmpliconLengthLabel = new System.Windows.Forms.Label();
            this.magnesiumConcentrationBox = new System.Windows.Forms.TextBox();
            this.primerConcentrationBox = new System.Windows.Forms.TextBox();
            this.saltConcentrationBox = new System.Windows.Forms.TextBox();
            this.saltConcentrationLabel = new System.Windows.Forms.Label();
            this.MgConcentrationLabel = new System.Windows.Forms.Label();
            this.primerConcentrationLabel = new System.Windows.Forms.Label();
            this.findPrimerGoButton = new System.Windows.Forms.Button();
            this.forwardPrimerScore = new System.Windows.Forms.RichTextBox();
            this.reversePrimerScore = new System.Windows.Forms.RichTextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.desiredPrimerLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // desiredPrimerLengthUpDown
            // 
            this.desiredPrimerLengthUpDown.Location = new System.Drawing.Point(12, 12);
            this.desiredPrimerLengthUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.desiredPrimerLengthUpDown.Name = "desiredPrimerLengthUpDown";
            this.desiredPrimerLengthUpDown.Size = new System.Drawing.Size(120, 20);
            this.desiredPrimerLengthUpDown.TabIndex = 0;
            this.desiredPrimerLengthUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // desiredAmpliconLengthBox
            // 
            this.desiredAmpliconLengthBox.Location = new System.Drawing.Point(12, 50);
            this.desiredAmpliconLengthBox.Name = "desiredAmpliconLengthBox";
            this.desiredAmpliconLengthBox.Size = new System.Drawing.Size(120, 20);
            this.desiredAmpliconLengthBox.TabIndex = 1;
            this.desiredAmpliconLengthBox.Text = "150";
            this.desiredAmpliconLengthBox.TextChanged += new System.EventHandler(this.desiredAmpliconLengthBox_TextChanged);
            // 
            // desiredPrimerLengthLabel
            // 
            this.desiredPrimerLengthLabel.AutoSize = true;
            this.desiredPrimerLengthLabel.Location = new System.Drawing.Point(139, 18);
            this.desiredPrimerLengthLabel.Name = "desiredPrimerLengthLabel";
            this.desiredPrimerLengthLabel.Size = new System.Drawing.Size(106, 13);
            this.desiredPrimerLengthLabel.TabIndex = 2;
            this.desiredPrimerLengthLabel.Text = "Desired primer length";
            // 
            // desiredAmpliconLengthLabel
            // 
            this.desiredAmpliconLengthLabel.AutoSize = true;
            this.desiredAmpliconLengthLabel.Location = new System.Drawing.Point(142, 56);
            this.desiredAmpliconLengthLabel.Name = "desiredAmpliconLengthLabel";
            this.desiredAmpliconLengthLabel.Size = new System.Drawing.Size(120, 13);
            this.desiredAmpliconLengthLabel.TabIndex = 3;
            this.desiredAmpliconLengthLabel.Text = "Desired amplicon length";
            // 
            // forwardPrimerBox
            // 
            this.forwardPrimerBox.Location = new System.Drawing.Point(12, 190);
            this.forwardPrimerBox.Name = "forwardPrimerBox";
            this.forwardPrimerBox.Size = new System.Drawing.Size(293, 33);
            this.forwardPrimerBox.TabIndex = 4;
            this.forwardPrimerBox.Text = "";
            // 
            // reversePrimerBox
            // 
            this.reversePrimerBox.Location = new System.Drawing.Point(12, 223);
            this.reversePrimerBox.Name = "reversePrimerBox";
            this.reversePrimerBox.Size = new System.Drawing.Size(293, 33);
            this.reversePrimerBox.TabIndex = 5;
            this.reversePrimerBox.Text = "";
            // 
            // forwardPrimerLengthBox
            // 
            this.forwardPrimerLengthBox.Location = new System.Drawing.Point(307, 190);
            this.forwardPrimerLengthBox.Name = "forwardPrimerLengthBox";
            this.forwardPrimerLengthBox.Size = new System.Drawing.Size(49, 33);
            this.forwardPrimerLengthBox.TabIndex = 6;
            this.forwardPrimerLengthBox.Text = "";
            // 
            // reversePrimerLengthBox
            // 
            this.reversePrimerLengthBox.Location = new System.Drawing.Point(307, 223);
            this.reversePrimerLengthBox.Name = "reversePrimerLengthBox";
            this.reversePrimerLengthBox.Size = new System.Drawing.Size(49, 33);
            this.reversePrimerLengthBox.TabIndex = 7;
            this.reversePrimerLengthBox.Text = "";
            // 
            // forwardPrimerTmBox
            // 
            this.forwardPrimerTmBox.Location = new System.Drawing.Point(358, 190);
            this.forwardPrimerTmBox.Name = "forwardPrimerTmBox";
            this.forwardPrimerTmBox.Size = new System.Drawing.Size(49, 33);
            this.forwardPrimerTmBox.TabIndex = 8;
            this.forwardPrimerTmBox.Text = "";
            // 
            // reversePrimerTmBox
            // 
            this.reversePrimerTmBox.Location = new System.Drawing.Point(358, 223);
            this.reversePrimerTmBox.Name = "reversePrimerTmBox";
            this.reversePrimerTmBox.Size = new System.Drawing.Size(49, 33);
            this.reversePrimerTmBox.TabIndex = 9;
            this.reversePrimerTmBox.Text = "";
            // 
            // forwardPrimerGCcontentBox
            // 
            this.forwardPrimerGCcontentBox.Location = new System.Drawing.Point(408, 190);
            this.forwardPrimerGCcontentBox.Name = "forwardPrimerGCcontentBox";
            this.forwardPrimerGCcontentBox.Size = new System.Drawing.Size(49, 33);
            this.forwardPrimerGCcontentBox.TabIndex = 10;
            this.forwardPrimerGCcontentBox.Text = "";
            // 
            // reversePrimerGCcontentBox
            // 
            this.reversePrimerGCcontentBox.Location = new System.Drawing.Point(408, 223);
            this.reversePrimerGCcontentBox.Name = "reversePrimerGCcontentBox";
            this.reversePrimerGCcontentBox.Size = new System.Drawing.Size(49, 33);
            this.reversePrimerGCcontentBox.TabIndex = 11;
            this.reversePrimerGCcontentBox.Text = "";
            // 
            // dnaDirection5to3label
            // 
            this.dnaDirection5to3label.AutoSize = true;
            this.dnaDirection5to3label.Location = new System.Drawing.Point(121, 171);
            this.dnaDirection5to3label.Name = "dnaDirection5to3label";
            this.dnaDirection5to3label.Size = new System.Drawing.Size(38, 13);
            this.dnaDirection5to3label.TabIndex = 12;
            this.dnaDirection5to3label.Text = "5\' -> 3\'";
            // 
            // forwardPrimerLabel
            // 
            this.forwardPrimerLabel.AutoSize = true;
            this.forwardPrimerLabel.Location = new System.Drawing.Point(12, 171);
            this.forwardPrimerLabel.Name = "forwardPrimerLabel";
            this.forwardPrimerLabel.Size = new System.Drawing.Size(76, 13);
            this.forwardPrimerLabel.TabIndex = 14;
            this.forwardPrimerLabel.Text = "Forward primer";
            // 
            // reversePrimerLabel
            // 
            this.reversePrimerLabel.AutoSize = true;
            this.reversePrimerLabel.Location = new System.Drawing.Point(12, 262);
            this.reversePrimerLabel.Name = "reversePrimerLabel";
            this.reversePrimerLabel.Size = new System.Drawing.Size(78, 13);
            this.reversePrimerLabel.TabIndex = 15;
            this.reversePrimerLabel.Text = "Reverse primer";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(312, 171);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 16;
            this.lengthLabel.Text = "Length";
            // 
            // TmLabel
            // 
            this.TmLabel.AutoSize = true;
            this.TmLabel.Location = new System.Drawing.Point(372, 171);
            this.TmLabel.Name = "TmLabel";
            this.TmLabel.Size = new System.Drawing.Size(22, 13);
            this.TmLabel.TabIndex = 17;
            this.TmLabel.Text = "Tm";
            // 
            // GCcontentLabel
            // 
            this.GCcontentLabel.AutoSize = true;
            this.GCcontentLabel.Location = new System.Drawing.Point(416, 171);
            this.GCcontentLabel.Name = "GCcontentLabel";
            this.GCcontentLabel.Size = new System.Drawing.Size(33, 13);
            this.GCcontentLabel.TabIndex = 18;
            this.GCcontentLabel.Text = "GC %";
            // 
            // resultingAmpliconLengthTextBox
            // 
            this.resultingAmpliconLengthTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.resultingAmpliconLengthTextBox.Location = new System.Drawing.Point(15, 313);
            this.resultingAmpliconLengthTextBox.Name = "resultingAmpliconLengthTextBox";
            this.resultingAmpliconLengthTextBox.Size = new System.Drawing.Size(117, 20);
            this.resultingAmpliconLengthTextBox.TabIndex = 19;
            this.resultingAmpliconLengthTextBox.Text = "150";
            // 
            // resultingAmpliconLengthLabel
            // 
            this.resultingAmpliconLengthLabel.AutoSize = true;
            this.resultingAmpliconLengthLabel.Location = new System.Drawing.Point(15, 297);
            this.resultingAmpliconLengthLabel.Name = "resultingAmpliconLengthLabel";
            this.resultingAmpliconLengthLabel.Size = new System.Drawing.Size(131, 13);
            this.resultingAmpliconLengthLabel.TabIndex = 20;
            this.resultingAmpliconLengthLabel.Text = "Resulting amplicon length:";
            // 
            // magnesiumConcentrationBox
            // 
            this.magnesiumConcentrationBox.Location = new System.Drawing.Point(283, 49);
            this.magnesiumConcentrationBox.Name = "magnesiumConcentrationBox";
            this.magnesiumConcentrationBox.Size = new System.Drawing.Size(100, 20);
            this.magnesiumConcentrationBox.TabIndex = 21;
            this.magnesiumConcentrationBox.Text = "2.5";
            // 
            // primerConcentrationBox
            // 
            this.primerConcentrationBox.Location = new System.Drawing.Point(283, 87);
            this.primerConcentrationBox.Name = "primerConcentrationBox";
            this.primerConcentrationBox.Size = new System.Drawing.Size(100, 20);
            this.primerConcentrationBox.TabIndex = 22;
            this.primerConcentrationBox.Text = "200";
            // 
            // saltConcentrationBox
            // 
            this.saltConcentrationBox.Location = new System.Drawing.Point(283, 12);
            this.saltConcentrationBox.Name = "saltConcentrationBox";
            this.saltConcentrationBox.Size = new System.Drawing.Size(100, 20);
            this.saltConcentrationBox.TabIndex = 23;
            this.saltConcentrationBox.Text = "50";
            // 
            // saltConcentrationLabel
            // 
            this.saltConcentrationLabel.AutoSize = true;
            this.saltConcentrationLabel.Location = new System.Drawing.Point(389, 14);
            this.saltConcentrationLabel.Name = "saltConcentrationLabel";
            this.saltConcentrationLabel.Size = new System.Drawing.Size(93, 13);
            this.saltConcentrationLabel.TabIndex = 24;
            this.saltConcentrationLabel.Text = "Salt concentration";
            // 
            // MgConcentrationLabel
            // 
            this.MgConcentrationLabel.AutoSize = true;
            this.MgConcentrationLabel.Location = new System.Drawing.Point(389, 52);
            this.MgConcentrationLabel.Name = "MgConcentrationLabel";
            this.MgConcentrationLabel.Size = new System.Drawing.Size(102, 13);
            this.MgConcentrationLabel.TabIndex = 25;
            this.MgConcentrationLabel.Text = "Mg++ concentration";
            // 
            // primerConcentrationLabel
            // 
            this.primerConcentrationLabel.AutoSize = true;
            this.primerConcentrationLabel.Location = new System.Drawing.Point(389, 90);
            this.primerConcentrationLabel.Name = "primerConcentrationLabel";
            this.primerConcentrationLabel.Size = new System.Drawing.Size(104, 13);
            this.primerConcentrationLabel.TabIndex = 26;
            this.primerConcentrationLabel.Text = "Primer concentration";
            // 
            // findPrimerGoButton
            // 
            this.findPrimerGoButton.Location = new System.Drawing.Point(382, 310);
            this.findPrimerGoButton.Name = "findPrimerGoButton";
            this.findPrimerGoButton.Size = new System.Drawing.Size(75, 23);
            this.findPrimerGoButton.TabIndex = 27;
            this.findPrimerGoButton.Text = "Find primers";
            this.findPrimerGoButton.UseVisualStyleBackColor = true;
            this.findPrimerGoButton.Click += new System.EventHandler(this.findPrimerGoButton_Click);
            // 
            // forwardPrimerScore
            // 
            this.forwardPrimerScore.Location = new System.Drawing.Point(459, 190);
            this.forwardPrimerScore.Name = "forwardPrimerScore";
            this.forwardPrimerScore.Size = new System.Drawing.Size(81, 33);
            this.forwardPrimerScore.TabIndex = 28;
            this.forwardPrimerScore.Text = "";
            // 
            // reversePrimerScore
            // 
            this.reversePrimerScore.Location = new System.Drawing.Point(459, 223);
            this.reversePrimerScore.Name = "reversePrimerScore";
            this.reversePrimerScore.Size = new System.Drawing.Size(81, 33);
            this.reversePrimerScore.TabIndex = 29;
            this.reversePrimerScore.Text = "";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(461, 171);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 30;
            this.scoreLabel.Text = "Score";
            // 
            // FindPrimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 349);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.reversePrimerScore);
            this.Controls.Add(this.forwardPrimerScore);
            this.Controls.Add(this.findPrimerGoButton);
            this.Controls.Add(this.primerConcentrationLabel);
            this.Controls.Add(this.MgConcentrationLabel);
            this.Controls.Add(this.saltConcentrationLabel);
            this.Controls.Add(this.saltConcentrationBox);
            this.Controls.Add(this.primerConcentrationBox);
            this.Controls.Add(this.magnesiumConcentrationBox);
            this.Controls.Add(this.resultingAmpliconLengthLabel);
            this.Controls.Add(this.resultingAmpliconLengthTextBox);
            this.Controls.Add(this.GCcontentLabel);
            this.Controls.Add(this.TmLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.reversePrimerLabel);
            this.Controls.Add(this.forwardPrimerLabel);
            this.Controls.Add(this.dnaDirection5to3label);
            this.Controls.Add(this.reversePrimerGCcontentBox);
            this.Controls.Add(this.forwardPrimerGCcontentBox);
            this.Controls.Add(this.reversePrimerTmBox);
            this.Controls.Add(this.forwardPrimerTmBox);
            this.Controls.Add(this.reversePrimerLengthBox);
            this.Controls.Add(this.forwardPrimerLengthBox);
            this.Controls.Add(this.reversePrimerBox);
            this.Controls.Add(this.forwardPrimerBox);
            this.Controls.Add(this.desiredAmpliconLengthLabel);
            this.Controls.Add(this.desiredPrimerLengthLabel);
            this.Controls.Add(this.desiredAmpliconLengthBox);
            this.Controls.Add(this.desiredPrimerLengthUpDown);
            this.Name = "FindPrimers";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.desiredPrimerLengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown desiredPrimerLengthUpDown;
        private System.Windows.Forms.TextBox desiredAmpliconLengthBox;
        private System.Windows.Forms.Label desiredPrimerLengthLabel;
        private System.Windows.Forms.Label desiredAmpliconLengthLabel;
        private System.Windows.Forms.RichTextBox forwardPrimerBox;
        private System.Windows.Forms.RichTextBox reversePrimerBox;
        private System.Windows.Forms.RichTextBox forwardPrimerLengthBox;
        private System.Windows.Forms.RichTextBox reversePrimerLengthBox;
        private System.Windows.Forms.RichTextBox forwardPrimerTmBox;
        private System.Windows.Forms.RichTextBox reversePrimerTmBox;
        private System.Windows.Forms.RichTextBox forwardPrimerGCcontentBox;
        private System.Windows.Forms.RichTextBox reversePrimerGCcontentBox;
        private System.Windows.Forms.Label dnaDirection5to3label;
        private System.Windows.Forms.Label forwardPrimerLabel;
        private System.Windows.Forms.Label reversePrimerLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label TmLabel;
        private System.Windows.Forms.Label GCcontentLabel;
        private System.Windows.Forms.TextBox resultingAmpliconLengthTextBox;
        private System.Windows.Forms.Label resultingAmpliconLengthLabel;
        private System.Windows.Forms.TextBox magnesiumConcentrationBox;
        private System.Windows.Forms.TextBox primerConcentrationBox;
        private System.Windows.Forms.TextBox saltConcentrationBox;
        private System.Windows.Forms.Label saltConcentrationLabel;
        private System.Windows.Forms.Label MgConcentrationLabel;
        private System.Windows.Forms.Label primerConcentrationLabel;
        private System.Windows.Forms.Button findPrimerGoButton;
        private System.Windows.Forms.RichTextBox forwardPrimerScore;
        private System.Windows.Forms.RichTextBox reversePrimerScore;
        private System.Windows.Forms.Label scoreLabel;
    }
}