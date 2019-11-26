using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IBERPrime
{
    public partial class FindPrimers : Form
    {
        List<string> inputSequences;

        public List<string> InputSequences { get => this.inputSequences; private set => this.inputSequences = value; }

        public FindPrimers()
        {
            InitializeComponent();
        }

        public FindPrimers(string input) : this()
        {
            this.inputSequences = new List<string>();
            this.inputSequences.Add(input);
        }

        private void findPrimerGoButton_Click(object sender, System.EventArgs e)
        {
            decimal primerConcentration = 200;
            decimal saltConcentration = 50;
            decimal magnesiumConcentration = 2.5m;
            decimal desiredPrimerLength = 18;
            decimal desiredAmpliconLength = this.inputSequences[0].Length / 2;

            if (!decimal.TryParse(this.primerConcentrationBox.Text, out primerConcentration))
            {
                this.primerConcentrationBox.Text = primerConcentration.ToString();
            }

            if (!decimal.TryParse(this.saltConcentrationBox.Text, out saltConcentration))
            {
                this.saltConcentrationBox.Text = saltConcentration.ToString();
            }

            if (!decimal.TryParse(this.magnesiumConcentrationBox.Text, out magnesiumConcentration))
            {
                this.magnesiumConcentrationBox.Text = magnesiumConcentration.ToString();
            }

            if (!decimal.TryParse(this.desiredAmpliconLengthBox.Text, out desiredAmpliconLength))
            {
                desiredAmpliconLengthBox.Text = desiredAmpliconLength.ToString();
            }

            desiredPrimerLength = this.desiredPrimerLengthUpDown.Value;

            //Dictionary<Primer, decimal> forwardPrimersScore = new Dictionary<Primer, decimal>();
            List<Primer> forwardPrimerCanidates = new List<Primer>();
            List<Primer> reversePrimerCanidates = new List<Primer>();

            for (int i = 0; i < inputSequences[0].Length - desiredAmpliconLength; i++)
            {
                string forwardPrimerCandidateSequence = inputSequences[0].Substring(i, (int)desiredPrimerLength);


                Primer forwardPrimerCandidate = new Primer(forwardPrimerCandidateSequence, true);
                forwardPrimerCandidate.Tm = TmCalculator.CalculateTmSantaLucia(forwardPrimerCandidateSequence, saltConcentration, primerConcentration, magnesiumConcentration);
                forwardPrimerCandidate.SelfAlignmentScore = TmCalculator.CalculateSelfAlignment(forwardPrimerCandidateSequence);
                forwardPrimerCandidate.SelfEndAlignmentScore = TmCalculator.CalculateSelfEndAlignment(forwardPrimerCandidateSequence);

                forwardPrimerCanidates.Add(forwardPrimerCandidate);

            }

            for (int i = inputSequences[0].Length - 1 - (int)desiredPrimerLength; i > 0 + desiredAmpliconLength; i--)
            {
                string reversePrimerCandidateSequence = inputSequences[0].Substring(i, (int)desiredPrimerLength);
                reversePrimerCandidateSequence = DataFunctions.ReturnReverseComplement(reversePrimerCandidateSequence);
                Primer reversePrimerCandidate = new Primer(reversePrimerCandidateSequence, false);

                reversePrimerCandidate.Tm = TmCalculator.CalculateTmSantaLucia(reversePrimerCandidateSequence, saltConcentration, primerConcentration, magnesiumConcentration);
                reversePrimerCandidate.SelfAlignmentScore = TmCalculator.CalculateSelfAlignment(reversePrimerCandidateSequence);
                reversePrimerCandidate.SelfEndAlignmentScore = TmCalculator.CalculateSelfEndAlignment(reversePrimerCandidateSequence);

                reversePrimerCanidates.Add(reversePrimerCandidate);
            }

            Dictionary<Primer, Primer> mostSuitablePrimerPairs = new Dictionary<Primer, Primer>();
            Dictionary<Primer, decimal> lowestScoreForEachForwardPrimer = new Dictionary<Primer, decimal>();

            for (int i = 0; i < forwardPrimerCanidates.Count; i++)
            {
                Primer currentForwardPrimer = forwardPrimerCanidates[i];

                decimal bestScoreForCurrentForwardPrimer = decimal.MaxValue;
                int forwardPrimerIndexInSequence = this.inputSequences[0].IndexOf(currentForwardPrimer.Sequence);

                if (forwardPrimerIndexInSequence < 0)
                {
                    throw new InvalidOperationException("A bug in the program - the forward primer should be present in the sequence");
                }

                for (int j = 0; j < reversePrimerCanidates.Count; j++)
                {
                    Primer currentReversePrimer = reversePrimerCanidates[j];

                    int reversePrimerIndexInSequence = this.inputSequences[0].IndexOf(DataFunctions.ReturnReverseComplement(currentReversePrimer.Sequence));

                    if (reversePrimerIndexInSequence < 0)
                    {
                        throw new InvalidOperationException("A bug in the program - the reverse primer should be present in the sequence");
                    }

                    if (reversePrimerIndexInSequence - forwardPrimerIndexInSequence < desiredAmpliconLength)
                    {
                        break;
                    }

                    int distanceBetweenPrimers = reversePrimerIndexInSequence - forwardPrimerIndexInSequence;

                    decimal score;
                    decimal pairAnnealingValue = TmCalculator.CalculateTwoPrimerHybridization(currentForwardPrimer.Sequence, currentReversePrimer.Sequence);
                    decimal pairEndAnnealingValue = TmCalculator.CalculateTwoPrimerEndHybridization(currentForwardPrimer.Sequence, currentReversePrimer.Sequence);

                    score = (pairAnnealingValue * 2) * 0.1m +
                        (pairEndAnnealingValue * 2) * 0.2m +
                        currentReversePrimer.SelfAlignmentScore * 0.1m +
                        currentReversePrimer.SelfEndAlignmentScore * 0.2m +
                        currentForwardPrimer.SelfAlignmentScore * 0.1m +
                        currentForwardPrimer.SelfEndAlignmentScore * 0.2m +
                        Math.Abs(currentForwardPrimer.Tm - currentReversePrimer.Tm) +
                        distanceBetweenPrimers * 0.05m;
                    // TODO add coefficient for GC content

                    // From Kampke 2001
                    // Deviation from ideal length, length f = lengthr κ1 = κ2 = 0.5
                    // Deviation from ideal GC content, GC f = GCr κ3 = κ4 = 1
                    // Deviation from ideal temperature, Tm, f = Tm, r κ5 = κ6 = 1
                    // Deviation from ideal self annealing value 0 κ7 = κ8 = 0.1
                    // Deviation from ideal self-end annealing value 0 κ9 = κ10 = 0.2
                    // Deviation from ideal pair annealing value 0 κ11 = 0.1
                    // Deviation from ideal pair-end annealing value 0 κ12 = 0.2

                    // Deviation from ideal length = (ampliconLengt - desired Amplicon Length ) * 0.05

                    if (score < bestScoreForCurrentForwardPrimer)
                    {
                        bestScoreForCurrentForwardPrimer = score;
                        mostSuitablePrimerPairs[currentForwardPrimer] = currentReversePrimer;
                        lowestScoreForEachForwardPrimer[currentForwardPrimer] = score;
                    }
                }
            }

            Primer resultingForwardPrimer = lowestScoreForEachForwardPrimer.OrderBy(x => x.Value).First().Key;
            Primer resultingReversePrimer = mostSuitablePrimerPairs[resultingForwardPrimer];

            this.forwardPrimerBox.Text = resultingForwardPrimer.Sequence;
            this.forwardPrimerGCcontentBox.Text = resultingForwardPrimer.GCcontent.ToString();
            this.forwardPrimerLengthBox.Text = resultingForwardPrimer.Length.ToString();
            this.forwardPrimerScore.Text = lowestScoreForEachForwardPrimer[resultingForwardPrimer].ToString();
            this.forwardPrimerTmBox.Text = resultingForwardPrimer.Tm.ToString();

            this.reversePrimerBox.Text = resultingReversePrimer.Sequence;
            this.reversePrimerGCcontentBox.Text = resultingReversePrimer.GCcontent.ToString();
            this.reversePrimerLengthBox.Text = resultingReversePrimer.Length.ToString();
            this.reversePrimerTmBox.Text = resultingReversePrimer.Tm.ToString();

            decimal resultingPairAnnealingValue = TmCalculator.CalculateTwoPrimerHybridization(resultingForwardPrimer.Sequence, resultingReversePrimer.Sequence);
            decimal resultingPairEndAnnealingValue = TmCalculator.CalculateTwoPrimerEndHybridization(resultingForwardPrimer.Sequence, resultingReversePrimer.Sequence);

            decimal distanceBetweenResultingPrimers = Math.Abs(this.inputSequences[0].IndexOf(DataFunctions.ReturnReverseComplement(resultingReversePrimer.Sequence)) - this.inputSequences[0].IndexOf(resultingForwardPrimer.Sequence));

            this.resultingAmpliconLengthTextBox.Text = distanceBetweenResultingPrimers.ToString();

            if (this.inputSequences[0].IndexOf(DataFunctions.ReturnReverseComplement(resultingReversePrimer.Sequence)) < 0)
            {
                throw new IndexOutOfRangeException("error in finding primer in sequence");
            }

            if (this.inputSequences[0].IndexOf(resultingForwardPrimer.Sequence) < 0)
            {
                throw new IndexOutOfRangeException("error in finding primer in sequence");
            }

            this.reversePrimerScore.Text = ((resultingPairAnnealingValue * 2 * 0.1m) +
                        (resultingPairEndAnnealingValue * 2) * 0.2m +
                        resultingReversePrimer.SelfAlignmentScore * 0.1m +
                        resultingReversePrimer.SelfEndAlignmentScore * 0.2m +
                        resultingForwardPrimer.SelfAlignmentScore * 0.1m +
                        resultingForwardPrimer.SelfEndAlignmentScore * 0.2m +
                        Math.Abs(resultingForwardPrimer.Tm - resultingReversePrimer.Tm) +
                        distanceBetweenResultingPrimers * 0.05m).ToString();
        }

        private void desiredAmpliconLengthBox_TextChanged(object sender, EventArgs e)
        {
            int desiredAmpliconLength = 150;
            if (!int.TryParse(this.desiredAmpliconLengthBox.Text, out desiredAmpliconLength))
            {
                this.desiredAmpliconLengthBox.Text = desiredAmpliconLength.ToString();
            }
            else if (desiredAmpliconLength < 60)
            {
                this.desiredAmpliconLengthBox.Text = "60";
            }
            else if (desiredAmpliconLength > this.inputSequences[0].Length - ((desiredPrimerLengthUpDown.Value + 2) * 2))
            {
                this.desiredAmpliconLengthBox.Text = (this.inputSequences[0].Length - ((desiredPrimerLengthUpDown.Value + 2) * 2)).ToString();
            }
        }
    }
}