namespace IBERPrime
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
            housekeepingTimer.Interval = 800;
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

            if (int.Parse(selectionEndValueBox1.Text) != inputBox1.SelectionStart + inputBox1.SelectionLength)
            {
                selectionEndValueBox1.Text = (inputBox1.SelectionStart + inputBox1.SelectionLength).ToString();
            }

            if (int.Parse(selectionEndValueBox2.Text) != inputBox2.SelectionStart + inputBox2.SelectionLength)
            {
                selectionEndValueBox2.Text = (inputBox2.SelectionStart + inputBox2.SelectionLength).ToString();
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
        private void findSubsequenceBox1_Click(object sender, EventArgs e)
        {
            // Closes the search window if open
            if (Application.OpenForms.OfType<Search>().Any())
            {
                Application.OpenForms.OfType<Search>().First().Close();
            }

            Search form = new Search(inputBox1);
            form.Show();
        }

        private void findSubsequenceBox2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Search>().Any())
            {
                Application.OpenForms.OfType<Search>().First().Close();
            }

            Search form = new Search(inputBox2);
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


        private void colorizeBasesBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = colorizeBasesBox2.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    {
                        ColorizeBox(inputBox2, ColorizeBy.None);
                        break;
                    }
                case 1:
                    {
                        ColorizeBox(inputBox2, ColorizeBy.DNABase);
                        break;
                    }

                case 2:
                    {
                        ColorizeBox(inputBox2, ColorizeBy.BigSmall);
                        break;

                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void ColorizeBox(RichTextBox currentBox, ColorizeBy dnaBase)
        {
            for (int i = 0; i < currentBox.Text.Length; i++)
            {
                currentBox.Select(i, 1);

                if (dnaBase == ColorizeBy.DNABase)
                {
                    switch (currentBox.Text[i])
                    {
                        case 'a':
                        case 'A':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.GreenYellow;
                                break;
                            }

                        case 'g':
                        case 'G':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.OrangeRed;
                                break;
                            }

                        case 'c':
                        case 'C':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.Blue;
                                break;
                            }

                        case 't':
                        case 'T':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.Gold;
                                break;
                            }

                        case 'N':
                            {
                                currentBox.SelectionColor = Color.Blue;
                                currentBox.SelectionBackColor = Color.White;
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
                    switch (currentBox.Text[i])
                    {
                        case 'g':
                        case 'G':
                        case 'a':
                        case 'A':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.BlueViolet;
                                break;
                            }

                        case 't':
                        case 'T':
                        case 'c':
                        case 'C':
                            {
                                currentBox.SelectionColor = Color.Black;
                                currentBox.SelectionBackColor = Color.Magenta;
                                break;
                            }
                        case 'N':
                            {
                                currentBox.SelectionColor = Color.Blue;
                                currentBox.SelectionBackColor = Color.White;
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
                    currentBox.SelectionColor = Color.Black;
                    currentBox.SelectionBackColor = Color.White;
                }
            }

            currentBox.Select(currentBox.Text.Length, 0);
            currentBox.SelectionColor = Color.Black;
            currentBox.SelectionBackColor = Color.White;
        }

        /// <summary>
        /// Not to carry coloring when typing text
        /// </summary>
        private void inputBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            inputBox1.Select(inputBox1.SelectionStart, inputBox1.SelectionLength);
            inputBox1.SelectionColor = Color.Black;
            inputBox1.SelectionBackColor = Color.White;
        }

        private void inputBox2_KeyDown(object sender, KeyEventArgs e)
        {
            inputBox2.Select(inputBox2.SelectionStart, inputBox2.SelectionLength);
            inputBox2.SelectionColor = Color.Black;
            inputBox2.SelectionBackColor = Color.White;
        }

        private void FindPrimers_Click(object sender, EventArgs e)
        {
            var findPrimers = new FindPrimers(inputBox1.Text);
            findPrimers.Show();
        }
    }
}