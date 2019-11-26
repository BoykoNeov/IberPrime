using System.Windows.Forms;
using System;

namespace IBERPrime
{
    public partial class FindPrimers : Form
    {
        string[] inputSequences;

        public string[] InputSequences { get => this.inputSequences; private set => this.inputSequences = value; }

        public FindPrimers()
        {
            InitializeComponent();
        }

        public FindPrimers(string input)
        {
            this.inputSequences[0] = input;
            InitializeComponent();
        }

        private void findPrimerGoButton_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}