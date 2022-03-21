using System.Collections.Generic;

namespace PT_1_v2
{
    public class History
    {
        private List<string> Inputs;
        private List<string> InputsCC;
        private List<string> Outputs;
        private List<string> OutputsCC;

        public void AddCalculation(string input, string inputSystem, string output, string outputSystem)
        {
            if(Inputs == null || InputsCC == null || Outputs == null || OutputsCC == null)
            {
                Inputs = new List<string>();
                InputsCC = new List<string>();
                Outputs = new List<string>();
                OutputsCC = new List<string>();
            }

            Inputs.Add(input);
            InputsCC.Add(inputSystem);
            Outputs.Add(output);
            OutputsCC.Add(outputSystem);
        }

        public string GetAllInput()
        {
            string result = "";
            if (Inputs != null)
            {
                foreach (var item in Inputs)
                {
                    result += item + "\n";
                }
            }
            return result;
        }

        public string GetAllInputCC()
        {
            string result = "";
            if (InputsCC != null)
            {
                foreach (var item in InputsCC)
                {
                    result += item + "\n";
                }
            }
            return result;
        }

        public string GetAllOut()
        {
            string result = "";
            if (Outputs != null)
            {
                foreach (var item in Outputs)
                {
                    result += item + "\n";
                }
            }
            return result;
        }

        public string GetAllOutCC()
        {
            string result = "";
            if (OutputsCC != null)
            {
                foreach (var item in OutputsCC)
                {
                    result += item + "\n";
                }
            }
            return result;
        }
    }
}
