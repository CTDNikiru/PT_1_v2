using System;
using System.Linq;

namespace PT_1_v2
{
    public class Converter
    {
        private int Capasity;

        public Converter(int cap = 10)
        {
            Capasity = cap;
        }

        public string Convert_to(string input, int cc)
        {
            string result;

            //целая часть
            string zel = "0";
            //дробная часть
            string drb = "";

            bool isPartial = false;

            foreach (var number in input)
            {
                if (number == ',' || number == '.')
                {
                    isPartial = true;
                }
                else if (isPartial)
                {
                    drb += number;
                }
                else
                {
                    zel += number;
                }
            }

            zel = ZelToCC(Convert.ToInt32(zel), cc);
            drb = DrbToCC(drb, cc);

            result = zel + "," + drb;

            return result;
        }

        public string Convert_from(string input, int cc)
        {
            string result;

            //целая часть
            string zel = "0";
            //дробная часть
            string drb = "";

            bool isPartial = false;
            foreach (var number in input)
            {
                if (number == ',' || number == '.')
                {
                    isPartial = true;
                }
                else if (isPartial)
                {
                    drb += number;
                }
                else
                {
                    zel += number;
                }
            }

            result = (ZelFromCC(zel, cc) + DrbFromCC(drb, cc)).ToString();

            return result;
        }

        private string DrbToCC(string drb, int cc)
        {
            string result = "";
            int toRemove = 0;
            foreach (var number in drb)
            {
                if (number == '0')
                {
                    result += number;
                    toRemove++;
                }
                else
                {
                    break;
                }
            }
            drb = drb.Remove(0, toRemove);

            double drob = Convert.ToDouble("0," + drb) * cc;

            for (int i = 0; i < Capasity; i++)
            {
                result += IntToLetter(Convert.ToInt32(Math.Truncate(drob)));
                drob = drob - Math.Truncate(drob);
                drob *= cc;
            }

            result = result.TrimEnd('0');

            if (result.Length == 0)
            {
                result = "0";
            }
            return result;
        }

        private double DrbFromCC(string drb, int cc)
        {
            double result = 0;

            int bufer = 0;

            for (int i = 1; i < drb.Length + 1; i++)
            {
                if (drb[i - 1] < '0' || drb[i - 1] > '9')
                {
                    bufer = LetterToInt(drb[i - 1]);
                }
                else
                {
                    bufer = Convert.ToInt32(drb[i - 1] - '0');
                }
                result += bufer * Math.Pow(cc, -i);
            }

            return result;
        }

        private string ZelToCC(int zel, int cc)
        {
            string result = "";
            for (int i = 0; i < Capasity; i++)
            {
                result += IntToLetter(zel % cc);
                zel = zel / cc;
            }
            result = new string(result.Reverse().ToArray()).TrimStart('0');

            if (result.Length == 0)
            {
                result = "0";
            }

            return result;
        }

        private double ZelFromCC(string zel, int cc)
        {
            double result = 0;

            int bufer = 0;

            for(int i = 0; i<zel.Length; i++)
            {
                if(zel[i] <'0' || zel[i] > '9')
                {
                    bufer = LetterToInt(zel[i]);
                }
                else
                {
                    bufer = Convert.ToInt32(zel[i] - '0');
                }

                result += bufer * Math.Pow(cc, zel.Length - 1 - i);
            }


            return result;
        }

        private string IntToLetter(int ze)
        {
            string result = "";
            switch (ze)
            {
                case 10:
                    result = "A";
                    break;
                case 11:
                    result = "B";
                    break;
                case 12:
                    result = "C";
                    break;
                case 13:
                    result = "D";
                    break;
                case 14:
                    result = "E";
                    break;
                case 15:
                    result = "F";
                    break;
                default:
                    result = ze.ToString();
                    break;
            }
            return result;
        }

        private int LetterToInt(char ze)
        {
            int result = 0;
            switch (ze)
            {
                case 'A':
                    result = 10;
                    break;
                case 'B':
                    result = 11;
                    break;
                case 'C':
                    result = 12;
                    break;
                case 'D':
                    result = 13;
                    break;
                case 'E':
                    result = 14;
                    break;
                case 'F':
                    result = 15;
                    break;
                default:
                    result = ze - '0';
                    break;
            }
            return result;
        }
    }
}
