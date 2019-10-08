namespace IBERPrime
{
    partial class IBERPrime
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
            this.FindPrimers = new System.Windows.Forms.Button();
            this.inputBox1 = new System.Windows.Forms.RichTextBox();
            this.inputBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.revereComplementButtonBox1 = new System.Windows.Forms.Button();
            this.revereComplementButtonBox2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputMessages = new System.Windows.Forms.Label();
            this.conformBox1Button = new System.Windows.Forms.Button();
            this.conformBox2Button = new System.Windows.Forms.Button();
            this.autoconformcheckBox1 = new System.Windows.Forms.CheckBox();
            this.autoconformcheckBox2 = new System.Windows.Forms.CheckBox();
            this.inputLengthBox1label = new System.Windows.Forms.Label();
            this.inputLengthBox2label = new System.Windows.Forms.Label();
            this.inputLengthValueBox1 = new System.Windows.Forms.Label();
            this.inputLengthValueBox2 = new System.Windows.Forms.Label();
            this.caretPositionBox1Label = new System.Windows.Forms.Label();
            this.CaretPositionBox2Label = new System.Windows.Forms.Label();
            this.caretPositionValueBox1 = new System.Windows.Forms.Label();
            this.caretPositionValueBox2 = new System.Windows.Forms.Label();
            this.SelectionLengthBox1Label = new System.Windows.Forms.Label();
            this.selectionLengthBox2Label = new System.Windows.Forms.Label();
            this.selectionLengthValueBox1 = new System.Windows.Forms.Label();
            this.selectionLengthValueBox2 = new System.Windows.Forms.Label();
            this.findSubsequenceBox1 = new System.Windows.Forms.Button();
            this.colorizeBasesBox1 = new System.Windows.Forms.ComboBox();
            this.colorizeBasesLabel1 = new System.Windows.Forms.Label();
            this.selectionEndBox1Label = new System.Windows.Forms.Label();
            this.selectionEndValueBox1 = new System.Windows.Forms.Label();
            this.selectionEndBox2Label = new System.Windows.Forms.Label();
            this.selectionEndValueBox2 = new System.Windows.Forms.Label();
            this.findSubsequenceBox2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindPrimers
            // 
            this.FindPrimers.Location = new System.Drawing.Point(1409, 556);
            this.FindPrimers.Margin = new System.Windows.Forms.Padding(4);
            this.FindPrimers.Name = "FindPrimers";
            this.FindPrimers.Size = new System.Drawing.Size(100, 28);
            this.FindPrimers.TabIndex = 0;
            this.FindPrimers.Text = "FindPrimers";
            this.FindPrimers.UseVisualStyleBackColor = true;
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(16, 68);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox1.MaxLength = 20000;
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputBox1.Size = new System.Drawing.Size(1492, 152);
            this.inputBox1.TabIndex = 1;
            this.inputBox1.Text = "";
            this.inputBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyUp);
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(16, 293);
            this.inputBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox2.MaxLength = 20000;
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(1492, 150);
            this.inputBox2.TabIndex = 2;
            this.inputBox2.Text = "";
            this.inputBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBox2_KeyUp);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(16, 591);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1492, 200);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Sequence";
            // 
            // revereComplementButtonBox1
            // 
            this.revereComplementButtonBox1.Location = new System.Drawing.Point(1313, 34);
            this.revereComplementButtonBox1.Margin = new System.Windows.Forms.Padding(4);
            this.revereComplementButtonBox1.Name = "revereComplementButtonBox1";
            this.revereComplementButtonBox1.Size = new System.Drawing.Size(193, 28);
            this.revereComplementButtonBox1.TabIndex = 6;
            this.revereComplementButtonBox1.Text = "Reverse complement";
            this.revereComplementButtonBox1.UseVisualStyleBackColor = true;
            this.revereComplementButtonBox1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // revereComplementButtonBox2
            // 
            this.revereComplementButtonBox2.Location = new System.Drawing.Point(1313, 261);
            this.revereComplementButtonBox2.Margin = new System.Windows.Forms.Padding(4);
            this.revereComplementButtonBox2.Name = "revereComplementButtonBox2";
            this.revereComplementButtonBox2.Size = new System.Drawing.Size(193, 28);
            this.revereComplementButtonBox2.TabIndex = 7;
            this.revereComplementButtonBox2.Text = "Reverse complement";
            this.revereComplementButtonBox2.UseVisualStyleBackColor = true;
            this.revereComplementButtonBox2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 556);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results:";
            // 
            // OutputMessages
            // 
            this.OutputMessages.AutoSize = true;
            this.OutputMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputMessages.ForeColor = System.Drawing.Color.Orange;
            this.OutputMessages.Location = new System.Drawing.Point(17, 501);
            this.OutputMessages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputMessages.Name = "OutputMessages";
            this.OutputMessages.Size = new System.Drawing.Size(293, 20);
            this.OutputMessages.TabIndex = 9;
            this.OutputMessages.Text = "Conform inputs before further actions!";
            // 
            // conformBox1Button
            // 
            this.conformBox1Button.Location = new System.Drawing.Point(1185, 34);
            this.conformBox1Button.Margin = new System.Windows.Forms.Padding(4);
            this.conformBox1Button.Name = "conformBox1Button";
            this.conformBox1Button.Size = new System.Drawing.Size(123, 28);
            this.conformBox1Button.TabIndex = 10;
            this.conformBox1Button.Text = "Conform input";
            this.conformBox1Button.UseVisualStyleBackColor = true;
            this.conformBox1Button.Click += new System.EventHandler(this.ConformBox1Button_Click);
            // 
            // conformBox2Button
            // 
            this.conformBox2Button.Location = new System.Drawing.Point(1185, 261);
            this.conformBox2Button.Margin = new System.Windows.Forms.Padding(4);
            this.conformBox2Button.Name = "conformBox2Button";
            this.conformBox2Button.Size = new System.Drawing.Size(123, 28);
            this.conformBox2Button.TabIndex = 11;
            this.conformBox2Button.Text = "Conform input";
            this.conformBox2Button.UseVisualStyleBackColor = true;
            this.conformBox2Button.Click += new System.EventHandler(this.ConformBox2Button_Click);
            // 
            // autoconformcheckBox1
            // 
            this.autoconformcheckBox1.AutoSize = true;
            this.autoconformcheckBox1.Location = new System.Drawing.Point(1187, 11);
            this.autoconformcheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.autoconformcheckBox1.Name = "autoconformcheckBox1";
            this.autoconformcheckBox1.Size = new System.Drawing.Size(58, 21);
            this.autoconformcheckBox1.TabIndex = 12;
            this.autoconformcheckBox1.Text = "auto";
            this.autoconformcheckBox1.UseVisualStyleBackColor = true;
            // 
            // autoconformcheckBox2
            // 
            this.autoconformcheckBox2.AutoSize = true;
            this.autoconformcheckBox2.Location = new System.Drawing.Point(1187, 239);
            this.autoconformcheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.autoconformcheckBox2.Name = "autoconformcheckBox2";
            this.autoconformcheckBox2.Size = new System.Drawing.Size(58, 21);
            this.autoconformcheckBox2.TabIndex = 13;
            this.autoconformcheckBox2.Text = "auto";
            this.autoconformcheckBox2.UseVisualStyleBackColor = true;
            // 
            // inputLengthBox1label
            // 
            this.inputLengthBox1label.AutoSize = true;
            this.inputLengthBox1label.Location = new System.Drawing.Point(16, 224);
            this.inputLengthBox1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLengthBox1label.Name = "inputLengthBox1label";
            this.inputLengthBox1label.Size = new System.Drawing.Size(86, 17);
            this.inputLengthBox1label.TabIndex = 14;
            this.inputLengthBox1label.Text = "Input length:";
            // 
            // inputLengthBox2label
            // 
            this.inputLengthBox2label.AutoSize = true;
            this.inputLengthBox2label.Location = new System.Drawing.Point(16, 448);
            this.inputLengthBox2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLengthBox2label.Name = "inputLengthBox2label";
            this.inputLengthBox2label.Size = new System.Drawing.Size(86, 17);
            this.inputLengthBox2label.TabIndex = 15;
            this.inputLengthBox2label.Text = "Input length:";
            // 
            // inputLengthValueBox1
            // 
            this.inputLengthValueBox1.AutoSize = true;
            this.inputLengthValueBox1.Location = new System.Drawing.Point(101, 224);
            this.inputLengthValueBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLengthValueBox1.Name = "inputLengthValueBox1";
            this.inputLengthValueBox1.Size = new System.Drawing.Size(16, 17);
            this.inputLengthValueBox1.TabIndex = 16;
            this.inputLengthValueBox1.Text = "0";
            // 
            // inputLengthValueBox2
            // 
            this.inputLengthValueBox2.AutoSize = true;
            this.inputLengthValueBox2.Location = new System.Drawing.Point(105, 448);
            this.inputLengthValueBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLengthValueBox2.Name = "inputLengthValueBox2";
            this.inputLengthValueBox2.Size = new System.Drawing.Size(16, 17);
            this.inputLengthValueBox2.TabIndex = 17;
            this.inputLengthValueBox2.Text = "0";
            // 
            // caretPositionBox1Label
            // 
            this.caretPositionBox1Label.AutoSize = true;
            this.caretPositionBox1Label.Location = new System.Drawing.Point(157, 224);
            this.caretPositionBox1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caretPositionBox1Label.Name = "caretPositionBox1Label";
            this.caretPositionBox1Label.Size = new System.Drawing.Size(201, 17);
            this.caretPositionBox1Label.TabIndex = 18;
            this.caretPositionBox1Label.Text = "Cursor position/Selection start:";
            // 
            // CaretPositionBox2Label
            // 
            this.CaretPositionBox2Label.AutoSize = true;
            this.CaretPositionBox2Label.Location = new System.Drawing.Point(159, 448);
            this.CaretPositionBox2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CaretPositionBox2Label.Name = "CaretPositionBox2Label";
            this.CaretPositionBox2Label.Size = new System.Drawing.Size(201, 17);
            this.CaretPositionBox2Label.TabIndex = 19;
            this.CaretPositionBox2Label.Text = "Cursor position/Selection start:";
            // 
            // caretPositionValueBox1
            // 
            this.caretPositionValueBox1.AutoSize = true;
            this.caretPositionValueBox1.Location = new System.Drawing.Point(355, 224);
            this.caretPositionValueBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caretPositionValueBox1.Name = "caretPositionValueBox1";
            this.caretPositionValueBox1.Size = new System.Drawing.Size(16, 17);
            this.caretPositionValueBox1.TabIndex = 20;
            this.caretPositionValueBox1.Text = "0";
            // 
            // caretPositionValueBox2
            // 
            this.caretPositionValueBox2.AutoSize = true;
            this.caretPositionValueBox2.Location = new System.Drawing.Point(355, 447);
            this.caretPositionValueBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caretPositionValueBox2.Name = "caretPositionValueBox2";
            this.caretPositionValueBox2.Size = new System.Drawing.Size(16, 17);
            this.caretPositionValueBox2.TabIndex = 21;
            this.caretPositionValueBox2.Text = "0";
            // 
            // SelectionLengthBox1Label
            // 
            this.SelectionLengthBox1Label.AutoSize = true;
            this.SelectionLengthBox1Label.Location = new System.Drawing.Point(420, 224);
            this.SelectionLengthBox1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectionLengthBox1Label.Name = "SelectionLengthBox1Label";
            this.SelectionLengthBox1Label.Size = new System.Drawing.Size(113, 17);
            this.SelectionLengthBox1Label.TabIndex = 22;
            this.SelectionLengthBox1Label.Text = "Selection length:";
            // 
            // selectionLengthBox2Label
            // 
            this.selectionLengthBox2Label.AutoSize = true;
            this.selectionLengthBox2Label.Location = new System.Drawing.Point(420, 447);
            this.selectionLengthBox2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionLengthBox2Label.Name = "selectionLengthBox2Label";
            this.selectionLengthBox2Label.Size = new System.Drawing.Size(113, 17);
            this.selectionLengthBox2Label.TabIndex = 23;
            this.selectionLengthBox2Label.Text = "Selection length:";
            // 
            // selectionLengthValueBox1
            // 
            this.selectionLengthValueBox1.AutoSize = true;
            this.selectionLengthValueBox1.Location = new System.Drawing.Point(528, 224);
            this.selectionLengthValueBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionLengthValueBox1.Name = "selectionLengthValueBox1";
            this.selectionLengthValueBox1.Size = new System.Drawing.Size(16, 17);
            this.selectionLengthValueBox1.TabIndex = 24;
            this.selectionLengthValueBox1.Text = "0";
            // 
            // selectionLengthValueBox2
            // 
            this.selectionLengthValueBox2.AutoSize = true;
            this.selectionLengthValueBox2.Location = new System.Drawing.Point(528, 447);
            this.selectionLengthValueBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionLengthValueBox2.Name = "selectionLengthValueBox2";
            this.selectionLengthValueBox2.Size = new System.Drawing.Size(16, 17);
            this.selectionLengthValueBox2.TabIndex = 25;
            this.selectionLengthValueBox2.Text = "0";
            // 
            // findSubsequenceBox1
            // 
            this.findSubsequenceBox1.Location = new System.Drawing.Point(1029, 34);
            this.findSubsequenceBox1.Margin = new System.Windows.Forms.Padding(4);
            this.findSubsequenceBox1.Name = "findSubsequenceBox1";
            this.findSubsequenceBox1.Size = new System.Drawing.Size(151, 28);
            this.findSubsequenceBox1.TabIndex = 26;
            this.findSubsequenceBox1.Text = "Search in sequence";
            this.findSubsequenceBox1.UseVisualStyleBackColor = true;
            this.findSubsequenceBox1.Click += new System.EventHandler(this.findSubsequenceBox1_Click);
            // 
            // colorizeBasesBox1
            // 
            this.colorizeBasesBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorizeBasesBox1.FormattingEnabled = true;
            this.colorizeBasesBox1.Items.AddRange(new object[] {
            "None",
            "By base",
            "By purine/pyrimidine"});
            this.colorizeBasesBox1.Location = new System.Drawing.Point(901, 34);
            this.colorizeBasesBox1.Name = "colorizeBasesBox1";
            this.colorizeBasesBox1.Size = new System.Drawing.Size(121, 24);
            this.colorizeBasesBox1.TabIndex = 27;
            this.colorizeBasesBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // colorizeBasesLabel1
            // 
            this.colorizeBasesLabel1.AutoSize = true;
            this.colorizeBasesLabel1.Location = new System.Drawing.Point(901, 11);
            this.colorizeBasesLabel1.Name = "colorizeBasesLabel1";
            this.colorizeBasesLabel1.Size = new System.Drawing.Size(105, 17);
            this.colorizeBasesLabel1.TabIndex = 28;
            this.colorizeBasesLabel1.Text = "Colorize bases:";
            // 
            // selectionEndBox1Label
            // 
            this.selectionEndBox1Label.AutoSize = true;
            this.selectionEndBox1Label.Location = new System.Drawing.Point(560, 224);
            this.selectionEndBox1Label.Name = "selectionEndBox1Label";
            this.selectionEndBox1Label.Size = new System.Drawing.Size(98, 17);
            this.selectionEndBox1Label.TabIndex = 29;
            this.selectionEndBox1Label.Text = "Selection end:";
            // 
            // selectionEndValueBox1
            // 
            this.selectionEndValueBox1.AutoSize = true;
            this.selectionEndValueBox1.Location = new System.Drawing.Point(654, 224);
            this.selectionEndValueBox1.Name = "selectionEndValueBox1";
            this.selectionEndValueBox1.Size = new System.Drawing.Size(16, 17);
            this.selectionEndValueBox1.TabIndex = 30;
            this.selectionEndValueBox1.Text = "0";
            // 
            // selectionEndBox2Label
            // 
            this.selectionEndBox2Label.AutoSize = true;
            this.selectionEndBox2Label.Location = new System.Drawing.Point(563, 447);
            this.selectionEndBox2Label.Name = "selectionEndBox2Label";
            this.selectionEndBox2Label.Size = new System.Drawing.Size(98, 17);
            this.selectionEndBox2Label.TabIndex = 31;
            this.selectionEndBox2Label.Text = "Selection end:";
            // 
            // selectionEndValueBox2
            // 
            this.selectionEndValueBox2.AutoSize = true;
            this.selectionEndValueBox2.Location = new System.Drawing.Point(654, 447);
            this.selectionEndValueBox2.Name = "selectionEndValueBox2";
            this.selectionEndValueBox2.Size = new System.Drawing.Size(16, 17);
            this.selectionEndValueBox2.TabIndex = 32;
            this.selectionEndValueBox2.Text = "0";
            // 
            // findSubsequenceBox2
            // 
            this.findSubsequenceBox2.Location = new System.Drawing.Point(1029, 261);
            this.findSubsequenceBox2.Margin = new System.Windows.Forms.Padding(4);
            this.findSubsequenceBox2.Name = "findSubsequenceBox2";
            this.findSubsequenceBox2.Size = new System.Drawing.Size(151, 28);
            this.findSubsequenceBox2.TabIndex = 33;
            this.findSubsequenceBox2.Text = "Search in sequence";
            this.findSubsequenceBox2.UseVisualStyleBackColor = true;
            this.findSubsequenceBox2.Click += new System.EventHandler(this.findSubsequenceBox2_Click);
            // 
            // IBERPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.findSubsequenceBox2);
            this.Controls.Add(this.selectionEndValueBox2);
            this.Controls.Add(this.selectionEndBox2Label);
            this.Controls.Add(this.selectionEndValueBox1);
            this.Controls.Add(this.selectionEndBox1Label);
            this.Controls.Add(this.colorizeBasesLabel1);
            this.Controls.Add(this.colorizeBasesBox1);
            this.Controls.Add(this.findSubsequenceBox1);
            this.Controls.Add(this.selectionLengthValueBox2);
            this.Controls.Add(this.selectionLengthValueBox1);
            this.Controls.Add(this.selectionLengthBox2Label);
            this.Controls.Add(this.SelectionLengthBox1Label);
            this.Controls.Add(this.caretPositionValueBox2);
            this.Controls.Add(this.caretPositionValueBox1);
            this.Controls.Add(this.CaretPositionBox2Label);
            this.Controls.Add(this.caretPositionBox1Label);
            this.Controls.Add(this.inputLengthValueBox2);
            this.Controls.Add(this.inputLengthValueBox1);
            this.Controls.Add(this.inputLengthBox2label);
            this.Controls.Add(this.inputLengthBox1label);
            this.Controls.Add(this.autoconformcheckBox2);
            this.Controls.Add(this.autoconformcheckBox1);
            this.Controls.Add(this.conformBox2Button);
            this.Controls.Add(this.conformBox1Button);
            this.Controls.Add(this.OutputMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revereComplementButtonBox2);
            this.Controls.Add(this.revereComplementButtonBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.FindPrimers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IBERPrime";
            this.Text = "IBERPrime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindPrimers;
        private System.Windows.Forms.RichTextBox inputBox1;
        private System.Windows.Forms.RichTextBox inputBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revereComplementButtonBox1;
        private System.Windows.Forms.Button revereComplementButtonBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OutputMessages;
        private System.Windows.Forms.Button conformBox1Button;
        private System.Windows.Forms.Button conformBox2Button;
        private System.Windows.Forms.CheckBox autoconformcheckBox1;
        private System.Windows.Forms.CheckBox autoconformcheckBox2;
        private System.Windows.Forms.Label inputLengthBox1label;
        private System.Windows.Forms.Label inputLengthBox2label;
        private System.Windows.Forms.Label inputLengthValueBox1;
        private System.Windows.Forms.Label inputLengthValueBox2;
        private System.Windows.Forms.Label caretPositionBox1Label;
        private System.Windows.Forms.Label CaretPositionBox2Label;
        private System.Windows.Forms.Label caretPositionValueBox1;
        private System.Windows.Forms.Label caretPositionValueBox2;
        private System.Windows.Forms.Label SelectionLengthBox1Label;
        private System.Windows.Forms.Label selectionLengthBox2Label;
        private System.Windows.Forms.Label selectionLengthValueBox1;
        private System.Windows.Forms.Label selectionLengthValueBox2;
        private System.Windows.Forms.Button findSubsequenceBox1;
        private System.Windows.Forms.ComboBox colorizeBasesBox1;
        private System.Windows.Forms.Label colorizeBasesLabel1;
        private System.Windows.Forms.Label selectionEndBox1Label;
        private System.Windows.Forms.Label selectionEndValueBox1;
        private System.Windows.Forms.Label selectionEndBox2Label;
        private System.Windows.Forms.Label selectionEndValueBox2;
        private System.Windows.Forms.Button findSubsequenceBox2;
    }
}