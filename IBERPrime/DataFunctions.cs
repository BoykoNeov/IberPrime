using System;
using System.Text;

namespace IBERPrime
{
    public static class DataFunctions
    {
        public static string ReturnReverseComplement(string inputString)
        {
            char[] temporary = inputString.ToCharArray();
            Array.Reverse(temporary);
            return ReturnComplement(new string(temporary));
        }

        public static string ReturnComplement (char[] inputCharArray)
        {
            if (inputCharArray == null)
            {
                throw new ArgumentException("Input is null");
            }

            return ReturnComplement(string.Join("", inputCharArray));
        }

        public static string ReturnComplement(string inputString)
        {
            if (inputString == null)
            {
                throw new ArgumentException("Input is null");
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputString.Length; i++)
            {
                char ch = inputString[i];
                switch (ch)
                {
                    case 'a':
                    case 'A':
                        {
                            sb.Append('T');
                            break;
                        }

                    case 't':
                    case 'T':
                        {
                            sb.Append('A');
                            break;
                        }

                    case 'c':
                    case 'C':
                        {
                            sb.Append('G');
                            break;
                        }

                    case 'g':
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
            }

            return sb.ToString();
        }
    }
}