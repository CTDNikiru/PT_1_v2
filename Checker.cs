using System;


namespace PT_1_v2
{
    public class Checker
    {
        public bool IsOkay(string input, bool needSeparator, int cc)
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
                            throw new Exception("Many separators");
                        }
                        else if (input[i] == ',' || input[i] == '.')
                        {
                            throw new Exception("Separator not needed");
                        }
                        else if (input[i] < 'A' || input[i] > 'F')
                        {
                            throw new Exception("Undefind symbol");
                        }
                        else
                        {
                            //checker >=10
                            if (input[i] - 'A' >= cc-10)
                            {
                                throw new Exception("Out of system");
                            }
                        }
                    }
                }
                else
                {
                    //checker <= 9
                    if(input[i] - '0' >= cc)
                    {
                        throw new Exception("Out of system");
                    }
                }

            }
            return true;
        }
    }
}
