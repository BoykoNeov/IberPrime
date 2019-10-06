using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBERPrime
{

    public partial class Search : Form
    {
        //box with sequence to work on
        RichTextBox rtb;

        public Search(RichTextBox rtbox)
        {
            InitializeComponent();
            this.rtb = rtbox;
        }

        // TO DO
        private void findSubsequenceButton_Click(object sender, EventArgs e)
        {
            int permitedMismatchCount = (int)this.mismatchCounter.Value;
            bool searchComplement = this.complementCheckbox.Checked;
            bool searchReverseComplement = this.reverseComplementCheckbox.Checked;

            /// Just in case
            string inputFromFindBox = string.Join("", this.searchTextBox.Text.Split(new[] {" ", "\r\n", "\r", "\n", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)).ToUpper();
            string sequence = this.rtb.Text.ToUpper();

            int subsequenceLength = this.searchTextBox.Text.Length;

            Dictionary<int, int> foundPositions = new Dictionary<int, int>();
            List<string> subsequencesToSearch = new List<string>();
            subsequencesToSearch.Add(inputFromFindBox);

            if (searchComplement)
            {
                subsequencesToSearch.Add(Functions.ReturnComplement(inputFromFindBox));
            }

            if (searchReverseComplement)
            {
                char[] charSubsequence = inputFromFindBox.ToCharArray();
                Array.Reverse(charSubsequence);
                subsequencesToSearch.Add(Functions.ReturnComplement(charSubsequence));
            }

            for (int i = 0; i < sequence.Length - subsequenceLength + 1; i++)
            {
                foreach (string searchSubstring in subsequencesToSearch)
                {
                    int currentCycleMismatchCount = 0;

                    for (int j = 0; j < subsequenceLength; j++)
                    {
                        if (searchSubstring[j] == sequence[i + j] || searchSubstring[j] == 'N' || sequence[i + j] == 'N')
                        {
                            continue;
                        }
                        else
                        {
                            currentCycleMismatchCount++;
                        }
                    }

                    if (currentCycleMismatchCount > permitedMismatchCount)
                    {
                        continue;
                    }
                    else
                    {
                        foundPositions.Add(i, i + subsequenceLength);
                    }
                }
            }

            foreach (KeyValuePair<int, int> positions in foundPositions)
            {
                int beginning = positions.Key;
                int end = positions.Value;
                int rtbTextLength = this.rtb.Text.Length;

                //Check in case the content of textbox has changed (in this case the results may be invalid)
                if (beginning >= rtbTextLength || end >= rtbTextLength)
                {
                    continue;
                }

                rtb.Select(beginning, (end - beginning));
                rtb.SelectionColor = System.Drawing.Color.Yellow;
                rtb.SelectionBackColor = System.Drawing.Color.Black;
            }
        }
    }
}
