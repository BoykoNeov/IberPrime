﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace IBERPrime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ProcessAllLines(this.richTextBox1);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            ProcessAllLines(this.richTextBox2);
        }

        /// <summary>
        /// Checks input for validity - currently valid letters are A T G C, all others are change to 'N'
        /// </summary>
        /// <param name="richTextBox"></param>
        private void ProcessAllLines(RichTextBox richTextBox)
        {
            bool nonStandardLettersFound = false;
            StringBuilder sb = new StringBuilder();

            foreach (char ch in richTextBox.Text.ToUpper())
            {
                if (ch == 'A' || ch == 'C' || ch == 'G' || ch == 'T')
                {
                    sb.Append(ch);
                }
                else
                {
                    nonStandardLettersFound = true;
                    sb.Append('N');
                }
            }

            richTextBox.Text = sb.ToString();

            // returns cursor to the end of text
            richTextBox.Select(richTextBox.Text.Length, 0);

            if (nonStandardLettersFound)
            {
                OutputMessages.Text = "Non standard characters found. Non standard characters are substituted to 'N'.";
            }
        }

        /// <summary>
        /// Reverse complement, box 1 (Sequence 1)
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            ToggleClickedButtonColor(sender as Button);
            ReverseComplement(richTextBox1);
        }

        /// <summary>
        /// Reverse complement for box 2 (sequence 2)
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            ToggleClickedButtonColor(sender as Button);
            ReverseComplement(richTextBox2);
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

        private void ReverseComplement(RichTextBox richTextBox)
        {
            char[] charArray = richTextBox.Text.ToCharArray();
            Array.Reverse(charArray);
            StringBuilder sb = new StringBuilder();

            foreach (char ch in charArray)
            {
                switch (ch)
                {
                    case 'A':
                        {
                            sb.Append('T');
                            break;
                        }

                    case 'T':
                        {
                            sb.Append('A');
                            break;
                        }

                    case 'C':
                        {
                            sb.Append('G');
                            break;
                        }

                    case 'G':
                        {
                            sb.Append('C');
                            break;
                        }

                    default:
                        {
                            sb.Append('N');
                            break;
                        }
                }

                richTextBox.Text = sb.ToString();
                richTextBox.Select(richTextBox.Text.Length, 0);
            }
        }
    }
}