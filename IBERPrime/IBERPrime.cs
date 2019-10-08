﻿namespace IBERPrime
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Timers;
    using System.Windows.Forms;

    public partial class IBERPrime : Form
    {
        private System.Timers.Timer housekeepingTimer;

        enum ColorizeBy
        {
            None,
            DNABase,
            BigSmall
        }

        public IBERPrime()
        {
            InitializeComponent();
            housekeepingTimer = new System.Timers.Timer();
            housekeepingTimer.Elapsed += new System.Timers.ElapsedEventHandler(UpdatingFormValues);
            housekeepingTimer.Interval = 1000;
            housekeepingTimer.Enabled = true;
        }

        public delegate void InvokeDelegate();

        private void InvokeTextLengthChange(object sender, EventArgs e)
        {
            Invoke(new InvokeDelegate(ChangeTextLengthValue));
        }

        public void ChangeTextLengthValue()
        {
            if (int.Parse(inputLengthValueBox1.Text) != inputBox1.Text.Length)
            {
                inputLengthValueBox1.Text = inputBox1.Text.Length.ToString();
            }

            if (int.Parse(inputLengthValueBox2.Text) != inputBox2.Text.Length)
            {
                inputLengthValueBox2.Text = inputBox2.Text.Length.ToString();
            }

            if (int.Parse(caretPositionValueBox1.Text) != inputBox1.SelectionStart)
            {
                caretPositionValueBox1.Text = inputBox1.SelectionStart.ToString();
            }

            if (int.Parse(caretPositionValueBox2.Text) != inputBox2.SelectionStart)
            {
                caretPositionValueBox2.Text = inputBox2.SelectionStart.ToString();
            }

            if (int.Parse(selectionLengthValueBox1.Text) != inputBox1.SelectionLength)
            {
                selectionLengthValueBox1.Text = inputBox1.SelectionLength.ToString();
            }

            if (int.Parse(selectionLengthValueBox2.Text) != inputBox2.SelectionLength)
            {
                selectionLengthValueBox2.Text = inputBox2.SelectionLength.ToString();
            }
        }

        private void UpdatingFormValues(object sender, ElapsedEventArgs e)
        {
            InvokeTextLengthChange(sender, e);

        }

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (autoconformcheckBox1.Checked)
            {
                ProcessSeqenceInput(this.inputBox1);
            }
        }

        private void RichTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (autoconformcheckBox2.Checked)
            {
                ProcessSeqenceInput(this.inputBox2);
            }
        }

        private void ConformBox1Button_Click(object sender, EventArgs e)
        {
            ProcessSeqenceInput(this.inputBox1);
        }

        private void ConformBox2Button_Click(object sender, EventArgs e)
        {
            ProcessSeqenceInput(this.inputBox2);
        }

        /// <summary>
        /// Checks input for validity - currently valid letters are A T G C (upper and lowercase), all others are change to 'N'
        /// </summary>
        /// <param name="textBoxtoProcess"></param>
        private void ProcessSeqenceInput(RichTextBox textBoxtoProcess)
        {
            textBoxtoProcess.Enabled = false;
            bool nonStandardLettersFound = false;
            StringBuilder sb = new StringBuilder();

            List<string> lines = textBoxtoProcess.Text.Split(new[] { "\r\n", "\r", "\n", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Remove the first line from FASTA
            lines.RemoveAll(x => x.Contains(">"));
            string clearedUpString = string.Join("", lines.ToArray());


            foreach (char ch in clearedUpString.ToUpper())
            {
                if (ch == 'A' || ch == 'C' || ch == 'G' || ch == 'T')
                {
                    sb.Append(ch);
                }
                else if (char.IsWhiteSpace(ch))
                {
                    continue;
                }
                else
                {
                    nonStandardLettersFound = true;
                    sb.Append('N');
                }
            }

            string conformedString = sb.ToString();
            textBoxtoProcess.Text = "";

            foreach (char ch in conformedString)
            {
                if (ch == 'N')
                {
                    textBoxtoProcess.SelectionColor = Color.Blue;
                    textBoxtoProcess.AppendText(ch.ToString());
                    textBoxtoProcess.SelectionColor = textBoxtoProcess.ForeColor;
                }
                else
                {
                    textBoxtoProcess.AppendText(ch.ToString());
                }
            }

            // returns cursor to the end of text
            textBoxtoProcess.Enabled = true;
            this.ActiveControl = textBoxtoProcess;
            textBoxtoProcess.Select(textBoxtoProcess.Text.Length, 0);

            if (nonStandardLettersFound)
            {
                OutputMessages.Text = "Non standard characters found. Non standard characters are substituted with 'N'.";
            }
            else
            {
                OutputMessages.Text = "Input conformed";
            }
        }

        /// <summary>
        /// Reverse complement, box 1 (Sequence 1)
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            ToggleClickedButtonColor(sender as Button);
            ReverseComplement(inputBox1);
        }

        /// <summary>
        /// Reverse complement for box 2 (sequence 2)
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            ToggleClickedButtonColor(sender as Button);
            ReverseComplement(inputBox2);
        }

        /// Make the button appears "pushed" by making its text red. This could be a problem in a system, where the defualt color is black, but I have never seen such an example in practive
        private void ToggleClickedButtonColor(Button clickedButton)
        {
            if (clickedButton.ForeColor == DefaultForeColor)
            {
                clickedButton.ForeColor = Color.Red;
            }
            else
            {
                clickedButton.ForeColor = Control.DefaultForeColor;
            }
        }

        private void ReverseComplement(RichTextBox textBoxToReverseComplement)
        {
            textBoxToReverseComplement.Enabled = false;
            char[] charArray = textBoxToReverseComplement.Text.ToCharArray();
            Array.Reverse(charArray);

            textBoxToReverseComplement.Enabled = true;
            this.ActiveControl = textBoxToReverseComplement;
            textBoxToReverseComplement.Text = DataFunctions.ReturnComplement(charArray);
            textBoxToReverseComplement.Select(textBoxToReverseComplement.Text.Length, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            housekeepingTimer.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            housekeepingTimer.Dispose();
            //housekeepingTimer = null;
        }

        /// <summary>
        /// Opens the the window for subsequence search
        /// </summary>
        private void findSubsequence_Click(object sender, EventArgs e)
        {
            // Closes the search window if open
            if (Application.OpenForms.OfType<Search>().Any())
            {
                Application.OpenForms.OfType<Search>().First().Close();
            }

            Search form = new Search(inputBox1);
            form.Show();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = colorizeBasesBox1.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    {
                        ColorizeBox(inputBox1, ColorizeBy.None);
                        break;
                    }
                case 1:
                    {
                        ColorizeBox(inputBox1, ColorizeBy.DNABase);
                        break;
                    }

                case 2:
                    {
                        ColorizeBox(inputBox1, ColorizeBy.BigSmall);
                        break;

                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void ColorizeBox(RichTextBox inputBox, ColorizeBy dnaBase)
        {
            for (int i = 0; i < inputBox.Text.Length; i++)
            {
                inputBox.Select(i, 1);

                if (dnaBase == ColorizeBy.DNABase)
                {
                    switch (inputBox.Text[i])
                    {
                        case 'a':
                        case 'A':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.GreenYellow;
                                break;
                            }

                        case 'g':
                        case 'G':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.OrangeRed;
                                break;
                            }

                        case 'c':
                        case 'C':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.Blue;
                                break;
                            }

                        case 't':
                        case 'T':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.Gold;
                                break;
                            }

                        case 'N':
                            {
                                inputBox.SelectionColor = Color.Blue;
                                inputBox.SelectionBackColor = Color.White;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else if (dnaBase == ColorizeBy.BigSmall)
                {
                    switch (inputBox.Text[i])
                    {
                        case 'g':
                        case 'G':
                        case 'a':
                        case 'A':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.BlueViolet;
                                break;
                            }

                        case 't':
                        case 'T':
                        case 'c':
                        case 'C':
                            {
                                inputBox.SelectionColor = Color.Black;
                                inputBox.SelectionBackColor = Color.Magenta;
                                break;
                            }
                        case 'N':
                            {
                                inputBox.SelectionColor = Color.Blue;
                                inputBox.SelectionBackColor = Color.White;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else if (dnaBase == ColorizeBy.None)
                {
                    inputBox.SelectionColor = Color.Black;
                    inputBox.SelectionBackColor = Color.White;
                }
            }
        }
    }
}