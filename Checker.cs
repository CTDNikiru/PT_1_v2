using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_1_v2
{
    public class Checker
    {
        public bool IsOkay(string input, bool needSeparator)
        {
            if(input.Length == 0)
            {
                throw new Exception("Empty input");
            }
            bool haveSeparator = false;
            for(int i = 0; i<input.Length; i++)
            {
                if(input[i] < '0' || input[i] > '9')
                {
                    if ((input[i] == ',' || input[i] == '.') && !haveSeparator && needSeparator)
                    {
                        haveSeparator = true;
                    }
                    else
                    {
                        if ((input[i] == ',' || input[i] == '.') && needSeparator)
                        {
                            throw new Exception("Input error: many separators");
                        }
                        else if (input[i] == ',' || input[i] == '.')
                        {
                            throw new Exception("Input error: separator not needed");
                        }
                        else
                        {
                            throw new Exception("Input error: not a number");
                        }
                    }
                }

            }
            return true;
        }
    }
}
