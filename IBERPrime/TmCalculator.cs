using System;
using System.Collections.Generic;

static class TmCalculator
{
    public static decimal CalculateTmSimple(string input)
    {
        decimal primerConcentrationGamma = 50 * (decimal)Math.Pow(10, -9);

        input = input.ToUpper();


        /* Tm= (number of A + number of T) * 2 + (number of G + number of C) * 4 from Marmur (1962)
        for sequences longer than 13 nucleotides, the equation is Tm= 64.9 + 41 * ( number of C-16.4) / (number of A + number of T+  number of G + number of C) */

        decimal numberOfA = 0;
        decimal numberOfT = 0;
        decimal numberOfG = 0;
        decimal numberofC = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'A')
            {
                numberOfA++;
            }
            else if (input[i] == 'T')
            {
                numberOfT++;
            }
            else if (input[i] == 'G')
            {
                numberOfG++;
            }
            else if (input[i] == 'C')
            {
                numberofC++;
            }
        }

        decimal TmSimple = 0;

        if (input.Length <= 13)
        {
            TmSimple = ((numberOfA + numberOfT) * 2) + ((numberOfG + numberofC) * 4);
        }
        else
        {
            TmSimple = 64.9m + 41 * ((numberOfG + numberofC - 16.4m) / (numberOfA + numberOfT + numberOfG + numberofC));
        }

        return TmSimple;
    }

    public static decimal CalculateTmSantaLucia(string input, decimal saltConcentration = 50m, decimal primerConcentration = 200m, decimal magnesiumConcentration = 2.5m)
    {
        //Santalucia 1998
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
        if (input[0] == 'G' || input[0] == 'C')
        {
            entalpySanta += 0.1m;
            entropySanta += -2.8m;
        }
        else if (input[0] == 'A' || input[0] == 'T')
        {
            entalpySanta += 2.3m;
            entropySanta += 4.1m;
        }

        if (input[input.Length - 1] == 'G' || input[input.Length - 1] == 'C')
        {
            entalpySanta += 0.1m;
            entropySanta += -2.8m;
        }
        else if (input[input.Length - 1] == 'A' || input[input.Length - 1] == 'T')
        {
            entalpySanta += 2.3m;
            entropySanta += 4.1m;
        }

        for (int i = 0; i < input.Length - 1; i++)
        {
            string currentPair = input.Substring(i, 2);
            entalpySanta += entalpySantaTable[currentPair];
            entropySanta += entropySantaTable[currentPair];
        }

        //default salt concentration 50mM , default Mg++ concentration 2.5mM, default primer concentration 200mM
        // effect on entropy by salt correction; von Ahsen et al 1999
        decimal saltEffect = (saltConcentration / 1000m) + ((magnesiumConcentration / 1000m) * 140m);

        decimal saltEffectOnEntropy = 0.368m * input.Length * (decimal)Math.Log((double)saltEffect);
        entropySanta += saltEffectOnEntropy;


        decimal TmSanta = ((1000m * entalpySanta) / (entropySanta + (1.987m * (decimal)Math.Log((double)(primerConcentration / 2000000000))))) - 273.15m;

        return TmSanta;
    }

    public static decimal CalculateGCcontent(string input)
    {
        int GCcount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'G' || input[i] == 'C')
            {
                GCcount++;
            }
        }

        decimal GCpercentage = ((decimal)GCcount / input.Length) * 100;
        return GCpercentage;
    }
}