namespace IBERPrime
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
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
            this.SuspendLayout();
            // 
            // FindPrimers
            // 
            this.FindPrimers.Location = new System.Drawing.Point(1057, 420);
            this.FindPrimers.Name = "FindPrimers";
            this.FindPrimers.Size = new System.Drawing.Size(75, 23);
            this.FindPrimers.TabIndex = 0;
            this.FindPrimers.Text = "FindPrimers";
            this.FindPrimers.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 55);
            this.richTextBox1.MaxLength = 20000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(1120, 124);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyUp);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 238);
            this.richTextBox2.MaxLength = 20000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1120, 123);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox2_KeyUp);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 448);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1120, 163);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Sequence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Sequence";
            // 
            // revereComplementButtonBox1
            // 
            this.revereComplementButtonBox1.Location = new System.Drawing.Point(985, 28);
            this.revereComplementButtonBox1.Name = "revereComplementButtonBox1";
            this.revereComplementButtonBox1.Size = new System.Drawing.Size(145, 23);
            this.revereComplementButtonBox1.TabIndex = 6;
            this.revereComplementButtonBox1.Text = "Reverse complement";
            this.revereComplementButtonBox1.UseVisualStyleBackColor = true;
            this.revereComplementButtonBox1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // revereComplementButtonBox2
            // 
            this.revereComplementButtonBox2.Location = new System.Drawing.Point(985, 212);
            this.revereComplementButtonBox2.Name = "revereComplementButtonBox2";
            this.revereComplementButtonBox2.Size = new System.Drawing.Size(145, 23);
            this.revereComplementButtonBox2.TabIndex = 7;
            this.revereComplementButtonBox2.Text = "Reverse complement";
            this.revereComplementButtonBox2.UseVisualStyleBackColor = true;
            this.revereComplementButtonBox2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results:";
            // 
            // OutputMessages
            // 
            this.OutputMessages.AutoSize = true;
            this.OutputMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputMessages.ForeColor = System.Drawing.Color.Orange;
            this.OutputMessages.Location = new System.Drawing.Point(15, 378);
            this.OutputMessages.Name = "OutputMessages";
            this.OutputMessages.Size = new System.Drawing.Size(226, 16);
            this.OutputMessages.TabIndex = 9;
            this.OutputMessages.Text = "Conform inputs before further actions!";
            // 
            // conformBox1Button
            // 
            this.conformBox1Button.Location = new System.Drawing.Point(889, 28);
            this.conformBox1Button.Name = "conformBox1Button";
            this.conformBox1Button.Size = new System.Drawing.Size(92, 23);
            this.conformBox1Button.TabIndex = 10;
            this.conformBox1Button.Text = "Conform input";
            this.conformBox1Button.UseVisualStyleBackColor = true;
            this.conformBox1Button.Click += new System.EventHandler(this.ConformBox1Button_Click);
            // 
            // conformBox2Button
            // 
            this.conformBox2Button.Location = new System.Drawing.Point(889, 212);
            this.conformBox2Button.Name = "conformBox2Button";
            this.conformBox2Button.Size = new System.Drawing.Size(92, 23);
            this.conformBox2Button.TabIndex = 11;
            this.conformBox2Button.Text = "Conform input";
            this.conformBox2Button.UseVisualStyleBackColor = true;
            this.conformBox2Button.Click += new System.EventHandler(this.ConformBox2Button_Click);
            // 
            // autoconformcheckBox1
            // 
            this.autoconformcheckBox1.AutoSize = true;
            this.autoconformcheckBox1.Location = new System.Drawing.Point(890, 9);
            this.autoconformcheckBox1.Name = "autoconformcheckBox1";
            this.autoconformcheckBox1.Size = new System.Drawing.Size(47, 17);
            this.autoconformcheckBox1.TabIndex = 12;
            this.autoconformcheckBox1.Text = "auto";
            this.autoconformcheckBox1.UseVisualStyleBackColor = true;
            // 
            // autoconformcheckBox2
            // 
            this.autoconformcheckBox2.AutoSize = true;
            this.autoconformcheckBox2.Location = new System.Drawing.Point(890, 194);
            this.autoconformcheckBox2.Name = "autoconformcheckBox2";
            this.autoconformcheckBox2.Size = new System.Drawing.Size(47, 17);
            this.autoconformcheckBox2.TabIndex = 13;
            this.autoconformcheckBox2.Text = "auto";
            this.autoconformcheckBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
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
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FindPrimers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindPrimers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
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
    }
}