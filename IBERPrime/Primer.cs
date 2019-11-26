using System;

namespace IBERPrime
{
    public class Primer
    {
        public Primer()
        {
        }

        public Primer(string primerSequence) : this()
        {
            this.Sequence = primerSequence.ToUpper();
        }

        public Primer(string primerSequence, bool isPrimerForward) : this(primerSequence)
        {
            this.isForward = isPrimerForward;
        }

        string sequence;
        decimal tm;
        bool isForward;
        decimal selfAlignmentScore;
        decimal selfEndAlignmentScore;

        public string Sequence { get => this.sequence; set => this.sequence = value; }
        public decimal Tm { get => this.tm; set => this.tm = value; }
        public decimal GCcontent { get => this.CalculatePrimerGCPercentage(); }
        public bool IsForward { get => this.isForward; set => this.isForward = value; }

        public int Length { get => this.Sequence.Length; }
        public decimal SelfAlignmentScore { get => this.selfAlignmentScore; set => this.selfAlignmentScore = value; }
        public decimal SelfEndAlignmentScore { get => this.selfEndAlignmentScore; set => this.selfEndAlignmentScore = value; }

        private decimal CalculatePrimerGCPercentage()
        {
            decimal GCcount = 0;

            for (int i = 0; i < this.Length; i++)
            {
                if (this.Sequence[i] == 'G' || this.Sequence[i] == 'C')
                {
                    GCcount++;
                }
            }

            decimal GCpercentage = (Math.Round((GCcount / this.Length) * 100m, 2, MidpointRounding.AwayFromZero));

            return GCpercentage;
        }
    }
}