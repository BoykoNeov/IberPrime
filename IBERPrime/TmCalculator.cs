using System;
using System.Collections.Generic;
using System.Linq;

public static class TmCalculator
{
    /// <summary>
    /// Calculate Tm (primer melting temperature) according to a simple formula
    /// </summary>
    /// <param name="primer">input primer sequence</param>
    /// <returns>Tm</returns>
    public static decimal CalculateTmSimple(string primer)
    {
        //  decimal primerConcentrationGamma = 50 * (decimal)Math.Pow(10, -9);

        primer = primer.ToUpper();

        /* Tm= (number of A + number of T) * 2 + (number of G + number of C) * 4 from Marmur (1962)
        for sequences longer than 13 nucleotides, the equation is Tm= 64.9 + 41 * ( number of C-16.4) / (number of A + number of T+  number of G + number of C) */

        decimal numberOfA = 0;
        decimal numberOfT = 0;
        decimal numberOfG = 0;
        decimal numberofC = 0;

        for (int i = 0; i < primer.Length; i++)
        {
            if (primer[i] == 'A')
            {
                numberOfA++;
            }
            else if (primer[i] == 'T')
            {
                numberOfT++;
            }
            else if (primer[i] == 'G')
            {
                numberOfG++;
            }
            else if (primer[i] == 'C')
            {
                numberofC++;
            }
        }

        decimal TmSimple = 0;

        if (primer.Length <= 13)
        {
            TmSimple = ((numberOfA + numberOfT) * 2) + ((numberOfG + numberofC) * 4);
        }
        else
        {
            TmSimple = 64.9m + 41 * ((numberOfG + numberofC - 16.4m) / (numberOfA + numberOfT + numberOfG + numberofC));
        }

        return TmSimple;
    }

    /// <summary>
    /// Calculates Tm (melting temperature) of a sequence according to Santalucia 1998
    /// </summary>
    /// <param name="primer">input primer sequence</param>
    /// <param name="saltConcentration">salt concentration, withou Mg++, default 50mM</param>
    /// <param name="primerConcentration">primer concentration , default 200microM</param>
    /// <param name="magnesiumConcentration">Mg++ concentration, default 2.5mM</param>
    /// <returns>Tm, rounded to two decimal places</returns>
    public static decimal CalculateTmSantaLucia(string primer, decimal saltConcentration = 50m, decimal primerConcentration = 200m, decimal magnesiumConcentration = 2.5m)
    {
        Dictionary<string, decimal> entalpySantaTable = new Dictionary<string, decimal>();

        entalpySantaTable.Add("AA", -7.9m);
        entalpySantaTable.Add("AC", -8.4m);
        entalpySantaTable.Add("AG", -7.8m);
        entalpySantaTable.Add("AT", -7.2m);

        entalpySantaTable.Add("CA", -8.5m);
        entalpySantaTable.Add("CC", -8.0m);
        entalpySantaTable.Add("CG", -10.6m);
        entalpySantaTable.Add("CT", -7.8m);

        entalpySantaTable.Add("GA", -8.2m);
        entalpySantaTable.Add("GC", -9.8m);
        entalpySantaTable.Add("GG", -8.0m);
        entalpySantaTable.Add("GT", -8.4m);

        entalpySantaTable.Add("TA", -7.2m);
        entalpySantaTable.Add("TC", -8.2m);
        entalpySantaTable.Add("TG", -8.5m);
        entalpySantaTable.Add("TT", -7.9m);

        Dictionary<string, decimal> entropySantaTable = new Dictionary<string, decimal>();

        entropySantaTable.Add("AA", -22.2m);
        entropySantaTable.Add("AC", -22.4m);
        entropySantaTable.Add("AG", -21.0m);
        entropySantaTable.Add("AT", -20.4m);

        entropySantaTable.Add("CA", -22.7m);
        entropySantaTable.Add("CC", -19.9m);
        entropySantaTable.Add("CG", -27.2m);
        entropySantaTable.Add("CT", -21.0m);

        entropySantaTable.Add("GA", -22.2m);
        entropySantaTable.Add("GC", -24.4m);
        entropySantaTable.Add("GG", -19.9m);
        entropySantaTable.Add("GT", -22.4m);

        entropySantaTable.Add("TA", -21.3m);
        entropySantaTable.Add("TC", -22.2m);
        entropySantaTable.Add("TG", -22.7m);
        entropySantaTable.Add("TT", -22.2m);

        // entropy values

        decimal entalpySanta = 0;
        decimal entropySanta = 0;

        // Corrections for terminal nucleotides (Santalucia 1998)
        if (primer[0] == 'G' || primer[0] == 'C')
        {
            entalpySanta += 0.1m;
            entropySanta += -2.8m;
        }
        else if (primer[0] == 'A' || primer[0] == 'T')
        {
            entalpySanta += 2.3m;
            entropySanta += 4.1m;
        }

        if (primer[primer.Length - 1] == 'G' || primer[primer.Length - 1] == 'C')
        {
            entalpySanta += 0.1m;
            entropySanta += -2.8m;
        }
        else if (primer[primer.Length - 1] == 'A' || primer[primer.Length - 1] == 'T')
        {
            entalpySanta += 2.3m;
            entropySanta += 4.1m;
        }

        for (int i = 0; i < primer.Length - 1; i++)
        {
            string currentPair = primer.Substring(i, 2);
            entalpySanta += entalpySantaTable[currentPair];
            entropySanta += entropySantaTable[currentPair];
        }

        //default salt concentration 50mM , default Mg++ concentration 2.5mM, default primer concentration 200mM
        // effect on entropy by salt correction; von Ahsen et al 1999
        decimal saltEffect = (saltConcentration / 1000m) + ((magnesiumConcentration / 1000m) * 140m);

        decimal saltEffectOnEntropy = 0.368m * primer.Length * (decimal)Math.Log((double)saltEffect);
        entropySanta += saltEffectOnEntropy;


        decimal TmSanta = ((1000m * entalpySanta) / (entropySanta + (1.987m * (decimal)Math.Log((double)(primerConcentration / 2000000000))))) - 273.15m;

        return Math.Round(TmSanta, 2);
    }

    /// <summary>
    /// Calculates sequence GC content
    /// </summary>
    /// <param name="sequence">Sequence to calculate GC content</param>
    /// <returns>GC content to 2 decimal places</returns>
    public static decimal CalculateGCcontent(string sequence)
    {
        int GCcount = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == 'G' || sequence[i] == 'C')
            {
                GCcount++;
            }
        }

        decimal GCpercentage = ((decimal)GCcount / sequence.Length) * 100;
        return GCpercentage;
    }

    /// <summary>
    /// Calculate self end alignment score according to Kampke 2001
    /// </summary>
    /// <param name="primer"></param>
    /// <returns>self end alignment score</returns>
    public static int CalculateSelfEndAlignment(string primer)
    {
        return CalculateTwoPrimerEndHybridization(primer, primer);
    }

    /// <summary>
    /// Calculate total self alignment, including where 3'ends don't match
    /// </summary>
    /// <param name="primer"></param>
    /// <returns>self alignment score</returns>
    public static int CalculateSelfAlignment(string primer)
    {
        return CalculateTwoPrimerHybridization(primer, primer);
    }

    /// <summary>
    /// Calculate hybridization score between two primers
    /// </summary>
    /// <param name="firstPrimer">Forward primer</param>
    /// <param name="secondPrimer">Reverse primer</param>
    /// <returns>Max score</returns>
    public static int CalculateTwoPrimerEndHybridization(string firstPrimer, string secondPrimer)
    {
        string primerInForward = firstPrimer.ToUpper();
        char[] tempArray = secondPrimer.ToUpper().ToCharArray();
        Array.Reverse(tempArray);
        string primerInReverse = new string(tempArray);

        List<int> scores = new List<int>();

        // for all overlapping the comparision should be to (primer.Length * 2) - 1, but overlappings where there 3' end is not involved are discarded
        int longerPrimerLength = primerInForward.Length;
        if (primerInReverse.Length > longerPrimerLength)
        {
            longerPrimerLength = primerInReverse.Length;
        }

        for (int i = 0; i < (longerPrimerLength); i++)
        {
            string test1 = primerInForward.Insert(0, new string('-', (i)));
            string test2 = primerInReverse.Insert(0, new string('-', primerInForward.Length - 1));

            int currentStepScore = 0;

            //Calculate matching score in overlapping sequence pair by pair
            for (int j = 0; j < test1.Length && j < test2.Length; j++)
            {
                if (CheckPairwiseMatch(test1[j], test2[j]))
                {
                    currentStepScore += 2;
                }
            }

            if (!CheckPairwiseMatch(test1[test1.Length - 1], test2[test1.Length - 1]))
            {
                if (!CheckPairwiseMatch(test1[primerInForward.Length - 1], test2[primerInForward.Length - 1]))
                    currentStepScore = 0;
            }

            scores.Add(currentStepScore);

            //   For debugging
            //Console.WriteLine(test1);
            //Console.WriteLine(test2);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"current score: {currentStepScore}");
            //Console.WriteLine("***");
            //Console.ForegroundColor = ConsoleColor.White;
        }

        // For debugging
        //Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.WriteLine(String.Join(",", scores));

        return scores.Max();
    }

    public static int CalculateTwoPrimerHybridization(string firstPrimer, string secondPrimer)
    {
        string primerInForward = firstPrimer.ToUpper();
        char[] tempArray = secondPrimer.ToUpper().ToCharArray();
        Array.Reverse(tempArray);
        string primerInReverse = new string(tempArray);

        //For debugging
        //string stringforMatches = "";

        List<int> scores = new List<int>();

        // for all overlapping the comparision should be to (primer.Length * 2) - 1, but overlappings where there 3' end is not involved are discarded
        int longerPrimerLength = primerInForward.Length;
        if (primerInReverse.Length > longerPrimerLength)
        {
            longerPrimerLength = primerInReverse.Length;
        }

        for (int i = 0; i < (longerPrimerLength * 2 - 1); i++)
        {
            string test1 = primerInForward.Insert(0, new string('-', (i)));
            string test2 = primerInReverse.Insert(0, new string('-', primerInForward.Length - 1));

            int currentStepScore = 0;

            //Calculate matching score in overlapping sequence pair by pair
            for (int j = 0; j < test1.Length && j < test2.Length; j++)
            {
                if (CheckPairwiseMatch(test1[j], test2[j]))
                {
                    currentStepScore += 2;

                    //   For debugging
                    //    stringforMatches += '|';
                    //}
                    //else
                    //{
                    //    stringforMatches += ' ';
                }
            }

            scores.Add(currentStepScore);

            //  For debugging
            //Console.WriteLine(test1);
            //Console.WriteLine(stringforMatches);
            //stringforMatches = "";
            //Console.WriteLine(test2);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"current score: {currentStepScore}");
            //Console.WriteLine("***");
            //Console.ForegroundColor = ConsoleColor.White;
        }

        //For debugging
        //Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.WriteLine(String.Join(",", scores));

        return scores.Max();
    }

    /// <summary>
    /// Check if bases match, only uppercase
    /// </summary>
    /// <param name="firstBase"></param>
    /// <param name="secondBase"></param>
    /// <returns>true (match) or false (mismatch)</returns>
    private static bool CheckPairwiseMatch(char firstBase, char secondBase)
    {
        if (firstBase == 'C' && secondBase == 'G')
        {
            return true;
        }
        else if (firstBase == 'G' && secondBase == 'C')
        {
            return true;
        }
        else if (firstBase == 'A' && secondBase == 'T')
        {
            return true;
        }
        else if (firstBase == 'T' && secondBase == 'A')
        {
            return true;
        }

        return false;
    }
}